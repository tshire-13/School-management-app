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
    public partial class Form4 : Form
    {
        string connectionstring = @"Data Source=DESKTOP-TSHIRE\SQLEXPRESS02;Initial Catalog=schoolmagementdb;Integrated Security=True";
        public Form4()
        {
            InitializeComponent();
        }

        private void btndisplay_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconn = new SqlConnection(connectionstring);
            sqlconn.Open();
            SqlCommand sqlcmd = new SqlCommand("select * from Loginttbl", sqlconn);
            SqlDataAdapter sda = new SqlDataAdapter(sqlcmd);
            DataTable dt = new DataTable();
            sda.SelectCommand = sqlcmd;
            sda.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void btnseacrh_Click(object sender, EventArgs e)
        {
            string filterCriteria = txtsearch.Text;
            string searcchPattern = "%" + filterCriteria + "%";
            SqlConnection sqlcon = new SqlConnection(connectionstring);
            SqlCommand sqlcmd = new SqlCommand("SELECT * FROM Loginttbl WHERE NAMEandSURNAME LIKE @filterCriteria", sqlcon);
            sqlcmd.Parameters.AddWithValue("@filterCriteria", searcchPattern);
            SqlDataAdapter sda = new SqlDataAdapter(sqlcmd);
            DataTable dt = new DataTable();
            sda.SelectCommand = sqlcmd;
            sqlcon.Open();
            sda.Fill(dt);
            sqlcon.Close();
            dataGridView1.DataSource = dt;
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            //connecting to a sql server
            SqlConnection con = new SqlConnection(connectionstring);
            //we opne the connetion

            SqlCommand sqlcmd = new SqlCommand("UPDATE [dbo].[Loginttbl] SET (NAMEandSURNAME = @ NAMEANDSURNAME WHERE id_no = @id_no)", con);
            //sqlcmd.ExecuteNonQuery();

            try
            {
                con.Open();

                sqlcmd.Parameters.AddWithValue("@NameandSurname", txtnameandsurname.Text);
                sqlcmd.Parameters.AddWithValue("@id_no", txtidno.Text);

                sqlcmd.ExecuteNonQuery();

                MessageBox.Show("Data updated!!");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error!!");
                MessageBox.Show($"{ex.Message}");
            }
        }
    }
}
