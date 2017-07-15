namespace Formulario_EdCastillo
{
    partial class ECFormMenu
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
            this.EC_btnDelete = new System.Windows.Forms.Button();
            this.EC_btnUpdate = new System.Windows.Forms.Button();
            this.EC_btnAddDatos = new System.Windows.Forms.Button();
            this.EC_btnMostrarDatos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EC_btnDelete
            // 
            this.EC_btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EC_btnDelete.Location = new System.Drawing.Point(270, 246);
            this.EC_btnDelete.Name = "EC_btnDelete";
            this.EC_btnDelete.Size = new System.Drawing.Size(132, 80);
            this.EC_btnDelete.TabIndex = 0;
            this.EC_btnDelete.Text = "Eliminar";
            this.EC_btnDelete.UseVisualStyleBackColor = true;
            this.EC_btnDelete.Click += new System.EventHandler(this.EC_btnDelete_Click);
            // 
            // EC_btnUpdate
            // 
            this.EC_btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EC_btnUpdate.Location = new System.Drawing.Point(35, 246);
            this.EC_btnUpdate.Name = "EC_btnUpdate";
            this.EC_btnUpdate.Size = new System.Drawing.Size(132, 80);
            this.EC_btnUpdate.TabIndex = 1;
            this.EC_btnUpdate.Text = "Actualizar";
            this.EC_btnUpdate.UseVisualStyleBackColor = true;
            this.EC_btnUpdate.Click += new System.EventHandler(this.EC_btnUpdate_Click);
            // 
            // EC_btnAddDatos
            // 
            this.EC_btnAddDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EC_btnAddDatos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.EC_btnAddDatos.Location = new System.Drawing.Point(35, 103);
            this.EC_btnAddDatos.Name = "EC_btnAddDatos";
            this.EC_btnAddDatos.Size = new System.Drawing.Size(132, 80);
            this.EC_btnAddDatos.TabIndex = 2;
            this.EC_btnAddDatos.Text = "Crear";
            this.EC_btnAddDatos.UseVisualStyleBackColor = true;
            this.EC_btnAddDatos.Click += new System.EventHandler(this.button3_Click);
            // 
            // EC_btnMostrarDatos
            // 
            this.EC_btnMostrarDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EC_btnMostrarDatos.Location = new System.Drawing.Point(270, 103);
            this.EC_btnMostrarDatos.Name = "EC_btnMostrarDatos";
            this.EC_btnMostrarDatos.Size = new System.Drawing.Size(132, 80);
            this.EC_btnMostrarDatos.TabIndex = 3;
            this.EC_btnMostrarDatos.Text = "Leer";
            this.EC_btnMostrarDatos.UseVisualStyleBackColor = true;
            this.EC_btnMostrarDatos.Click += new System.EventHandler(this.EC_btnMostrarDatos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(171, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Menu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(290, 383);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Veterinaria DoctorDog";
            // 
            // ECFormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(427, 397);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EC_btnMostrarDatos);
            this.Controls.Add(this.EC_btnAddDatos);
            this.Controls.Add(this.EC_btnUpdate);
            this.Controls.Add(this.EC_btnDelete);
            this.Name = "ECFormMenu";
            this.Text = "ECFormMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EC_btnDelete;
        private System.Windows.Forms.Button EC_btnUpdate;
        private System.Windows.Forms.Button EC_btnAddDatos;
        private System.Windows.Forms.Button EC_btnMostrarDatos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}