﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gametabelDataSet.Admin' table. You can move, or remove it, as needed.
            this.adminTableAdapter.Fill(this.gametabelDataSet.Admin);

            SqlConnection sQLconnection = new System.Data.SqlClient.SqlConnection("Data Source=DESKTOP-T2PHMT9;Initial Catalog=Gametabel;Integrated Security=True");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sQLconnection = new SqlConnection("Data Source=DESKTOP-T2PHMT9;Initial Catalog=Gametabel;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sQLconnection;
            sQLconnection.Open();
            sqlCommand.CommandText = "Insert into admin values('" + textBox1.Text + "','" + textBox2.Text + "') ";
            sqlCommand.ExecuteNonQuery();

            sQLconnection.Close();
            MessageBox.Show("Insertation was successfuly completed");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection sQLconnection = new SqlConnection("Data Source=DESKTOP-T2PHMT9;Initial Catalog=Gametabel;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sQLconnection;
            sQLconnection.Open();
            sqlCommand.CommandText = "UPDATE  Admin SET NAME = '" + textBox2.Text + "'where UserName '" + textBox1.Text + "' ";
            sqlCommand.ExecuteNonQuery();

            sQLconnection.Close();
            MessageBox.Show("Updating was successfuly completed");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.adminTableAdapter.Fill(this.gametabelDataSet.Admin);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection sQLconnection = new SqlConnection("Data Source=DESKTOP-T2PHMT9;Initial Catalog=Gametabel;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sQLconnection;
            sQLconnection.Open();
            sqlCommand.CommandText = "Delete From admin where UserName =  '" + textBox1.Text + "' ";
            sqlCommand.ExecuteNonQuery();

            sQLconnection.Close();
            MessageBox.Show("Deletion was successfuly completed");
        }
    }
}
