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
    public partial class EC_Update : Form
    {
        public EC_Update()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }





        private void EC_txtNombremascota_TextChanged(object sender, EventArgs e)
        {

        }

        private void EC_txtTamaño_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboxID_EC_SelectedIndexChanged(object sender, EventArgs e)
        {
            ECmontarDATOS(comboxID_EC.Text);
        }


        private void ECmontarDATOS(string id)
        {

            EC_Class datebaseEC = new EC_Class();
            string Query = "select* from ECtbl_veterinaria where id=" + comboxID_EC.Text;

            DataSet DataSetEC = datebaseEC.LLenaComboGrid(Query);
            DataTable datatableEC = DataSetEC.Tables[0];

            foreach (DataRow row in datatableEC.Rows)
            {


                comboxTipo_EC.Text = row[1].ToString();
                EC_txtNombremascota.Text = row[2].ToString();
                EC_txtNombreDueño.Text = row[3].ToString();
                EC_txtApellido.Text = row[4].ToString();
                EC_txtRut.Text = row[5].ToString();
                EC_txtingreso.Text = row[6].ToString();
                EC_txtSalida.Text = row[7].ToString();
                EC_txtEstadia.Text = row[8].ToString();
                EC_txtPeso.Text = row[9].ToString();
                EC_txtTamaño.Text = row[10].ToString();
            }

          

        }




        private void EC_txtNombreDueño_TextChanged(object sender, EventArgs e)
        {

        }

        private void EC_txtApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void EC_txtRut_TextChanged(object sender, EventArgs e)
        {
            EC_txtRut.MaxLength = 10;
        }

        private void EC_txtingreso_TextChanged(object sender, EventArgs e)
        {

        }

        private void EC_txtSalida_TextChanged(object sender, EventArgs e)
        {


        }

        private void EC_txtEstadia_TextChanged(object sender, EventArgs e)
        {

        }

        private void EC_txtPeso_TextChanged(object sender, EventArgs e)
        {

        }

        private void EC_bntOkUpdate_Click(object sender, EventArgs e)
        {
            EC_Class ECBaseDato = new EC_Class();
            string Query = "update ECtbl_veterinaria set tipo='" + comboxTipo_EC + "', NombreMascota ='" + EC_txtNombremascota.Text + "', Nombre='" +
                                EC_txtNombreDueño + "', Apellido='" + EC_txtApellido + "', Rut='" + EC_txtRut + "', Ingreso='" +
                                Convert.ToDateTime(EC_txtingreso.Text) + "', Salida='" + Convert.ToDateTime(EC_txtSalida) + "', Estadia=" + EC_txtEstadia.Text + ", Peso=" + EC_txtPeso.Text + ", Tamano=" + EC_txtTamaño.Text +
                                " where Id='" + comboxID_EC.Text + "'";
            ECBaseDato.EjecutaSQLComando(Query);
            MessageBox.Show("Datos Actualziados!");
        }

        private void EC_Update_Load(object sender, EventArgs e)
        {
            ECLlenarComboid();
            comboxTipo_EC.Items.Add("Perro y Gato");
            comboxTipo_EC.Items.Add("Animales Exoticos");

        }

        private void ECLlenarComboid(){

            EC_Class EcCOMBO = new EC_Class();
            string Query = "select Id from ECtbl_veterinaria";

            DataSet ECset = EcCOMBO.LLenaComboGrid(Query);
            DataTable ECtable = ECset.Tables[0];

            foreach (DataRow row in ECtable.Rows)
            {
                comboxID_EC.Items.Add(row[0].ToString());
            }

        }



        private void comboxTipo_EC_SelectedIndexChanged(object sender, EventArgs e)
        {

            EC_txtNombremascota.Text = "chupalo";




        }

        private void EC_txtingreso_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
