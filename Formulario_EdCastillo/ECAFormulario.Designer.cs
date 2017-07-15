namespace Formulario_EdCastillo
{
    partial class ECAFormulario
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.EC_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ECtxt1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ECtxt2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EC_btn
            // 
            this.EC_btn.Location = new System.Drawing.Point(178, 314);
            this.EC_btn.Margin = new System.Windows.Forms.Padding(5);
            this.EC_btn.Name = "EC_btn";
            this.EC_btn.Size = new System.Drawing.Size(87, 39);
            this.EC_btn.TabIndex = 0;
            this.EC_btn.Text = "Ingresar";
            this.EC_btn.UseVisualStyleBackColor = true;
            this.EC_btn.Click += new System.EventHandler(this.EC_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuario";
            // 
            // ECtxt1
            // 
            this.ECtxt1.Location = new System.Drawing.Point(43, 125);
            this.ECtxt1.Margin = new System.Windows.Forms.Padding(5);
            this.ECtxt1.Name = "ECtxt1";
            this.ECtxt1.Size = new System.Drawing.Size(164, 27);
            this.ECtxt1.TabIndex = 2;
            this.ECtxt1.TextChanged += new System.EventHandler(this.ECtxt1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 207);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña";
            // 
            // ECtxt2
            // 
            this.ECtxt2.Location = new System.Drawing.Point(43, 246);
            this.ECtxt2.Margin = new System.Windows.Forms.Padding(5);
            this.ECtxt2.Name = "ECtxt2";
            this.ECtxt2.PasswordChar = '*';
            this.ECtxt2.Size = new System.Drawing.Size(164, 27);
            this.ECtxt2.TabIndex = 4;
            this.ECtxt2.TextChanged += new System.EventHandler(this.ECtxt2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(159, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 50);
            this.label3.TabIndex = 5;
            this.label3.Text = "Login";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(305, 343);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 19);
            this.label4.TabIndex = 6;
            // 
            // ECAFormulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(437, 367);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ECtxt2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ECtxt1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EC_btn);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ECAFormulario";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ECAFormulario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EC_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ECtxt1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ECtxt2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

