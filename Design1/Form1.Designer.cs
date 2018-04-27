namespace Design1
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.filiereBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tESTDataSet = new Design1.TESTDataSet();
            this.filiereTableAdapter = new Design1.TESTDataSetTableAdapters.FiliereTableAdapter();
            this.tableAdapterManager = new Design1.TESTDataSetTableAdapters.TableAdapterManager();
            this.apropos1 = new Design1.Apropos();
            this.reportingControl1 = new Design1.ReportingControl();
            this.statistiqueControl1 = new Design1.StatistiqueControl();
            this.userControlEtudiant1 = new Design1.UserControlEtudiant();
            this.accueilControl1 = new Design1.AccueilControl();
            this.filiereControl1 = new Design1.FiliereControl();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filiereBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tESTDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 754);
            this.panel1.TabIndex = 0;
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold);
            this.button6.Image = global::Design1.Properties.Resources.icons8_Report_Card_64px;
            this.button6.Location = new System.Drawing.Point(-3, 535);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(248, 108);
            this.button6.TabIndex = 1;
            this.button6.Text = "Reporting";
            this.button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            this.button6.MouseEnter += new System.EventHandler(this.button6_MouseEnter);
            this.button6.MouseLeave += new System.EventHandler(this.button6_MouseLeave);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Image = global::Design1.Properties.Resources.icons8_Info_64px;
            this.button5.Location = new System.Drawing.Point(0, 645);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(248, 108);
            this.button5.TabIndex = 1;
            this.button5.Text = "A Propos";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            this.button5.MouseEnter += new System.EventHandler(this.button5_MouseEnter);
            this.button5.MouseLeave += new System.EventHandler(this.button5_MouseLeave);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold);
            this.button4.Image = global::Design1.Properties.Resources.icons8_Futures_64px;
            this.button4.Location = new System.Drawing.Point(-3, 425);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(248, 108);
            this.button4.TabIndex = 1;
            this.button4.Text = "Statistiques";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            this.button4.MouseEnter += new System.EventHandler(this.button4_MouseEnter);
            this.button4.MouseLeave += new System.EventHandler(this.button4_MouseLeave);
            this.button4.MouseHover += new System.EventHandler(this.button4_MouseHover);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold);
            this.button3.Image = global::Design1.Properties.Resources.icons8_User_Groups_64px;
            this.button3.Location = new System.Drawing.Point(0, 315);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(248, 108);
            this.button3.TabIndex = 1;
            this.button3.Text = "Etudiants";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            this.button3.MouseEnter += new System.EventHandler(this.button3_MouseEnter);
            this.button3.MouseLeave += new System.EventHandler(this.button3_MouseLeave);
            this.button3.MouseHover += new System.EventHandler(this.button3_MouseHover);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::Design1.Properties.Resources.icons8_Tree_Structure_64px;
            this.button2.Location = new System.Drawing.Point(0, 205);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(248, 108);
            this.button2.TabIndex = 1;
            this.button2.Text = "Filières";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseEnter += new System.EventHandler(this.button2_MouseEnter);
            this.button2.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            this.button2.MouseHover += new System.EventHandler(this.button2_MouseHover);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::Design1.Properties.Resources.icons8_Home_64px_5;
            this.button1.Location = new System.Drawing.Point(0, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(248, 108);
            this.button1.TabIndex = 1;
            this.button1.Text = "Accueil";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button1.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Indigo;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(248, 89);
            this.panel3.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(52, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(248, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(888, 46);
            this.panel4.TabIndex = 2;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::Design1.Properties.Resources.icons8_Shutdown_64px_1;
            this.pictureBox3.Location = new System.Drawing.Point(851, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(37, 39);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            this.pictureBox3.MouseEnter += new System.EventHandler(this.pictureBox3_MouseEnter);
            this.pictureBox3.MouseLeave += new System.EventHandler(this.pictureBox3_MouseLeave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::Design1.Properties.Resources.icons8_Shutdown_64px;
            this.pictureBox2.Location = new System.Drawing.Point(851, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 39);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.MouseEnter += new System.EventHandler(this.pictureBox2_MouseEnter);
            this.pictureBox2.MouseHover += new System.EventHandler(this.pictureBox2_MouseHover);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.apropos1);
            this.panel2.Controls.Add(this.reportingControl1);
            this.panel2.Controls.Add(this.statistiqueControl1);
            this.panel2.Controls.Add(this.userControlEtudiant1);
            this.panel2.Controls.Add(this.accueilControl1);
            this.panel2.Controls.Add(this.filiereControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(248, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(888, 708);
            this.panel2.TabIndex = 3;
            // 
            // filiereBindingSource
            // 
            this.filiereBindingSource.DataMember = "Filiere";
            this.filiereBindingSource.DataSource = this.tESTDataSet;
            // 
            // tESTDataSet
            // 
            this.tESTDataSet.DataSetName = "TESTDataSet";
            this.tESTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // filiereTableAdapter
            // 
            this.filiereTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FiliereTableAdapter = this.filiereTableAdapter;
            this.tableAdapterManager.UpdateOrder = Design1.TESTDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // apropos1
            // 
            this.apropos1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.apropos1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.apropos1.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apropos1.Location = new System.Drawing.Point(0, 0);
            this.apropos1.Margin = new System.Windows.Forms.Padding(5);
            this.apropos1.Name = "apropos1";
            this.apropos1.Size = new System.Drawing.Size(888, 708);
            this.apropos1.TabIndex = 5;
            this.apropos1.Visible = false;
            // 
            // reportingControl1
            // 
            this.reportingControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.reportingControl1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportingControl1.Location = new System.Drawing.Point(0, 39);
            this.reportingControl1.Margin = new System.Windows.Forms.Padding(4);
            this.reportingControl1.Name = "reportingControl1";
            this.reportingControl1.Size = new System.Drawing.Size(884, 669);
            this.reportingControl1.TabIndex = 4;
            this.reportingControl1.Visible = false;
            // 
            // statistiqueControl1
            // 
            this.statistiqueControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.statistiqueControl1.Location = new System.Drawing.Point(0, 39);
            this.statistiqueControl1.Margin = new System.Windows.Forms.Padding(4);
            this.statistiqueControl1.Name = "statistiqueControl1";
            this.statistiqueControl1.Size = new System.Drawing.Size(875, 644);
            this.statistiqueControl1.TabIndex = 3;
            this.statistiqueControl1.Visible = false;
            // 
            // userControlEtudiant1
            // 
            this.userControlEtudiant1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.userControlEtudiant1.Location = new System.Drawing.Point(0, 39);
            this.userControlEtudiant1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.userControlEtudiant1.Name = "userControlEtudiant1";
            this.userControlEtudiant1.Size = new System.Drawing.Size(888, 669);
            this.userControlEtudiant1.TabIndex = 2;
            this.userControlEtudiant1.Visible = false;
            // 
            // accueilControl1
            // 
            this.accueilControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.accueilControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accueilControl1.Location = new System.Drawing.Point(0, 0);
            this.accueilControl1.Margin = new System.Windows.Forms.Padding(4);
            this.accueilControl1.Name = "accueilControl1";
            this.accueilControl1.Size = new System.Drawing.Size(888, 708);
            this.accueilControl1.TabIndex = 1;
            // 
            // filiereControl1
            // 
            this.filiereControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filiereControl1.Location = new System.Drawing.Point(0, 0);
            this.filiereControl1.Margin = new System.Windows.Forms.Padding(4);
            this.filiereControl1.Name = "filiereControl1";
            this.filiereControl1.Size = new System.Drawing.Size(888, 708);
            this.filiereControl1.TabIndex = 0;
            this.filiereControl1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(1136, 754);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = global::Design1.Properties.Resources.icons8_Classroom_3;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.filiereBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tESTDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private TESTDataSet tESTDataSet;
        private System.Windows.Forms.BindingSource filiereBindingSource;
        private TESTDataSetTableAdapters.FiliereTableAdapter filiereTableAdapter;
        private TESTDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Panel panel2;
        private FiliereControl filiereControl1;
        private AccueilControl accueilControl1;
        private UserControlEtudiant userControlEtudiant1;
        private StatistiqueControl statistiqueControl1;
        private ReportingControl reportingControl1;
        private Apropos apropos1;
    }
}

