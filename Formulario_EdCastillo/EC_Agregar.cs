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
    public partial class EC_Agregar : Form
    {
        public EC_Agregar()
        {
            InitializeComponent();
        }

        private void CmboxTipo_EC_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
            

        private void EC_bntAgregar_Click(object sender, EventArgs e)
        {
            EC_Class ECBaseDatos = new EC_Class();
            string Query = " insert into ECtbl_veterinaria (Tipo, NombreMascota, Nombre, Apellido, Rut, Ingreso, Peso)" +
                             " values" +
                             "('" + CmboxTipo_EC.Text + "', '" + txtECnombremascota.Text + "', '" + txtECnombredueño.Text + "', '" +
                             txtECapellidos.Text + "', '" + txtECrut.Text + "', '" + Convert.ToDateTime(txtECfechaIngreso.Text).ToString("dd-MM-yyyy") + "','" +
                             txtECpeso.Text +txtECTamaño.Text + "')";
            ECBaseDatos.EjecutaSQLComando(Query);
            MessageBox.Show(" Datos Agregados!");
        }

        private void txtECnombremascota_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtECnombredueño_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtECapellidos_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtECrut_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtECfechaIngreso_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtECpeso_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtECTamaño_TextChanged(object sender, EventArgs e)
        {

        }

     

        private void txtECpeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtECTamaño_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void EC_Agregar_Load_1(object sender, EventArgs e)
        {
            CmboxTipo_EC.Items.Add("Perro y Gato");
            CmboxTipo_EC.Items.Add("Animales Exoticos");

        }


        }





    }

