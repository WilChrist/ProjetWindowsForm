using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;

using Excel = Microsoft.Office.Interop.Excel;

namespace Design1
{
    public partial class UserControl1 : UserControl
    {
        
        public UserControl1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            textBox1.Text = openFileDialog1.FileName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            /*
                OleDbConnection conn = new OleDbConnection();
                conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + textBox1.Text + @";Extended Properties=""Excel 8.0 Xml;HDR=YES;Import MixedTypes=Text;TypeGuessRows=0""";
                */ 
                
                
                
               /* OleDbCommand commandexcel = new OleDbCommand("SELECT *"+
                                                             "FROM [SHEET1$]", conn);
                DataSet ds = new DataSet();
                OleDbDataAdapter adapexcel = new OleDbDataAdapter(commandexcel);
                //adapexcel.SelectCommand = commandexcel;
                //adapexcel.Fill(ds, "etudiant");
                adapexcel.Fill(ds);
                //dataGridView1.DataSource = ds.Tables["Etudiant"];
                dataGridView1.DataSource = ds.Tables[0];
                //SqlBulkCopy copy = new SqlBulkCopy(consql);
                //consql.Open();
                //copy.DestinationTableName = "Etudiant";
                //copy.WriteToServer(ds.Tables["Etudiant"]);
            
            */
            SqlConnection consql = new SqlConnection();
            consql.ConnectionString = donnee.strConn;
            consql.Open();

            String filePath = textBox1.Text;
            //Create COM Objects. Create a COM object for everything that is referenced
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(filePath);
            Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Excel.Range xlRange = xlWorksheet.UsedRange;
            SqlCommand command = new SqlCommand(); 

            //iterate over the rows and columns and print to the console as it appears in the file
            //excel is not zero based!!
            for (int i = 2; xlRange.Cells[i, 1].Value2 != null; i++)
            {
                string sql = "INSERT INTO Etudiant (nom, prenom, sexe, date_naissance, adresse, telephone, filiere) VALUES ('" +
                    xlRange.Cells[i, 1].Value2.ToString() + "', " +
                    "'" + xlRange.Cells[i, 2].Value2.ToString() + "', " +
                    "'" + xlRange.Cells[i, 3].Value2.ToString() + "', " +
                    "'" + xlRange.Cells[i, 4].Value2.ToString() + "/" + xlRange.Cells[i, 5].Value2.ToString() + "/" + xlRange.Cells[i, 6].Value2.ToString() + "', " +
                    "'" + xlRange.Cells[i, 7].Value2.ToString() + "', " +
                    "'" + xlRange.Cells[i, 8].Value2.ToString() + "', " +
                    "" + xlRange.Cells[i, 9].Value2.ToString() + ")";
                command.CommandText = sql;
                command.Connection = consql;
                command.ExecuteNonQuery(); 

                
            }
            consql.Close();   
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                    }

        private void fermer_Click(object sender, EventArgs e)
        {
            this.Visible=false;
        }
    }
}
