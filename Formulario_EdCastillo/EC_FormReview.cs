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
    public partial class EC_FormReview : Form
    {
        public EC_FormReview()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void EC_btn_Click(object sender, EventArgs e)
        {
            EC_Class DatebaseEC = new EC_Class();
            string Query = " Select *from ECtbl_veterinaria as EV inner join ECtbl_tipo_mascota as ET on EV.Tipo = ET.Tipo where EV.Tipo = ET.Tipo";
            DataSet ECdataset = DatebaseEC.LLenaComboGrid(Query);
            DataTable ECdatatable = ECdataset.Tables[0];
            for (int f = 1; f < ECdataset.Tables.Count; f++)
            {
                ECdatatable = ECdataset.Tables[f];

            }
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = ECdatatable;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
