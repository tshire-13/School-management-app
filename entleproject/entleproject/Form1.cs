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

namespace entleproject
{
    public partial class Form1 : Form
    {
        string connectionstring = @"Data Source=DESKTOP-TSHIRE\SQLEXPRESS02;Initial Catalog=schoolmagementdb;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(connectionstring);
            SqlCommand sqlcommand = new SqlCommand("select USERNAME,PASSWORD from Loginttbl where USERNAME = @Username and PASSWORD = @Password", sqlcon);
            sqlcommand.Parameters.AddWithValue("@Username", txtusername.Text);
            sqlcommand.Parameters.AddWithValue("@Password", txtpassword.Text);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(sqlcommand);
            sda.SelectCommand = sqlcommand;
            sda.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                if (chkisadmin.Checked == true)
                {
                    Form4 f = new Form4();
                    f.Show();
                    this.Hide();
                } else
                {
                    MessageBox.Show("login successful !!!");
                    Form3 fr = new Form3();
                    fr.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("login unsuccessful !!");
            }
        }

        private void lklblregpage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            this.Hide();
        }
    }
}
