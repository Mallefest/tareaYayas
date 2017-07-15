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
    public partial class EC_FormDelete : Form
    {
        public EC_FormDelete()
        {
            InitializeComponent();
        }

        private void EC_comboxID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void EC_FormDelete_Load(object sender, EventArgs e)
        {
            EliminarComboid();

        }
        private void EliminarComboid()
        {

            EC_Class ECbase = new EC_Class();
            string Query = "select id from ECtbl_veterinaria";

            DataSet ECdateset = ECbase.LLenaComboGrid(Query);
            DataTable ECtable = ECdateset.Tables[0];

            foreach (DataRow row in ECtable.Rows)
            {
                EC_comboxID.Items.Add(row[0].ToString());


            }
        }

        private void EC_BntClickDelete_Click(object sender, EventArgs e)
        {
            EC_Class ECBaseDato = new EC_Class();
            string Query = "delete from ECtbl_veterinaria where id=" + EC_comboxID.Text;
            ECBaseDato.EjecutaSQLComando(Query);
            MessageBox.Show("Fue Eliminado con exito");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

