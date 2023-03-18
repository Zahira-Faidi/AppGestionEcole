namespace AppGestionEcole
{
    partial class ProfControle
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
            this.components = new System.ComponentModel.Container();
            this.Modifier = new System.Windows.Forms.Button();
            this.Supprimer = new System.Windows.Forms.Button();
            this.username = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idProfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numtelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaireDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datenaissanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestionEcoleDataSet3 = new AppGestionEcole.GestionEcoleDataSet3();
            this.Ajouter = new System.Windows.Forms.Button();
            this.numtelprof = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.adresseprof = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.genreprof = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.datenaissanceprof = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mailprof = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.prenomprof = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nomprof = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.salaireprof = new System.Windows.Forms.TextBox();
            this.profTableAdapter = new AppGestionEcole.GestionEcoleDataSet3TableAdapters.profTableAdapter();
            this.label12 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionEcoleDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Modifier
            // 
            this.Modifier.BackColor = System.Drawing.Color.SteelBlue;
            this.Modifier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Modifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Modifier.Font = new System.Drawing.Font("Open Sans SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modifier.ForeColor = System.Drawing.Color.White;
            this.Modifier.Location = new System.Drawing.Point(1090, 670);
            this.Modifier.Name = "Modifier";
            this.Modifier.Size = new System.Drawing.Size(147, 41);
            this.Modifier.TabIndex = 49;
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
            this.Supprimer.Location = new System.Drawing.Point(937, 670);
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.Size = new System.Drawing.Size(147, 41);
            this.Supprimer.TabIndex = 48;
            this.Supprimer.Text = "Supprimer";
            this.Supprimer.UseVisualStyleBackColor = false;
            this.Supprimer.Click += new System.EventHandler(this.Supprimer_Click);
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("Open Sans SemiBold", 14.25F, System.Drawing.FontStyle.Bold);
            this.username.Location = new System.Drawing.Point(910, 83);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(291, 33);
            this.username.TabIndex = 46;
            this.username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.username.TextChanged += new System.EventHandler(this.username_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProfDataGridViewTextBoxColumn,
            this.nomDataGridViewTextBoxColumn,
            this.prenomDataGridViewTextBoxColumn,
            this.numtelDataGridViewTextBoxColumn,
            this.genreDataGridViewTextBoxColumn,
            this.salaireDataGridViewTextBoxColumn,
            this.mailDataGridViewTextBoxColumn,
            this.datenaissanceDataGridViewTextBoxColumn,
            this.adresseDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.profBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(290, 122);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(947, 535);
            this.dataGridView1.TabIndex = 45;
            // 
            // idProfDataGridViewTextBoxColumn
            // 
            this.idProfDataGridViewTextBoxColumn.DataPropertyName = "idProf";
            this.idProfDataGridViewTextBoxColumn.FillWeight = 50F;
            this.idProfDataGridViewTextBoxColumn.HeaderText = "idProf";
            this.idProfDataGridViewTextBoxColumn.Name = "idProfDataGridViewTextBoxColumn";
            this.idProfDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "nom";
            this.nomDataGridViewTextBoxColumn.FillWeight = 70F;
            this.nomDataGridViewTextBoxColumn.HeaderText = "nom";
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            this.nomDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prenomDataGridViewTextBoxColumn
            // 
            this.prenomDataGridViewTextBoxColumn.DataPropertyName = "prenom";
            this.prenomDataGridViewTextBoxColumn.FillWeight = 70F;
            this.prenomDataGridViewTextBoxColumn.HeaderText = "prenom";
            this.prenomDataGridViewTextBoxColumn.Name = "prenomDataGridViewTextBoxColumn";
            this.prenomDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numtelDataGridViewTextBoxColumn
            // 
            this.numtelDataGridViewTextBoxColumn.DataPropertyName = "numtel";
            this.numtelDataGridViewTextBoxColumn.HeaderText = "numtel";
            this.numtelDataGridViewTextBoxColumn.Name = "numtelDataGridViewTextBoxColumn";
            this.numtelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // genreDataGridViewTextBoxColumn
            // 
            this.genreDataGridViewTextBoxColumn.DataPropertyName = "genre";
            this.genreDataGridViewTextBoxColumn.FillWeight = 70F;
            this.genreDataGridViewTextBoxColumn.HeaderText = "genre";
            this.genreDataGridViewTextBoxColumn.Name = "genreDataGridViewTextBoxColumn";
            this.genreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // salaireDataGridViewTextBoxColumn
            // 
            this.salaireDataGridViewTextBoxColumn.DataPropertyName = "salaire";
            this.salaireDataGridViewTextBoxColumn.HeaderText = "salaire";
            this.salaireDataGridViewTextBoxColumn.Name = "salaireDataGridViewTextBoxColumn";
            this.salaireDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mailDataGridViewTextBoxColumn
            // 
            this.mailDataGridViewTextBoxColumn.DataPropertyName = "mail";
            this.mailDataGridViewTextBoxColumn.HeaderText = "mail";
            this.mailDataGridViewTextBoxColumn.Name = "mailDataGridViewTextBoxColumn";
            this.mailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datenaissanceDataGridViewTextBoxColumn
            // 
            this.datenaissanceDataGridViewTextBoxColumn.DataPropertyName = "datenaissance";
            this.datenaissanceDataGridViewTextBoxColumn.HeaderText = "datenaissance";
            this.datenaissanceDataGridViewTextBoxColumn.Name = "datenaissanceDataGridViewTextBoxColumn";
            this.datenaissanceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adresseDataGridViewTextBoxColumn
            // 
            this.adresseDataGridViewTextBoxColumn.DataPropertyName = "adresse";
            this.adresseDataGridViewTextBoxColumn.HeaderText = "adresse";
            this.adresseDataGridViewTextBoxColumn.Name = "adresseDataGridViewTextBoxColumn";
            this.adresseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // profBindingSource
            // 
            this.profBindingSource.DataMember = "prof";
            this.profBindingSource.DataSource = this.gestionEcoleDataSet3;
            // 
            // gestionEcoleDataSet3
            // 
            this.gestionEcoleDataSet3.DataSetName = "GestionEcoleDataSet3";
            this.gestionEcoleDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Ajouter
            // 
            this.Ajouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(141)))), ((int)(((byte)(54)))));
            this.Ajouter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Ajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ajouter.Font = new System.Drawing.Font("Open Sans SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ajouter.ForeColor = System.Drawing.Color.White;
            this.Ajouter.Location = new System.Drawing.Point(96, 670);
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Size = new System.Drawing.Size(147, 41);
            this.Ajouter.TabIndex = 44;
            this.Ajouter.Text = "Ajouter";
            this.Ajouter.UseVisualStyleBackColor = false;
            this.Ajouter.Click += new System.EventHandler(this.Ajouter_Click);
            // 
            // numtelprof
            // 
            this.numtelprof.Font = new System.Drawing.Font("Open Sans", 12F);
            this.numtelprof.Location = new System.Drawing.Point(30, 344);
            this.numtelprof.Mask = "00 00 00 00 00 00";
            this.numtelprof.Name = "numtelprof";
            this.numtelprof.Size = new System.Drawing.Size(212, 29);
            this.numtelprof.TabIndex = 43;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(25, 502);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 22);
            this.label9.TabIndex = 42;
            this.label9.Text = "Adresse";
            // 
            // adresseprof
            // 
            this.adresseprof.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adresseprof.Location = new System.Drawing.Point(30, 528);
            this.adresseprof.Multiline = true;
            this.adresseprof.Name = "adresseprof";
            this.adresseprof.Size = new System.Drawing.Size(213, 129);
            this.adresseprof.TabIndex = 41;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(27, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 22);
            this.label8.TabIndex = 40;
            this.label8.Text = "Genre";
            // 
            // genreprof
            // 
            this.genreprof.Font = new System.Drawing.Font("Open Sans", 12F);
            this.genreprof.FormattingEnabled = true;
            this.genreprof.Items.AddRange(new object[] {
            "Femme",
            "Homme"});
            this.genreprof.Location = new System.Drawing.Point(31, 231);
            this.genreprof.Name = "genreprof";
            this.genreprof.Size = new System.Drawing.Size(213, 30);
            this.genreprof.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 438);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 22);
            this.label7.TabIndex = 38;
            this.label7.Text = "Salaire";
            // 
            // datenaissanceprof
            // 
            this.datenaissanceprof.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datenaissanceprof.Location = new System.Drawing.Point(31, 289);
            this.datenaissanceprof.Name = "datenaissanceprof";
            this.datenaissanceprof.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.datenaissanceprof.Size = new System.Drawing.Size(213, 25);
            this.datenaissanceprof.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 22);
            this.label6.TabIndex = 35;
            this.label6.Text = "Date de naissance";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 381);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 22);
            this.label5.TabIndex = 34;
            this.label5.Text = "Adresse mail";
            // 
            // mailprof
            // 
            this.mailprof.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mailprof.Location = new System.Drawing.Point(30, 406);
            this.mailprof.Name = "mailprof";
            this.mailprof.Size = new System.Drawing.Size(213, 29);
            this.mailprof.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 22);
            this.label4.TabIndex = 32;
            this.label4.Text = "Numéro de téléphone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 22);
            this.label3.TabIndex = 31;
            this.label3.Text = "Prénom";
            // 
            // prenomprof
            // 
            this.prenomprof.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prenomprof.Location = new System.Drawing.Point(30, 174);
            this.prenomprof.Name = "prenomprof";
            this.prenomprof.Size = new System.Drawing.Size(213, 29);
            this.prenomprof.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 22);
            this.label2.TabIndex = 29;
            this.label2.Text = "Nom";
            // 
            // nomprof
            // 
            this.nomprof.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomprof.Location = new System.Drawing.Point(30, 120);
            this.nomprof.Name = "nomprof";
            this.nomprof.Size = new System.Drawing.Size(213, 29);
            this.nomprof.TabIndex = 28;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Location = new System.Drawing.Point(279, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 741);
            this.panel1.TabIndex = 27;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Image = global::AppGestionEcole.Properties.Resources.icons8_search_32;
            this.pictureBox3.Location = new System.Drawing.Point(1195, 83);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 33);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 47;
            this.pictureBox3.TabStop = false;
            // 
            // salaireprof
            // 
            this.salaireprof.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salaireprof.Location = new System.Drawing.Point(29, 463);
            this.salaireprof.Name = "salaireprof";
            this.salaireprof.Size = new System.Drawing.Size(213, 29);
            this.salaireprof.TabIndex = 50;
            // 
            // profTableAdapter
            // 
            this.profTableAdapter.ClearBeforeFill = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(22, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 22);
            this.label12.TabIndex = 28;
            this.label12.Text = "> Professeur";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label12);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1255, 77);
            this.panel2.TabIndex = 74;
            // 
            // ProfControle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.salaireprof);
            this.Controls.Add(this.Modifier);
            this.Controls.Add(this.Supprimer);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.username);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Ajouter);
            this.Controls.Add(this.numtelprof);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.adresseprof);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.genreprof);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.datenaissanceprof);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mailprof);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.prenomprof);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nomprof);
            this.Controls.Add(this.panel1);
            this.Name = "ProfControle";
            this.Size = new System.Drawing.Size(1255, 740);
            this.Load += new System.EventHandler(this.ProfControle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionEcoleDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Modifier;
        private System.Windows.Forms.Button Supprimer;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Ajouter;
        private System.Windows.Forms.MaskedTextBox numtelprof;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox adresseprof;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox genreprof;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker datenaissanceprof;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox mailprof;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox prenomprof;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nomprof;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox salaireprof;
        private System.Windows.Forms.BindingSource profBindingSource;
        private GestionEcoleDataSet3 gestionEcoleDataSet3;
        private GestionEcoleDataSet3TableAdapters.profTableAdapter profTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numtelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaireDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datenaissanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel2;
    }
}
