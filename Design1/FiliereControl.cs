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
    public partial class FiliereControl : UserControl
    {
        SqlCommand commande;
        SqlConnection con;
        SqlDataReader dr;
        DataSet ds;
        DataTable dt;
        SqlDataAdapter dap;
        public FiliereControl()
        {
            InitializeComponent();
        }

        private void FiliereControl_Load(object sender, EventArgs e)
        {
            String strConn = donnee.strConn;
            con = new SqlConnection();
            con.ConnectionString = strConn;
            con.Open();
            //InitialCatalog = TEST;

            commande = new SqlCommand();
            commande.Connection = con;
            ds = new DataSet();
            dt = new DataTable();
            dt.TableName = "Filiere";
            ds.Tables.Add(dt);
            
            remplissage();

            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void creer_Click(object sender, EventArgs e)
        {
            con.Open();
            commande.CommandText = "INSERT INTO [dbo].[Filiere]([Nom_filiere])VALUES('" + textBox1.Text + "')";
            commande.ExecuteNonQuery();

            con.Close();
            remplissage();
            dataGridView1.Update();
        }

        private void modifier_Click(object sender, EventArgs e)
        {
            for (int i = dataGridView1.SelectedRows.Count - 1, j = 0; i >= 0; i--, j++)
            {
                string input = "Entrez un Nouveau Nom";

                try
                {
                    input = dataGridView1.SelectedRows[i].Cells[1].Value.ToString();
                    ShowInputDialog(ref input);
                    int k = 0;
                    Int32.TryParse(dataGridView1.SelectedRows[i].Cells[0].Value.ToString(), out k);

                    DataRow[] tab = dt.Select("Id_filiere=" + k + "");
                    tab[0][1] = input;

                }
                catch (System.IndexOutOfRangeException iore)
                {
                    MessageBox.Show("Vueillez Selectionner des lignes valides", "Attention !!!");
                }
                catch (System.NullReferenceException nre)
                {
                    MessageBox.Show("Vueillez Selectionner des lignes valides", "Attention !!!");
                }
                miseAjour();
            }
        }

        private void supprimer_Click(object sender, EventArgs e)
        {
            for (int i = dataGridView1.SelectedRows.Count - 1, j = 0; i >= 0; i--, j++)
            {
                try
                {
                    dt.Rows[dataGridView1.SelectedRows[i].Index + j].Delete();
                }
                catch (System.IndexOutOfRangeException iore)
                {
                    MessageBox.Show("Vueillez Selectionner des lignes valides", "Attention !!!");
                }
            }
            miseAjour();
        }
        public void miseAjour()
        {
            SqlCommandBuilder cmdBuilder = new SqlCommandBuilder();
            cmdBuilder.DataAdapter = dap;
            try
            {
                dap.Update(dt);
            }catch(System.Data.DBConcurrencyException dbce)
            {
                MessageBox.Show("Cette Ligne a déjà été supprimé par un autre Utilisateur", "Attention !!!");
            }


            dataGridView1.Update();
        }
        public void remplissage()
        {
            dap = new SqlDataAdapter();
            commande.CommandText = "SELECT * FROM Filiere";
            dap.SelectCommand = commande;
            dt.Clear();
            dap.Fill(dt);
        }
        private static DialogResult ShowInputDialog(ref string input)
        {
            System.Drawing.Size size = new System.Drawing.Size(350, 70);
            Form inputBox = new Form();
            inputBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            inputBox.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            inputBox.ClientSize = size;
            inputBox.Font = new Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            inputBox.ForeColor = System.Drawing.Color.White;
            inputBox.AutoScaleDimensions = new System.Drawing.SizeF(22F, 23F);
            inputBox.Margin = new System.Windows.Forms.Padding(4);
            inputBox.StartPosition = FormStartPosition.CenterParent;
            //inputBox.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            //inputBox.Location = new Point(100, 800);

            //inputBox.Text = "Entrez une nouvelle valeur";

            System.Windows.Forms.TextBox textBox = new TextBox();
            textBox.Size = new System.Drawing.Size(size.Width - 100, 23);
            textBox.Location = new System.Drawing.Point((size.Width - 210), 5);
            textBox.Text = input;
            inputBox.Controls.Add(textBox);

            System.Windows.Forms.Label label = new Label();
            label.Size = new System.Drawing.Size(200, 23);
            label.Location = new System.Drawing.Point(5, 5);
            label.Text = "Nouveau Nom : ";
            inputBox.Controls.Add(label);

            Button okButton = new Button();
            okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            okButton.Name = "okButton";
            okButton.Size = new System.Drawing.Size(75, 27);
            okButton.Text = "&VALIDER";
            okButton.Location = new System.Drawing.Point(size.Width - 80 - 80, 39);
            inputBox.Controls.Add(okButton);


            inputBox.AcceptButton = okButton;

            DialogResult result = inputBox.ShowDialog();
            inputBox.SetBounds(800, 800, 300, 70);
            input = textBox.Text;
            return result;
        }
    }
}
