using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameRental
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gametabelDataSet.Client' table. You can move, or remove it, as needed.
            this.clientTableAdapter1.Fill(this.gametabelDataSet.Client);
            // TODO: This line of code loads data into the 'gametabelDataSet.User' table. You can move, or remove it, as needed.
            SqlConnection sQLconnection = new System.Data.SqlClient.SqlConnection("Data Source=DESKTOP-T2PHMT9;Initial Catalog=Gametabel;Integrated Security=True");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sQLconnection = new SqlConnection("Data Source=DESKTOP-T2PHMT9;Initial Catalog=Gametabel;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sQLconnection;
            sQLconnection.Open();
            sqlCommand.CommandText = "Insert into User values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "') ";
            sqlCommand.ExecuteNonQuery();

            sQLconnection.Close();
            MessageBox.Show("Insertation was successfuly completed");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection sQLconnection = new SqlConnection("Data Source=DESKTOP-T2PHMT9;Initial Catalog=Gametabel;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sQLconnection;
            sQLconnection.Open();
            sqlCommand.CommandText = "UPDATE Client SET NAME = '" + textBox2.Text + "'where UserName '" + textBox1.Text + "' ";

            sqlCommand.ExecuteNonQuery();


            sQLconnection.Close();
            MessageBox.Show("Updating was successfuly completed");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection sQLconnection = new SqlConnection("Data Source=DESKTOP-T2PHMT9;Initial Catalog=Gametabel;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sQLconnection;
            sQLconnection.Open();
            sqlCommand.CommandText = "Delete From Client where USerName =  '" + textBox1.Text + "' ";
            sqlCommand.ExecuteNonQuery();

            sQLconnection.Close();
            MessageBox.Show("Deletion was successfuly completed");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.userTableAdapter.Fill(this.gametabelDataSet.User);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
