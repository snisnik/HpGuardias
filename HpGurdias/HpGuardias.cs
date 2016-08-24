using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace HpGurdias
{
    public partial class HpGuardias : Form
    {
        Dia[] diasMes;
        Lugar[] lugares;
        Persona[] personas;
        int jL = 0;
        int jP = 0;
        int cantidadGuardias = 0;

        public HpGuardias()
        {
            InitializeComponent();
            dtpMes.Format = DateTimePickerFormat.Custom;
            dtpMes.CustomFormat = "MMMM, yyyy";
        }

        private void monthCalendar1_MouseDown(object sender, MouseEventArgs e)
        {
            MonthCalendar.HitTestInfo info = mcLugar.HitTest(e.Location);
            if (info.HitArea == MonthCalendar.HitArea.Date)
            {
                if (mcLugar.BoldedDates.Contains(info.Time))
                    mcLugar.RemoveBoldedDate(info.Time);
                else
                    mcLugar.AddBoldedDate(info.Time);
                mcLugar.UpdateBoldedDates();

            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(personas == null)
            {
                personas = new Persona[int.Parse(txtCantResi.Text)];
            }
            txtCantResi.Enabled = false;
            personas[jP] = new Persona();
            personas[jP].Name = txtNombre.Text;
            jP++;
            lstPersona.Items.Add(txtNombre.Text);
            txtNombre.Text = "";
        }


        private void btnGenerarMes_Click(object sender, EventArgs e)
        {
            int year;
            int mes;

            mes = dtpMes.Value.Month;
            year = dtpMes.Value.Year;


            int cantidadDias = System.DateTime.DaysInMonth(year, mes);
            diasMes = new Dia[cantidadDias];

            for (int i = 0; i < DateTime.DaysInMonth(year, mes); i++)
            {
                diasMes[i] = new Dia(i + 1, mes, year);

                if (diasMes[i].Date.ToString("dddd", new CultureInfo("es-ES")) == "sábado" || diasMes[i].Date.ToString("dddd", new CultureInfo("es-ES")) == "domingo")
                {
                    diasMes[i].Type = "24";
                }
                else
                {
                    diasMes[i].Type = "12";
                }
                for (int j = 0; j < mcFeriados.BoldedDates.Count(); j++)
                {
                    if (diasMes[i].Date == mcFeriados.BoldedDates[j])
                    {
                        diasMes[i].Type = "24";
                    }
                }

            }

        }

        private void mcFeriados_MouseDown(object sender, MouseEventArgs e)
        {
            MonthCalendar.HitTestInfo info = mcFeriados.HitTest(e.Location);
            if (info.HitArea == MonthCalendar.HitArea.Date)
            {
                if (mcFeriados.BoldedDates.Contains(info.Time))
                    mcFeriados.RemoveBoldedDate(info.Time);
                else
                    mcFeriados.AddBoldedDate(info.Time);
                mcFeriados.UpdateBoldedDates();

            }
        }


        private void btnAgregarLugar_Click_1(object sender, EventArgs e)
        {

            txtCantLug.Enabled = false;
            if(lugares == null)
            {
                lugares = new Lugar[int.Parse(txtCantLug.Text)];
            }
            
            String nombre = txtLugar.Text;
            DateTime[] dias = new DateTime[mcLugar.BoldedDates.Count()];

            for (int i = 0; i < mcLugar.BoldedDates.Count(); i++)
            {
                dias[i] = mcLugar.BoldedDates[i];
            }
            lugares[jL] = new Lugar(nombre, dias);
            jL++;
            lstLugares.Items.Add(nombre);
            cantidadGuardias = cantidadGuardias + mcLugar.BoldedDates.Count();
            txtLugar.Text = "";
            mcLugar.RemoveAllBoldedDates();
            mcLugar.UpdateBoldedDates();


        }

        private void lblGenerarGuardias_Click(object sender, EventArgs e)
        {
            int vecD = 0;
            int vecV = 0;

            int year;
            int mes;

            mes = dtpMes.Value.Month;
            year = dtpMes.Value.Year;
            DateTime currentDate = new DateTime(year, mes, 1);
            int indiceG = 0;

            Guardia[] guardias = new Guardia[cantidadGuardias];

            for (int i = 0; i < System.DateTime.DaysInMonth(year, mes); i++)
            {
                for (int j = 0; j < lugares.Length ; j++)
                {
                    for(int h = 0; h < lugares[j].Date.Length; h++)
                    {
                        if (lugares[j].Date[h] == currentDate)
                        {
                            guardias[indiceG] = new Guardia();
                            guardias[indiceG].Lugar = lugares[j].Nombre;
                            guardias[indiceG].Date = lugares[j].Date[h];
                            for(int k =0; k < diasMes.Length -1; k++)
                            {
                                if(diasMes[k].Date == lugares[j].Date[h])
                                {
                                    if(diasMes[k].Type == "12")
                                    {
                                        guardias[indiceG].Persona = personas[vecD].Name;
                                        personas[vecD].Doce = personas[vecD].Doce + 1;
                                        guardias[indiceG].Tipo = "12";
                                        vecD++;
                                        if(vecD > personas.Length - 1)
                                        {
                                            vecD = 0;
                                        }
                                    }
                                    else
                                    {
                                        guardias[indiceG].Persona = personas[vecV].Name;
                                        personas[vecV].Vc = personas[vecV].Vc + 1;
                                        guardias[indiceG].Tipo = "24";
                                        vecV++;
                                        if(vecV > personas.Length - 1)
                                        {
                                            vecV = 0;
                                        }
                                    }
                                }
                            }
                            indiceG++;

                        }
                    }
                }
                currentDate = currentDate.AddDays(1);
            }
            MessageBox.Show("Done");
        }
    }
}
