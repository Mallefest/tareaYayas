namespace Formulario_EdCastillo
{
    partial class EC_Update
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
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EC_txtSalida = new System.Windows.Forms.DateTimePicker();
            this.EC_txtingreso = new System.Windows.Forms.DateTimePicker();
            this.comboxTipo_EC = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.EC_txtRut = new System.Windows.Forms.TextBox();
            this.comboxID_EC = new System.Windows.Forms.ComboBox();
            this.EC_txtEstadia = new System.Windows.Forms.TextBox();
            this.EC_txtNombreDueño = new System.Windows.Forms.TextBox();
            this.EC_txtPeso = new System.Windows.Forms.TextBox();
            this.EC_txtTamaño = new System.Windows.Forms.TextBox();
            this.EC_txtApellido = new System.Windows.Forms.TextBox();
            this.EC_txtNombremascota = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.EC_bntOkUpdate = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Location = new System.Drawing.Point(258, 440);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(8, 14);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.EC_txtSalida);
            this.groupBox1.Controls.Add(this.EC_txtingreso);
            this.groupBox1.Controls.Add(this.comboxTipo_EC);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.EC_txtRut);
            this.groupBox1.Controls.Add(this.comboxID_EC);
            this.groupBox1.Controls.Add(this.EC_txtEstadia);
            this.groupBox1.Controls.Add(this.EC_txtNombreDueño);
            this.groupBox1.Controls.Add(this.EC_txtPeso);
            this.groupBox1.Controls.Add(this.EC_txtTamaño);
            this.groupBox1.Controls.Add(this.EC_txtApellido);
            this.groupBox1.Controls.Add(this.EC_txtNombremascota);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.groupBox1.Location = new System.Drawing.Point(12, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 467);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // EC_txtSalida
            // 
            this.EC_txtSalida.Location = new System.Drawing.Point(179, 310);
            this.EC_txtSalida.Name = "EC_txtSalida";
            this.EC_txtSalida.Size = new System.Drawing.Size(200, 22);
            this.EC_txtSalida.TabIndex = 25;
            this.EC_txtSalida.ValueChanged += new System.EventHandler(this.EC_txtSalida_ValueChanged);
            // 
            // EC_txtingreso
            // 
            this.EC_txtingreso.Location = new System.Drawing.Point(179, 270);
            this.EC_txtingreso.Name = "EC_txtingreso";
            this.EC_txtingreso.Size = new System.Drawing.Size(200, 22);
            this.EC_txtingreso.TabIndex = 24;
            this.EC_txtingreso.ValueChanged += new System.EventHandler(this.EC_txtingreso_ValueChanged);
            // 
            // comboxTipo_EC
            // 
            this.comboxTipo_EC.FormattingEnabled = true;
            this.comboxTipo_EC.Location = new System.Drawing.Point(184, 61);
            this.comboxTipo_EC.Name = "comboxTipo_EC";
            this.comboxTipo_EC.Size = new System.Drawing.Size(121, 24);
            this.comboxTipo_EC.TabIndex = 23;
            this.comboxTipo_EC.SelectedIndexChanged += new System.EventHandler(this.comboxTipo_EC_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(16, 67);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 16);
            this.label13.TabIndex = 22;
            this.label13.Text = "Tipo";
            // 
            // EC_txtRut
            // 
            this.EC_txtRut.Location = new System.Drawing.Point(184, 225);
            this.EC_txtRut.Name = "EC_txtRut";
            this.EC_txtRut.Size = new System.Drawing.Size(135, 22);
            this.EC_txtRut.TabIndex = 21;
            this.EC_txtRut.TextChanged += new System.EventHandler(this.EC_txtRut_TextChanged);
            // 
            // comboxID_EC
            // 
            this.comboxID_EC.FormattingEnabled = true;
            this.comboxID_EC.Location = new System.Drawing.Point(186, 26);
            this.comboxID_EC.Name = "comboxID_EC";
            this.comboxID_EC.Size = new System.Drawing.Size(121, 24);
            this.comboxID_EC.TabIndex = 20;
            this.comboxID_EC.SelectedIndexChanged += new System.EventHandler(this.comboxID_EC_SelectedIndexChanged);
            // 
            // EC_txtEstadia
            // 
            this.EC_txtEstadia.Location = new System.Drawing.Point(184, 352);
            this.EC_txtEstadia.Name = "EC_txtEstadia";
            this.EC_txtEstadia.Size = new System.Drawing.Size(185, 22);
            this.EC_txtEstadia.TabIndex = 19;
            this.EC_txtEstadia.TextChanged += new System.EventHandler(this.EC_txtEstadia_TextChanged);
            // 
            // EC_txtNombreDueño
            // 
            this.EC_txtNombreDueño.Location = new System.Drawing.Point(184, 156);
            this.EC_txtNombreDueño.Name = "EC_txtNombreDueño";
            this.EC_txtNombreDueño.Size = new System.Drawing.Size(185, 22);
            this.EC_txtNombreDueño.TabIndex = 18;
            this.EC_txtNombreDueño.TextChanged += new System.EventHandler(this.EC_txtNombreDueño_TextChanged);
            // 
            // EC_txtPeso
            // 
            this.EC_txtPeso.Location = new System.Drawing.Point(184, 387);
            this.EC_txtPeso.Name = "EC_txtPeso";
            this.EC_txtPeso.Size = new System.Drawing.Size(70, 22);
            this.EC_txtPeso.TabIndex = 16;
            this.EC_txtPeso.TextChanged += new System.EventHandler(this.EC_txtPeso_TextChanged);
            // 
            // EC_txtTamaño
            // 
            this.EC_txtTamaño.Location = new System.Drawing.Point(184, 432);
            this.EC_txtTamaño.Name = "EC_txtTamaño";
            this.EC_txtTamaño.Size = new System.Drawing.Size(70, 22);
            this.EC_txtTamaño.TabIndex = 15;
            this.EC_txtTamaño.TextChanged += new System.EventHandler(this.EC_txtTamaño_TextChanged);
            // 
            // EC_txtApellido
            // 
            this.EC_txtApellido.Location = new System.Drawing.Point(184, 191);
            this.EC_txtApellido.Name = "EC_txtApellido";
            this.EC_txtApellido.Size = new System.Drawing.Size(185, 22);
            this.EC_txtApellido.TabIndex = 13;
            this.EC_txtApellido.TextChanged += new System.EventHandler(this.EC_txtApellido_TextChanged);
            // 
            // EC_txtNombremascota
            // 
            this.EC_txtNombremascota.Location = new System.Drawing.Point(186, 119);
            this.EC_txtNombremascota.Name = "EC_txtNombremascota";
            this.EC_txtNombremascota.Size = new System.Drawing.Size(183, 22);
            this.EC_txtNombremascota.TabIndex = 11;
            this.EC_txtNombremascota.TextChanged += new System.EventHandler(this.EC_txtNombremascota_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(16, 159);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 16);
            this.label11.TabIndex = 9;
            this.label11.Text = "Nombre Dueño";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(16, 438);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 16);
            this.label10.TabIndex = 8;
            this.label10.Text = "Tamaño";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(22, 393);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 16);
            this.label9.TabIndex = 7;
            this.label9.Text = "Peso";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 352);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "Estadia";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 310);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Fecha de Salida";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Fecha de Ingreso";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Rut";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Apellidos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombre Mascota";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Actualizar Datos";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(314, 553);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(112, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Veterinaria DoctorDog";
            // 
            // EC_bntOkUpdate
            // 
            this.EC_bntOkUpdate.Location = new System.Drawing.Point(158, 527);
            this.EC_bntOkUpdate.Name = "EC_bntOkUpdate";
            this.EC_bntOkUpdate.Size = new System.Drawing.Size(87, 39);
            this.EC_bntOkUpdate.TabIndex = 7;
            this.EC_bntOkUpdate.Text = "OK";
            this.EC_bntOkUpdate.UseVisualStyleBackColor = true;
            this.EC_bntOkUpdate.Click += new System.EventHandler(this.EC_bntOkUpdate_Click);
            // 
            // EC_Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(426, 574);
            this.Controls.Add(this.EC_bntOkUpdate);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Name = "EC_Update";
            this.Text = "EC_Update";
            this.Load += new System.EventHandler(this.EC_Update_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EC_txtEstadia;
        private System.Windows.Forms.TextBox EC_txtNombreDueño;
        private System.Windows.Forms.TextBox EC_txtPeso;
        private System.Windows.Forms.TextBox EC_txtTamaño;
        private System.Windows.Forms.TextBox EC_txtApellido;
        private System.Windows.Forms.TextBox EC_txtNombremascota;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button EC_bntOkUpdate;
        private System.Windows.Forms.ComboBox comboxID_EC;
        private System.Windows.Forms.TextBox EC_txtRut;
        private System.Windows.Forms.ComboBox comboxTipo_EC;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker EC_txtSalida;
        private System.Windows.Forms.DateTimePicker EC_txtingreso;


    }
}