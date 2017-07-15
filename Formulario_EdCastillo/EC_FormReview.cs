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
            string Query = " Select *from ECtbl_veterinaria";
           
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

        private void ECcmbID_SelectedIndexChanged(object sender, EventArgs e)
        {
             EC_Class DatebaseEC = new EC_Class();
             string Query2 = "select * from ECtbl_veterinaria  where id = " + ECcmbID.Text;
            DataSet ECdataset = DatebaseEC.LLenaComboGrid(Query2);
            DataTable ECdatatable = ECdataset.Tables[0];
            for (int f = 1; f < ECdataset.Tables.Count; f++)
            {
                ECdatatable = ECdataset.Tables[f];

            }
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = ECdatatable;

        }
       

        private void ECLlenarComboidReview()
        {

            EC_Class EcCOMBO = new EC_Class();
            string Query = "select Id from ECtbl_veterinaria";

            DataSet ECset = EcCOMBO.LLenaComboGrid(Query);
            DataTable ECtable = ECset.Tables[0];

            foreach (DataRow row in ECtable.Rows)
            {
                ECcmbID.Items.Add(row[0].ToString());
            }

        }

        private void EC_FormReview_Load(object sender, EventArgs e)
        {
            ECLlenarComboidReview();
        }
         
    }
    }

