using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design1
{
    public partial class Form1 : Form
    {
        SqlCommand commande;
        SqlConnection con;
        SqlDataReader dr;
        DataSet ds;
        DataTable dt;
        SqlDataAdapter dap;
        PictureBox [] picture= { new PictureBox(), new PictureBox() , new PictureBox() , new PictureBox() , new PictureBox() , new PictureBox() , new PictureBox() };
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //this.Dispose();
            Application.Exit();
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            pictureBox3.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'tESTDataSet.Filiere'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            //this.filiereTableAdapter.Fill(this.tESTDataSet.Filiere);
            picture[1].Image = button1.Image;
            picture[2].Image = button2.Image;
            picture[3].Image = button3.Image;
            picture[4].Image = button4.Image;
            picture[5].Image = button5.Image;
            picture[6].Image = button6.Image;
        }

        private void myInputDialog1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            accueilControl1.Visible = true;
            filiereControl1.Visible = false;
            userControlEtudiant1.Visible = false;
            statistiqueControl1.Visible = false;
            reportingControl1.Visible = false;
            apropos1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            accueilControl1.Visible = false;
            filiereControl1.Visible = true;
            userControlEtudiant1.Visible = false;
            statistiqueControl1.Visible = false;
            reportingControl1.Visible = false;
            apropos1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            accueilControl1.Visible = false;
            filiereControl1.Visible = false;
            userControlEtudiant1.Visible = true;
            statistiqueControl1.Visible = false;
            reportingControl1.Visible = false;
            apropos1.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            accueilControl1.Visible = false;
            filiereControl1.Visible = false;
            userControlEtudiant1.Visible = false;
            statistiqueControl1.Visible = true;
            reportingControl1.Visible = false;
            apropos1.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            accueilControl1.Visible = false;
            filiereControl1.Visible = false;
            userControlEtudiant1.Visible = false;
            statistiqueControl1.Visible = false;
            reportingControl1.Visible = true;
            apropos1.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            accueilControl1.Visible = false;
            filiereControl1.Visible = false;
            userControlEtudiant1.Visible = false;
            statistiqueControl1.Visible = false;
            reportingControl1.Visible = false;
            apropos1.Visible = true;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.Image = picture[1].Image;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.Image = picture[2].Image;
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.Image = picture[3].Image;
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.Image = picture[4].Image;
        }

        private void button6_MouseEnter(object sender, EventArgs e)
        {
            picture[6].Image = button6.Image;
            button6.Image = global::Design1.Properties.Resources.icons8_Report_Card_50px;
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            button6.Image = picture[6].Image;
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            picture[5].Image = button5.Image;
            button5.Image = global::Design1.Properties.Resources.icons8_Info_50px;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.Image = picture[5].Image;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            picture[1].Image = button1.Image;
            button1.Image = global::Design1.Properties.Resources.icons8_Home_50px;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            picture[2].Image = button2.Image;
            button2.Image = global::Design1.Properties.Resources.icons8_Tree_Structure_50px;
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            picture[3].Image = button3.Image;
            button3.Image = global::Design1.Properties.Resources.icons8_User_Groups_50px;
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            picture[4].Image = button4.Image;
            button4.Image = global::Design1.Properties.Resources.icons8_Futures_50px;
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {

        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            pictureBox3.Visible = true;
        }
    }
    
}
                                                                                                                                                                                                                                                                                                                                                                                                    