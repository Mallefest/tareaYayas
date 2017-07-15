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
    public partial class ECAFormulario : Form
    {
        public ECAFormulario()
        {
            InitializeComponent();
        }

        private void ECtxt1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ECtxt2_TextChanged(object sender, EventArgs e)
        {

        }

        private void EC_btn_Click(object sender, EventArgs e)
        {
            string ECusario = ECtxt1.Text;
            string ECcontraseña = ECtxt2.Text;

            EC_Class BaseDatos = new EC_Class();
            string query = "select * from Usuario where Usuario = '" + ECusario + "' and Clave = '" + ECcontraseña + "'";
            string respuesta = BaseDatos.EjecutaSQLScalar(query);


            if (respuesta != "")
            {
                MessageBox.Show("Bienvenido a Veterinaria DoctorDog");

                ECFormMenu FM1 = new ECFormMenu();
                FM1.Show();

            }
            else
            {
                MessageBox.Show("Usuario NO valido");



            }
        }

        private void ECAFormulario_Load(object sender, EventArgs e)
        {

        }
    }
}
