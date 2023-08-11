using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace POS_build
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=1234");
            connection.Open();
            if (connection.State == ConnectionState.Open)
            {
                label6.Text = "Connected";
                label6.ForeColor = Color.Black;
            }
            else
            {
                label6.Text = "DisConnected";
                label6.ForeColor = Color.Red;
            }
        }
    }
}
