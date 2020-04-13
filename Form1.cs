using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace $safeprojectname$
{/*
  * namespace DisplayDBTableinDG
{
    public partial class Form1 : Form
    {
     
       
        

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM $safeprojectname$",sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                //method 1 - direct method
                dgv1.DataSource = dtbl;

                //method 2 : DG Columns
                dgv2.AutoGenerateColumns = false;
                dgv2.DataSource = dtbl;
                
            }
        }
    }
}

  * 
  */
    public partial class Form1 : Form
    {
        string connectionString = @"Data Source=hmftj; Initial Catalog = $safeprojectname$; Integrated Security=True;";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pOSIMSDataSet4.pro' table. You can move, or remove it, as needed.
            this.proTableAdapter.Fill(this.pOSIMSDataSet4.pro);
            // TODO: This line of code loads data into the 'pOSIMSDataSet2.$safeprojectname$' table. You can move, or remove it, as needed.
            this.pOSIMSTableAdapter.Fill(this.pOSIMSDataSet2.$safeprojectname$);

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form a = new Form();
            a.Show();
            //this.Hide();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 a = new Form2();
            a.Show();
            //this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void pOSIMSDataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Data Source=HMFTJ;Initial Catalog=$safeprojectname$;Integrated Security=True
        }

        private void Inventory_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 a = new Form3();
            a.Show();
          //  this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Pro", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                //method 1 - direct method
                dvg1.DataSource = dtbl;

                //method 2 : DG Columns
                dvg1.AutoGenerateColumns = false;
                dvg1.DataSource = dtbl;

            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form4 a = new Form4();
            a.Show();

        }
    }
}
