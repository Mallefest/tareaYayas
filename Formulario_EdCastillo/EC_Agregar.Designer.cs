namespace Formulario_EdCastillo
{
    partial class EC_Agregar
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
            this.EC_bntAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.CmboxTipo_EC = new System.Windows.Forms.ComboBox();
            this.txtECnombremascota = new System.Windows.Forms.TextBox();
            this.txtECapellidos = new System.Windows.Forms.TextBox();
            this.txtECnombredueño = new System.Windows.Forms.TextBox();
            this.txtECrut = new System.Windows.Forms.TextBox();
            this.txtECfechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.txtECpeso = new System.Windows.Forms.TextBox();
            this.txtECTamaño = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // EC_bntAgregar
            // 
            this.EC_bntAgregar.Location = new System.Drawing.Point(175, 628);
            this.EC_bntAgregar.Name = "EC_bntAgregar";
            this.EC_bntAgregar.Size = new System.Drawing.Size(75, 23);
            this.EC_bntAgregar.TabIndex = 0;
            this.EC_bntAgregar.Text = "Agregar";
            this.EC_bntAgregar.UseVisualStyleBackColor = true;
            this.EC_bntAgregar.Click += new System.EventHandler(this.EC_bntAgregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ficha Veterinaria";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtECTamaño);
            this.groupBox1.Controls.Add(this.txtECpeso);
            this.groupBox1.Controls.Add(this.txtECfechaIngreso);
            this.groupBox1.Controls.Add(this.txtECrut);
            this.groupBox1.Controls.Add(this.txtECnombredueño);
            this.groupBox1.Controls.Add(this.txtECapellidos);
            this.groupBox1.Controls.Add(this.txtECnombremascota);
            this.groupBox1.Controls.Add(this.CmboxTipo_EC);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(25, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 541);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre de Mascota";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nombre Dueño";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Apellidos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 342);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Rut";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 397);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Fecha ingreso";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 444);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Peso";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 503);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Tamaño";
            // 
            // CmboxTipo_EC
            // 
            this.CmboxTipo_EC.FormattingEnabled = true;
            this.CmboxTipo_EC.Location = new System.Drawing.Point(125, 47);
            this.CmboxTipo_EC.Name = "CmboxTipo_EC";
            this.CmboxTipo_EC.Size = new System.Drawing.Size(121, 21);
            this.CmboxTipo_EC.TabIndex = 10;
            this.CmboxTipo_EC.SelectedIndexChanged += new System.EventHandler(this.CmboxTipo_EC_SelectedIndexChanged);
            // 
            // txtECnombremascota
            // 
            this.txtECnombremascota.Location = new System.Drawing.Point(125, 100);
            this.txtECnombremascota.Name = "txtECnombremascota";
            this.txtECnombremascota.Size = new System.Drawing.Size(200, 20);
            this.txtECnombremascota.TabIndex = 11;
            this.txtECnombremascota.TextChanged += new System.EventHandler(this.txtECnombremascota_TextChanged);
            // 
            // txtECapellidos
            // 
            this.txtECapellidos.Location = new System.Drawing.Point(125, 288);
            this.txtECapellidos.Name = "txtECapellidos";
            this.txtECapellidos.Size = new System.Drawing.Size(200, 20);
            this.txtECapellidos.TabIndex = 12;
            this.txtECapellidos.TextChanged += new System.EventHandler(this.txtECapellidos_TextChanged);
            // 
            // txtECnombredueño
            // 
            this.txtECnombredueño.Location = new System.Drawing.Point(125, 224);
            this.txtECnombredueño.Name = "txtECnombredueño";
            this.txtECnombredueño.Size = new System.Drawing.Size(200, 20);
            this.txtECnombredueño.TabIndex = 13;
            this.txtECnombredueño.TextChanged += new System.EventHandler(this.txtECnombredueño_TextChanged);
            // 
            // txtECrut
            // 
            this.txtECrut.Location = new System.Drawing.Point(125, 342);
            this.txtECrut.Name = "txtECrut";
            this.txtECrut.Size = new System.Drawing.Size(200, 20);
            this.txtECrut.TabIndex = 14;
            this.txtECrut.TextChanged += new System.EventHandler(this.txtECrut_TextChanged);
            // 
            // txtECfechaIngreso
            // 
            this.txtECfechaIngreso.Location = new System.Drawing.Point(125, 397);
            this.txtECfechaIngreso.Name = "txtECfechaIngreso";
            this.txtECfechaIngreso.Size = new System.Drawing.Size(200, 20);
            this.txtECfechaIngreso.TabIndex = 15;
            this.txtECfechaIngreso.ValueChanged += new System.EventHandler(this.txtECfechaIngreso_ValueChanged);
            // 
            // txtECpeso
            // 
            this.txtECpeso.Location = new System.Drawing.Point(125, 444);
            this.txtECpeso.Name = "txtECpeso";
            this.txtECpeso.Size = new System.Drawing.Size(100, 20);
            this.txtECpeso.TabIndex = 16;
            this.txtECpeso.TextChanged += new System.EventHandler(this.txtECpeso_TextChanged);
            // 
            // txtECTamaño
            // 
            this.txtECTamaño.Location = new System.Drawing.Point(125, 503);
            this.txtECTamaño.Name = "txtECTamaño";
            this.txtECTamaño.Size = new System.Drawing.Size(100, 20);
            this.txtECTamaño.TabIndex = 17;
            this.txtECTamaño.TextChanged += new System.EventHandler(this.txtECTamaño_TextChanged);
            // 
            // EC_Agregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(427, 663);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EC_bntAgregar);
            this.Name = "EC_Agregar";
            this.Text = "EC_Agregar";
            this.Load += new System.EventHandler(this.EC_Agregar_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EC_bntAgregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtECnombremascota;
        private System.Windows.Forms.ComboBox CmboxTipo_EC;
        private System.Windows.Forms.TextBox txtECnombredueño;
        private System.Windows.Forms.TextBox txtECapellidos;
        private System.Windows.Forms.DateTimePicker txtECfechaIngreso;
        private System.Windows.Forms.TextBox txtECrut;
        private System.Windows.Forms.TextBox txtECTamaño;
        private System.Windows.Forms.TextBox txtECpeso;
    }
}