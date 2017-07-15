using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario_EdCastillo
{
    public partial class ECFormMenu : Form
    {
        public ECFormMenu()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EC_Agregar FM2 = new EC_Agregar();
            FM2.Show();
        }

        private void EC_btnMostrarDatos_Click(object sender, EventArgs e)
        {
            EC_FormReview Efm2 = new EC_FormReview();
            Efm2.Show();
        }

        private void EC_btnUpdate_Click(object sender, EventArgs e)
        {
            EC_Update FM3 = new EC_Update();
            FM3.Show();

        }

        private void EC_btnDelete_Click(object sender, EventArgs e)
        {
            EC_FormDelete FM4 = new EC_FormDelete();
            FM4.Show();

        }
    }
}
