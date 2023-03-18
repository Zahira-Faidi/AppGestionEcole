namespace AppGestionEcole
{
    partial class paimentEtu
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Modifier = new System.Windows.Forms.Button();
            this.Supprimer = new System.Windows.Forms.Button();
            this.chercher = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Ajouter = new System.Windows.Forms.Button();
            this.typePaiement = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nomEtu = new System.Windows.Forms.ComboBox();
            this.moisPaiement = new System.Windows.Forms.ComboBox();
            this.montantPayer = new System.Windows.Forms.TextBox();
            this.datepaiement = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label10);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1273, 77);
            this.panel2.TabIndex = 87;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(22, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(163, 22);
            this.label10.TabIndex = 28;
            this.label10.Text = "> Paiement Etudiant";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 22);
            this.label6.TabIndex = 85;
            this.label6.Text = "Montant";
            // 
            // Modifier
            // 
            this.Modifier.BackColor = System.Drawing.Color.SteelBlue;
            this.Modifier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Modifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Modifier.Font = new System.Drawing.Font("Open Sans SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modifier.ForeColor = System.Drawing.Color.White;
            this.Modifier.Location = new System.Drawing.Point(1088, 663);
            this.Modifier.Name = "Modifier";
            this.Modifier.Size = new System.Drawing.Size(147, 41);
            this.Modifier.TabIndex = 84;
            this.Modifier.Text = "Modifier";
            this.Modifier.UseVisualStyleBackColor = false;
            this.Modifier.Click += new System.EventHandler(this.Modifier_Click);
            // 
            // Supprimer
            // 
            this.Supprimer.BackColor = System.Drawing.Color.Firebrick;
            this.Supprimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Supprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Supprimer.Font = new System.Drawing.Font("Open Sans SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Supprimer.ForeColor = System.Drawing.Color.White;
            this.Supprimer.Location = new System.Drawing.Point(935, 663);
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.Size = new System.Drawing.Size(147, 41);
            this.Supprimer.TabIndex = 83;
            this.Supprimer.Text = "Supprimer";
            this.Supprimer.UseVisualStyleBackColor = false;
            this.Supprimer.Click += new System.EventHandler(this.Supprimer_Click);
            // 
            // chercher
            // 
            this.chercher.Font = new System.Drawing.Font("Open Sans SemiBold", 14.25F, System.Drawing.FontStyle.Bold);
            this.chercher.Location = new System.Drawing.Point(910, 83);
            this.chercher.Name = "chercher";
            this.chercher.Size = new System.Drawing.Size(291, 33);
            this.chercher.TabIndex = 81;
            this.chercher.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chercher.TextChanged += new System.EventHandler(this.chercher_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.Location = new System.Drawing.Point(288, 122);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(947, 535);
            this.dataGridView1.TabIndex = 80;
            // 
            // Ajouter
            // 
            this.Ajouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(141)))), ((int)(((byte)(54)))));
            this.Ajouter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Ajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ajouter.Font = new System.Drawing.Font("Open Sans SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ajouter.ForeColor = System.Drawing.Color.White;
            this.Ajouter.Location = new System.Drawing.Point(98, 415);
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Size = new System.Drawing.Size(147, 41);
            this.Ajouter.TabIndex = 79;
            this.Ajouter.Text = "Ajouter";
            this.Ajouter.UseVisualStyleBackColor = false;
            this.Ajouter.Click += new System.EventHandler(this.Ajouter_Click);
            // 
            // typePaiement
            // 
            this.typePaiement.Font = new System.Drawing.Font("Open Sans", 12F);
            this.typePaiement.FormattingEnabled = true;
            this.typePaiement.Items.AddRange(new object[] {
            "Espèces",
            "Chèques",
            "Virement bancaire",
            "Carte bancaire"});
            this.typePaiement.Location = new System.Drawing.Point(32, 361);
            this.typePaiement.Name = "typePaiement";
            this.typePaiement.Size = new System.Drawing.Size(213, 30);
            this.typePaiement.TabIndex = 78;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 22);
            this.label5.TabIndex = 77;
            this.label5.Text = "Type Paiement";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 22);
            this.label3.TabIndex = 76;
            this.label3.Text = "Mois";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 22);
            this.label2.TabIndex = 74;
            this.label2.Text = "Nom Etudiant";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Location = new System.Drawing.Point(272, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 741);
            this.panel1.TabIndex = 72;
            // 
            // nomEtu
            // 
            this.nomEtu.Font = new System.Drawing.Font("Open Sans", 12F);
            this.nomEtu.FormattingEnabled = true;
            this.nomEtu.Location = new System.Drawing.Point(32, 135);
            this.nomEtu.Name = "nomEtu";
            this.nomEtu.Size = new System.Drawing.Size(213, 30);
            this.nomEtu.TabIndex = 88;
            // 
            // moisPaiement
            // 
            this.moisPaiement.Font = new System.Drawing.Font("Open Sans", 12F);
            this.moisPaiement.FormattingEnabled = true;
            this.moisPaiement.Items.AddRange(new object[] {
            "Janvier",
            "Février",
            "Mars",
            "Avril",
            "Mai",
            "Juin",
            "Juillet",
            "Août",
            "Septembre",
            "Octobre",
            "Novembre",
            "Décembre"});
            this.moisPaiement.Location = new System.Drawing.Point(33, 246);
            this.moisPaiement.Name = "moisPaiement";
            this.moisPaiement.Size = new System.Drawing.Size(213, 30);
            this.moisPaiement.TabIndex = 89;
            // 
            // montantPayer
            // 
            this.montantPayer.Font = new System.Drawing.Font("Open Sans", 12F);
            this.montantPayer.Location = new System.Drawing.Point(33, 304);
            this.montantPayer.Name = "montantPayer";
            this.montantPayer.Size = new System.Drawing.Size(212, 29);
            this.montantPayer.TabIndex = 90;
            // 
            // datepaiement
            // 
            this.datepaiement.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datepaiement.Location = new System.Drawing.Point(33, 193);
            this.datepaiement.Name = "datepaiement";
            this.datepaiement.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.datepaiement.Size = new System.Drawing.Size(213, 25);
            this.datepaiement.TabIndex = 92;
            this.datepaiement.Value = new System.DateTime(2022, 12, 6, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 22);
            this.label1.TabIndex = 91;
            this.label1.Text = "Date Paiement";
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.CadetBlue;
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Open Sans SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(288, 663);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(147, 41);
            this.btnPrint.TabIndex = 93;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Image = global::AppGestionEcole.Properties.Resources.icons8_search_32;
            this.pictureBox3.Location = new System.Drawing.Point(1195, 83);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 33);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 82;
            this.pictureBox3.TabStop = false;
            // 
            // paimentEtu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.datepaiement);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.montantPayer);
            this.Controls.Add(this.moisPaiement);
            this.Controls.Add(this.nomEtu);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Modifier);
            this.Controls.Add(this.Supprimer);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.chercher);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Ajouter);
            this.Controls.Add(this.typePaiement);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "paimentEtu";
            this.Size = new System.Drawing.Size(1273, 740);
            this.Load += new System.EventHandler(this.paimentEtu_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Modifier;
        private System.Windows.Forms.Button Supprimer;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox chercher;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Ajouter;
        private System.Windows.Forms.ComboBox typePaiement;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox nomEtu;
        private System.Windows.Forms.ComboBox moisPaiement;
        private System.Windows.Forms.TextBox montantPayer;
        private System.Windows.Forms.DateTimePicker datepaiement;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrint;
    }
}
