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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void Form13_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gametabelDataSet.Show' table. You can move, or remove it, as needed.
            SqlConnection sQLconnection = new System.Data.SqlClient.SqlConnection("Data Source=DESKTOP-T2PHMT9;Initial Catalog=Gametabel;Integrated Security=True");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sQLconnection = new SqlConnection("Data Source=DESKTOP-T2PHMT9;Initial Catalog=Gametabel;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sQLconnection;
            sQLconnection.Open();
            sqlCommand.CommandText = "Insert into show values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "') ";
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
            sqlCommand.CommandText = "UPDATE show SET NAME = '" + textBox2.Text + "'where Name '" + textBox1.Text + "' ";

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
            sqlCommand.CommandText = "Delete From Show where Name =  '" + textBox1.Text + "' ";
            sqlCommand.ExecuteNonQuery();

            sQLconnection.Close();
            MessageBox.Show("Deletion was successfuly completed");
        }

        private void button4_Click(object sender, EventArgs e)
        {
                        this.showTableAdapter.Fill(this.gametabelDataSet.Show);

        }
    }
}
