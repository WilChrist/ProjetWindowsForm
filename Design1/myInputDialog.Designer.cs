namespace Design1
{
    partial class myInputDialog
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.modifTextBox = new System.Windows.Forms.TextBox();
            this.valider = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.modifTextBox);
            this.groupBox1.Controls.Add(this.valider);
            this.groupBox1.ForeColor = System.Drawing.Color.Coral;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 178);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modifier la Filière Selectionnée";
            // 
            // modifTextBox
            // 
            this.modifTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.modifTextBox.Location = new System.Drawing.Point(28, 53);
            this.modifTextBox.Name = "modifTextBox";
            this.modifTextBox.Size = new System.Drawing.Size(298, 22);
            this.modifTextBox.TabIndex = 1;
            // 
            // valider
            // 
            this.valider.BackColor = System.Drawing.Color.DimGray;
            this.valider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.valider.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(241)))));
            this.valider.Location = new System.Drawing.Point(101, 117);
            this.valider.Name = "valider";
            this.valider.Size = new System.Drawing.Size(158, 37);
            this.valider.TabIndex = 0;
            this.valider.Text = "Valider";
            this.valider.UseVisualStyleBackColor = false;
            this.valider.Click += new System.EventHandler(this.valider_Click);
            // 
            // myInputDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.groupBox1);
            this.Name = "myInputDialog";
            this.Size = new System.Drawing.Size(365, 184);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox modifTextBox;
        private System.Windows.Forms.Button valider;
    }
}
