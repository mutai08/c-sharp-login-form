using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Login_Form
{
    public partial class Form1 : Form
    {
        private string connstring = String.Format("Server = {0}; Port = {1};" +
            "User Id = {2}; Password = {3}; Database {4};",
            "localhost", 5432, "postgres",
            "33264124", "users");

        private NpgsqlConnection conn = new NpgsqlConnection(connstring);


        conn.Open();


        public Form1()
        {
            InitializeComponent();
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            //conn = new NpgsqlConnection(connstring);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
