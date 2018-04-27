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
    public partial class UserControlEtudiant : UserControl
    {
        SqlCommand commande;
        SqlCommand cmd;
        SqlCommand cmd2;
        SqlConnection con;
        SqlDataReader dr;
        DataSet ds;
        DataTable dt;
        SqlDataAdapter dap;
        SqlDataReader lis;
        SqlDataReader liss;

        public UserControlEtudiant()
        {
            InitializeComponent();
           // String strConn = " Data Source=OMAIMA\\SQLEXPRESS; Initial Catalog=projet; User Id=OMAIMA\\userrrr; Password= ; Integrated Security =true";

            
        }
        private void UserControlEtudiant_Load(object sender, EventArgs e)
        {
            String strConn = donnee.strConn;
            con = new SqlConnection();
            con.ConnectionString = strConn;
            con.Open();


            String req = "select nom from Etudiant";
            SqlCommand cmd = new SqlCommand(req, con);
            SqlDataReader liste = cmd.ExecuteReader();
            while (liste.Read())
            {
                comboBox1.Items.Add(liste[0]);
            }
            liste.Close();


            String req2 = "select nom_filiere from Filiere";
            SqlCommand commande = new SqlCommand(req2, con);
            SqlDataReader liste1 = commande.ExecuteReader();
            while (liste1.Read())
            {
                comboBox2.Items.Add(liste1[0]);
            }
            liste1.Close();

            

            con.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            String req3 = "select cne,prenom,sexe,date_naissance,adresse,telephone,nom_filiere from Etudiant,Filiere where nom=@Nom and filiere=id_filiere ";

            String Nom = comboBox1.SelectedItem.ToString();
            SqlParameter par = new SqlParameter("@Nom", Nom);
            cmd2 = new SqlCommand(req3, con);
            cmd2.Parameters.Add(par);
            lis = cmd2.ExecuteReader();
            while (lis.Read())
            {
                textBox1.Text = lis.GetInt32(0).ToString();
                textBox3.Text = Nom;
                textBox2.Text = lis.GetString(1);

                if (lis.GetString(2).Trim().Equals("F"))
                {
                    radioButton1.Checked = true;
                    radioButton2.Checked = false;
                }
                if (lis.GetString(2).Trim().Equals("M"))
                {
                    radioButton2.Checked = true;
                    radioButton1.Checked = false;
                }
                //MessageBox.Show((lis.GetString(2).Trim().Equals("M")).ToString(),lis.GetString(2).Trim().Length.ToString());
                textBox4.Text = lis.GetString(4);
                textBox5.Text = lis.GetString(5);
                textBox6.Text = lis.GetDateTime(3).ToLongDateString();
                comboBox2.Text = lis.GetString(6);

            }

            con.Close();
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                    con.Open();
                        String requete = "select id_filiere from Filiere where nom_filiere=@Nom ";
                        String Nom = comboBox2.SelectedItem.ToString();
                        SqlParameter par = new SqlParameter("@Nom", Nom);
                        cmd = new SqlCommand(requete, con);
                        cmd.Parameters.Add(par);
                        lis = cmd.ExecuteReader();
                        lis.Read();
                        int i = lis.GetInt32(0);
                        lis.Close();
                        string sexe;
                        if (radioButton1.Checked)
                        {
                            sexe = "F";

                        }
                        else
                        {
                            sexe = "M";
                        }


                        String req = "INSERT INTO Etudiant([nom],[prenom],[sexe],[date_naissance],[adresse],[telephone],[filiere])VALUES('" + textBox3.Text + "','" + textBox2.Text + "','" + sexe + "','" + textBox6.Text + "','" + textBox4.Text + "','" + textBox5.Text + "'," + i + ")";
                        commande = new SqlCommand(req, con);
                        commande.CommandText = req;
                        commande.ExecuteNonQuery();

                        

                        MessageBox.Show("l'étudiant est ajouté avec succes");
            }catch(System.NullReferenceException nre)
            {
                MessageBox.Show("Veuillez Remplir correctemment chaque Champ","Attention");
            }
            finally
            {
                con.Close();
            }


        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            con.Open();
            String requet = "select id_filiere from Filiere where nom_filiere=@Nom ";
            String Nom = comboBox2.SelectedItem.ToString();
            SqlParameter par = new SqlParameter("@Nom", Nom);
            cmd = new SqlCommand(requet, con);
            cmd.Parameters.Add(par);
            lis = cmd.ExecuteReader();
            lis.Read();
            int i = lis.GetInt32(0);
            lis.Close();
            string sexe;
            if (radioButton1.Checked)
            {
                sexe = "F";

            }
            else
            {
                sexe = "M";
            }

            String nom = comboBox1.SelectedText;
            String[] parts = textBox6.Text.Split(' ');
            String jour = parts[1];
            String mois = MonthToInt(parts[2]).ToString();
            String annee = parts[3];
            String newDate = annee + "/" + mois + "/" + jour;
            String requete = "UPDATE Etudiant SET nom= '" + textBox3.Text + "', prenom= '" + textBox2.Text + "',sexe= '" + sexe + "', date_naissance= '" + newDate + "', adresse= '" + textBox4.Text + "', telephone='" + textBox4.Text + "',filiere= '" + i + "' WHERE cne=" + Convert.ToInt32(textBox1.Text);

            commande = new SqlCommand(requete, con);
            commande.CommandText = requete;
            commande.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("L'étudiant a été modifié avec succès");
        }

        private int MonthToInt(String month)
        {
            switch (month)
            {
                case "janvier":
                    return 1;
                    break;
                case "février":
                    return 2;
                    break;
                case "mars":
                    return 3;
                    break;
                case "avril":
                    return 4;
                    break;
                case "mai":
                    return 5;
                    break;
                case "juin":
                    return 6;
                    break;
                case "juillet":
                    return 7;
                    break;
                case "août":
                    return 8;
                    break;
                case "septembre":
                    return 9;
                    break;
                case "octobre":
                    return 10;
                    break;
                case "novembre":
                    return 11;
                    break;
                case "décembre":
                    return 12;
                    break;
                default:
                    return 1;
                    break;
            } // end switch

        } // end method

        private void button9_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sure you wanna delete?", "Warning", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                SqlCommand delcmd = new SqlCommand();
                con.Open();
                textBox1.Text = con.State.ToString();
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    try
                    {

                        DataGridViewRow delrow = dataGridView1.Rows[i];
                        if (delrow.Selected == true)
                        {
                            string cne = delrow.Cells[0].Value.ToString();
                            textBox1.Text = cne;
                            dataGridView1.Rows.RemoveAt(i);
                            delcmd.CommandText = "delete from Etudiant where cne ='" + cne + "'";
                            delcmd.Connection = con;
                            delcmd.ExecuteNonQuery();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    finally { }
                }
                con.Close();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Sort(dataGridView1.Columns["nom"], ListSortDirection.Ascending);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void comboBox1_MouseClick(object sender, MouseEventArgs e)
        {
            String strConn = donnee.strConn;
            con = new SqlConnection();
            con.ConnectionString = strConn;
            con.Open();
            String req2 = "select nom from Etudiant";
            SqlCommand commande = new SqlCommand(req2, con);
            SqlDataReader liste1 = commande.ExecuteReader();
            comboBox1.Items.Clear();
            //MessageBox.Show("Hello");
            while (liste1.Read())
            {
                comboBox1.Items.Add(liste1[0]);
            }
            liste1.Close();
            con.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Etudiant", con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                dataGridView1.Rows.Add(reader["cne"], reader["nom"], reader["prenom"], reader["sexe"], reader["date_naissance"], reader["adresse"], reader["telephone"], reader["filiere"]);
            }
            con.Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Sort(dataGridView1.Columns["nom"], ListSortDirection.Descending);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            userControl11.Visible = true;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
