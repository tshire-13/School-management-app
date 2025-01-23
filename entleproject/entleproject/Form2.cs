using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace entleproject
{
    public partial class Form2 : Form
    {
        string connectionstring = @"Data Source=DESKTOP-TSHIRE\SQLEXPRESS02;Initial Catalog=schoolmagementdb;Integrated Security=True";
        public Form2()
        {
            InitializeComponent();
        }

        private void lklblloginpage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }
    

        private void btnregister_Click(object sender, EventArgs e)
        {
            //connecting to a sql server
            SqlConnection con = new SqlConnection(connectionstring);
            //we opne the connetion

            SqlCommand sqlcmd = new SqlCommand("INSERT INTO [dbo].[Loginttbl]([ID_NO],[NAMEandSURNAME],[USERNAME],[PASSWORD],[ISADMIN])VALUES(@ID_NO,@NAMEandSURNAME,@USERNAME,@PASSWORD,@ISADMIN)", con);
            //sqlcmd.ExecuteNonQuery();
            string isadmin;
            if (chkisadmin.Checked)
            {
                
                isadmin = "yes";
            }
            else
            {
                isadmin = "no";
            };

            //validates wherether the password textboxes are equal
            if (txtpassword.Text != txtconfirmpassword.Text)
            {
                txtpassword.BackColor = Color.Red;
                txtconfirmpassword.BackColor = Color.Red;
                MessageBox.Show("please make sure that the passwords are the same!!");
            }
            else
            //changes the color back to white 
            {
                txtpassword.BackColor = Color.White;
                txtpassword.BackColor = Color.White;
            };


            try
            {
                con.Open();

                sqlcmd.Parameters.AddWithValue("@ID_NO",txtid.Text);
                sqlcmd.Parameters.AddWithValue("@NAMEandSURNAME", txtnameandsurname.Text);
                sqlcmd.Parameters.AddWithValue("@USERNAME", txtusername.Text);
                sqlcmd.Parameters.AddWithValue("@PASSWORD", txtpassword.Text);
                sqlcmd.Parameters.AddWithValue("@ISADMIN", isadmin);

                sqlcmd.ExecuteNonQuery();

                MessageBox.Show("Data Saved!!");
                con.Close();

                Form1 f = new Form1();
                f.Show();
                this.Hide();

            }
            catch (Exception ex)
            {
                MessageBox.Show("error!!");
                MessageBox.Show($"{ex.Message}");
            }      
            
        }
    }
}
