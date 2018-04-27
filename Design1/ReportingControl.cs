using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Design1
{
    public partial class ReportingControl : UserControl
    {
        SqlDataAdapter dap;
        SqlCommand commande;
        SqlConnection con;
        SqlDataReader dr;
        DataSet1 dataSet;
        DataTable dt;
        CrystalReport1 crystalReport;
        String strConn = donnee.strConn;
        public ReportingControl()
        {
            InitializeComponent();
        }

        private void ReportingControl_Load(object sender, EventArgs e)
        {
            
           
            con = new SqlConnection();
            con.ConnectionString = strConn;

            commande = new SqlCommand();
            commande.Connection = con;

            crystalReport = new CrystalReport1();
            dataSet = new DataSet1();
            /*dt = new DataTable();

            dt.TableName = "Etudiants";
            dataSet.Tables.Add(dt);
            remplissage("Etudiant");
            crystalReport.SetDataSource(dataSet.Tables["Etudiants"]);*/

            
        }
        public void remplissage(String c)
        {
            dap = new SqlDataAdapter();
            commande.CommandText = "SELECT * FROM "+c;
            dap.SelectCommand = commande;
            if (c.Equals("Filiere"))
            {
                dap.Fill(dataSet.Filiere);
            }
            else
            {
                dap.Fill(dataSet.Etudiant);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String cne = comboBox1.SelectedItem.ToString();
           // MessageBox.Show(cne.ToString());
            dataSet.Filiere.Clear();
            dataSet.Etudiant.Clear();
            dap = new SqlDataAdapter();
            commande.CommandText = "SELECT * FROM Etudiant join Filiere on Etudiant.filiere=Filiere.id_filiere where cne="+cne;
            dap.SelectCommand = commande;
            dap.Fill(dataSet.Filiere);
            dap.Fill(dataSet.Etudiant);

            crystalReport.SetDataSource(dataSet);
            crystalReportViewer1.ReportSource = crystalReport;
            crystalReportViewer1.Refresh();

            crystalReportViewer1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataSet.Filiere.Clear();
            dataSet.Etudiant.Clear();
            remplissage("Etudiant");
            remplissage("Filiere");
            crystalReport.SetDataSource(dataSet);
            crystalReportViewer1.ReportSource = crystalReport;
            crystalReportViewer1.Refresh();

            crystalReportViewer1.Visible = true;
        }

        private void comboBox1_MouseClick(object sender, MouseEventArgs e)
        {
            //String strConn = "Data Source=192.168.1.248,49172; Initial Catalog = projet; User Id = User1; Password = '123456789';Integrated Security = false";
            con = new SqlConnection();
            con.ConnectionString = strConn;
            con.Open();

            comboBox1.Items.Clear();
            String req = "select cne from Etudiant";
            SqlCommand cmd = new SqlCommand(req, con);
            SqlDataReader liste = cmd.ExecuteReader();
            while (liste.Read())
            {
                comboBox1.Items.Add(liste[0]);
            }
            liste.Close();
        }
    }
}
