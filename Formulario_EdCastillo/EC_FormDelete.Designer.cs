namespace Formulario_EdCastillo
{
    partial class EC_FormDelete
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EC_BntClickDelete = new System.Windows.Forms.Button();
            this.EC_comboxID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.EC_BntClickDelete);
            this.groupBox1.Controls.Add(this.EC_comboxID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 217);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecione una ID";
            // 
            // EC_BntClickDelete
            // 
            this.EC_BntClickDelete.Location = new System.Drawing.Point(127, 158);
            this.EC_BntClickDelete.Name = "EC_BntClickDelete";
            this.EC_BntClickDelete.Size = new System.Drawing.Size(87, 39);
            this.EC_BntClickDelete.TabIndex = 2;
            this.EC_BntClickDelete.Text = "Eliminar";
            this.EC_BntClickDelete.UseVisualStyleBackColor = true;
            this.EC_BntClickDelete.Click += new System.EventHandler(this.EC_BntClickDelete_Click);
            // 
            // EC_comboxID
            // 
            this.EC_comboxID.FormattingEnabled = true;
            this.EC_comboxID.Location = new System.Drawing.Point(64, 41);
            this.EC_comboxID.Name = "EC_comboxID";
            this.EC_comboxID.Size = new System.Drawing.Size(121, 21);
            this.EC_comboxID.TabIndex = 1;
            this.EC_comboxID.SelectedIndexChanged += new System.EventHandler(this.EC_comboxID_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(106, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Eliminar Datos";
            // 
            // EC_FormDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(398, 298);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Name = "EC_FormDelete";
            this.Text = "EC_FormDelete";
            this.Load += new System.EventHandler(this.EC_FormDelete_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button EC_BntClickDelete;
        private System.Windows.Forms.ComboBox EC_comboxID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}