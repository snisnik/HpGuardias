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

        public HpGuardias()
        {
            InitializeComponent();
            dtpMes.Format = DateTimePickerFormat.Custom;
            dtpMes.CustomFormat = "MMMM, yyyy";
        }

        private void monthCalendar1_MouseDown(object sender, MouseEventArgs e)
        {
            MonthCalendar.HitTestInfo info = monthCalendar1.HitTest(e.Location);
            if (info.HitArea == MonthCalendar.HitArea.Date)
            {
                if (monthCalendar1.BoldedDates.Contains(info.Time))
                    monthCalendar1.RemoveBoldedDate(info.Time);
                else
                    monthCalendar1.AddBoldedDate(info.Time);
                monthCalendar1.UpdateBoldedDates();

            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            lstPersona.Items.Add(txtNombre.Text);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ListBox.SelectedObjectCollection selectedItems = new ListBox.SelectedObjectCollection(lstPersona);
            selectedItems = lstPersona.SelectedItems;

            if (lstPersona.SelectedIndex != -1)
            {
                for (int i = selectedItems.Count - 1; i >= 0; i--)
                    lstPersona.Items.Remove(selectedItems[i]);
            }
            else
                MessageBox.Show("Debe seleccionar una persoa");
        }

        private void btnGenerarMes_Click(object sender, EventArgs e)
        {
            int year;
            int mes;

            mes = dtpMes.Value.Month;
            year = dtpMes.Value.Year;


            int cantidadDias= System.DateTime.DaysInMonth(year, mes);
            diasMes = new Dia[cantidadDias];

            for (int i = 0; i < DateTime.DaysInMonth(year, mes); i++)
            {
                diasMes[i] = new Dia(i+1, mes, year);

               if (diasMes[i].Date.ToString("dddd", new CultureInfo("es-ES")) == "sábado" || diasMes[i].Date.ToString("dddd", new CultureInfo("es-ES")) == "domingo")
                {
                    diasMes[i].Type = "24";
                }
               else
                {
                    diasMes[i].Type = "12";
                }
                for(int j = 0; j < mcFeriados.BoldedDates.Count(); j++)
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
    }
}
