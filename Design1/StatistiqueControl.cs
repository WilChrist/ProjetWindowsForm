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
    public partial class StatistiqueControl : UserControl
    {

        SqlCommand cmd;
        SqlConnection con;
        SqlDataReader dr;

        public StatistiqueControl()
        {
            InitializeComponent();
        }

        private void StatistiqueControl_Load(object sender, EventArgs e)
        {
            String strConn = donnee.strConn;
            con = new SqlConnection();
            con.ConnectionString = strConn;
            con.Open();


            String req = "select Filiere.nom_filiere,count(cne) as valeur from [dbo].[Etudiant] join [dbo].[Filiere] on id_filiere=filiere GROUP BY Filiere.nom_filiere";
            SqlCommand cmd = new SqlCommand(req, con);
            dr = cmd.ExecuteReader();

            chart1.Series["Nombre d'étudiants"].Label = "#PERCENT{0.00 %}";
            while (dr.Read())
            {
                this.chart1.Series["Nombre d'étudiants"].Points.AddXY(dr["nom_filiere"].ToString(), dr["valeur"].ToString());
            }
            dr.Close();
        }
    }
}
