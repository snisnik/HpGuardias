namespace HpGurdias
{
    partial class HpGuardias
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mcLugar = new System.Windows.Forms.MonthCalendar();
            this.lstPersona = new System.Windows.Forms.ListBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCantLug = new System.Windows.Forms.TextBox();
            this.lstLugares = new System.Windows.Forms.ListBox();
            this.lblLugar = new System.Windows.Forms.Label();
            this.txtLugar = new System.Windows.Forms.TextBox();
            this.btnAgregarLugar = new System.Windows.Forms.Button();
            this.dtpMes = new System.Windows.Forms.DateTimePicker();
            this.btnGenerarMes = new System.Windows.Forms.Button();
            this.mcFeriados = new System.Windows.Forms.MonthCalendar();
            this.lblMes = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblGenerarGuardias = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCantResi = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mcLugar
            // 
            this.mcLugar.Location = new System.Drawing.Point(9, 51);
            this.mcLugar.Name = "mcLugar";
            this.mcLugar.TabIndex = 0;
            this.mcLugar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.monthCalendar1_MouseDown);
            // 
            // lstPersona
            // 
            this.lstPersona.FormattingEnabled = true;
            this.lstPersona.Location = new System.Drawing.Point(1179, 31);
            this.lstPersona.Name = "lstPersona";
            this.lstPersona.Size = new System.Drawing.Size(120, 95);
            this.lstPersona.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(903, 70);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(153, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(825, 73);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(58, 13);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Residente:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(1084, 39);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCantLug);
            this.groupBox1.Controls.Add(this.lstLugares);
            this.groupBox1.Controls.Add(this.lblLugar);
            this.groupBox1.Controls.Add(this.mcLugar);
            this.groupBox1.Controls.Add(this.txtLugar);
            this.groupBox1.Controls.Add(this.btnAgregarLugar);
            this.groupBox1.Location = new System.Drawing.Point(9, 337);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(620, 242);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Guardias";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "# de lugares";
            // 
            // txtCantLug
            // 
            this.txtCantLug.Location = new System.Drawing.Point(338, 22);
            this.txtCantLug.Name = "txtCantLug";
            this.txtCantLug.Size = new System.Drawing.Size(153, 20);
            this.txtCantLug.TabIndex = 15;
            // 
            // lstLugares
            // 
            this.lstLugares.FormattingEnabled = true;
            this.lstLugares.Location = new System.Drawing.Point(439, 67);
            this.lstLugares.Name = "lstLugares";
            this.lstLugares.Size = new System.Drawing.Size(120, 95);
            this.lstLugares.TabIndex = 14;
            // 
            // lblLugar
            // 
            this.lblLugar.AutoSize = true;
            this.lblLugar.Location = new System.Drawing.Point(1, 22);
            this.lblLugar.Name = "lblLugar";
            this.lblLugar.Size = new System.Drawing.Size(37, 13);
            this.lblLugar.TabIndex = 8;
            this.lblLugar.Text = "Lugar:";
            // 
            // txtLugar
            // 
            this.txtLugar.Location = new System.Drawing.Point(79, 19);
            this.txtLugar.Name = "txtLugar";
            this.txtLugar.Size = new System.Drawing.Size(153, 20);
            this.txtLugar.TabIndex = 7;
            // 
            // btnAgregarLugar
            // 
            this.btnAgregarLugar.Location = new System.Drawing.Point(248, 190);
            this.btnAgregarLugar.Name = "btnAgregarLugar";
            this.btnAgregarLugar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarLugar.TabIndex = 7;
            this.btnAgregarLugar.Text = "Agregar";
            this.btnAgregarLugar.UseVisualStyleBackColor = true;
            this.btnAgregarLugar.Click += new System.EventHandler(this.btnAgregarLugar_Click_1);
            // 
            // dtpMes
            // 
            this.dtpMes.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMes.Location = new System.Drawing.Point(104, 30);
            this.dtpMes.Name = "dtpMes";
            this.dtpMes.Size = new System.Drawing.Size(132, 20);
            this.dtpMes.TabIndex = 9;
            // 
            // btnGenerarMes
            // 
            this.btnGenerarMes.Location = new System.Drawing.Point(9, 259);
            this.btnGenerarMes.Name = "btnGenerarMes";
            this.btnGenerarMes.Size = new System.Drawing.Size(111, 23);
            this.btnGenerarMes.TabIndex = 11;
            this.btnGenerarMes.Text = "Generar Mes";
            this.btnGenerarMes.UseVisualStyleBackColor = true;
            this.btnGenerarMes.Click += new System.EventHandler(this.btnGenerarMes_Click);
            // 
            // mcFeriados
            // 
            this.mcFeriados.Location = new System.Drawing.Point(9, 85);
            this.mcFeriados.Name = "mcFeriados";
            this.mcFeriados.TabIndex = 9;
            this.mcFeriados.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mcFeriados_MouseDown);
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Location = new System.Drawing.Point(12, 31);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(86, 13);
            this.lblMes.TabIndex = 12;
            this.lblMes.Text = "Seleccione Mes:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Seleccione Feriados:";
            // 
            // lblGenerarGuardias
            // 
            this.lblGenerarGuardias.BackColor = System.Drawing.SystemColors.Control;
            this.lblGenerarGuardias.Location = new System.Drawing.Point(1206, 682);
            this.lblGenerarGuardias.Name = "lblGenerarGuardias";
            this.lblGenerarGuardias.Size = new System.Drawing.Size(119, 23);
            this.lblGenerarGuardias.TabIndex = 14;
            this.lblGenerarGuardias.Text = "Generar Guardias";
            this.lblGenerarGuardias.UseVisualStyleBackColor = false;
            this.lblGenerarGuardias.Click += new System.EventHandler(this.lblGenerarGuardias_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(825, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "cantResi";
            // 
            // txtCantResi
            // 
            this.txtCantResi.Location = new System.Drawing.Point(903, 39);
            this.txtCantResi.Name = "txtCantResi";
            this.txtCantResi.Size = new System.Drawing.Size(153, 20);
            this.txtCantResi.TabIndex = 15;
            // 
            // HpGuardias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1373, 738);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCantResi);
            this.Controls.Add(this.lblGenerarGuardias);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMes);
            this.Controls.Add(this.mcFeriados);
            this.Controls.Add(this.btnGenerarMes);
            this.Controls.Add(this.dtpMes);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lstPersona);
            this.Controls.Add(this.groupBox1);
            this.Name = "HpGuardias";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar mcLugar;
        private System.Windows.Forms.ListBox lstPersona;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblLugar;
        private System.Windows.Forms.TextBox txtLugar;
        private System.Windows.Forms.Button btnAgregarLugar;
        private System.Windows.Forms.DateTimePicker dtpMes;
        private System.Windows.Forms.Button btnGenerarMes;
        private System.Windows.Forms.MonthCalendar mcFeriados;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstLugares;
        private System.Windows.Forms.Button lblGenerarGuardias;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCantLug;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCantResi;
    }
}

