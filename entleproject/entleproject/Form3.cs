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
using System.Drawing.Printing;

namespace entleproject
{
    public partial class Form3 : Form
    {
        string connectionstring = @"Data Source=DESKTOP-TSHIRE\SQLEXPRESS02;Initial Catalog=schoolmagementdb;Integrated Security=True";

        private PrintDocument printDocument = new PrintDocument();
        private int rowIndex = 0;
        public Form3()
        {
            InitializeComponent();
            printDocument.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
        }

        private void btnaddstudent_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(connectionstring);


            SqlCommand sqlcmd = new SqlCommand("INSERT INTO [dbo].[tblstudent]([id_no],[NameandSurname],[exam1],[exam2])VALUES(@id_no,@NameandSurname,@exam1,@exam2)", con);

            
            try
            {
                con.Open();

                sqlcmd.Parameters.AddWithValue("@id_no", txtidno.Text);
                sqlcmd.Parameters.AddWithValue("@NameandSurname", txtnameandsurname.Text);
                sqlcmd.Parameters.AddWithValue("@exam1", txtexam1.Text);
                sqlcmd.Parameters.AddWithValue("@exam2", txtexam2.Text);

                sqlcmd.ExecuteNonQuery();

                MessageBox.Show("Data Saved!!");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error!!");
                MessageBox.Show($"{ex.Message}");
            }


        }

        private void btndisplay_Click(object sender, EventArgs e)
        {

            SqlConnection sqlconn = new SqlConnection(connectionstring);
            sqlconn.Open();
            SqlCommand sqlcmd = new SqlCommand("select * from tblstudent",sqlconn);
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
         SqlCommand sqlcmd = new SqlCommand("SELECT * FROM tblstudent WHERE NameandSurname LIKE @filterCriteria", sqlcon);
         sqlcmd.Parameters.AddWithValue("@filterCriteria", searcchPattern);
         SqlDataAdapter sda = new SqlDataAdapter(sqlcmd);
         DataTable dt = new DataTable();
         sda.SelectCommand = sqlcmd;
            sqlcon.Open();
         sda.Fill(dt);
            sqlcon.Close();
         dataGridView1.DataSource = dt;
        }

        private void btnprint_Click(object sender, EventArgs e)
        {

            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                rowIndex = 0; 
                printDocument.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
           
            Font font = new Font("Arial", 10);
            float lineHeight = font.GetHeight(e.Graphics) + 2;
            float x = e.MarginBounds.Left;
            float y = e.MarginBounds.Top;

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                e.Graphics.DrawString(column.HeaderText, font, Brushes.Black, x, y);
                x += column.Width; 
            }

            y += lineHeight; 
            x = e.MarginBounds.Left; 

            while (rowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow row = dataGridView1.Rows[rowIndex];
                foreach (DataGridViewCell cell in row.Cells)
                {
                    e.Graphics.DrawString(cell.Value?.ToString(), font, Brushes.Black, x, y);
                    x += cell.OwningColumn.Width; 
                }

                y += lineHeight; 
                x = e.MarginBounds.Left; 

                if (y + lineHeight > e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true;
                    rowIndex++; 
                    return; 
                }

                rowIndex++; 
            }

            e.HasMorePages = false;
            rowIndex = 0; 

        }
    }
}
