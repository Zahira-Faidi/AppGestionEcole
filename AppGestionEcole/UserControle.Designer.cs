namespace AppGestionEcole
{
    partial class UserControle
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
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datenaissanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numtelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isadminDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestionEcoleDataSet = new AppGestionEcole.GestionEcoleDataSet();
            this.Ajouter = new System.Windows.Forms.Button();
            this.numTeluser = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.isadmin = new System.Windows.Forms.ComboBox();
            this.datenaissanceuser = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.prenomuser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nomuser = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.motpasse = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.confirmMotPasse = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.adresseuser = new System.Windows.Forms.TextBox();
            this.usersTableAdapter = new AppGestionEcole.GestionEcoleDataSetTableAdapters.usersTableAdapter();
            this.label12 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionEcoleDataSet)).BeginInit();
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
            this.Modifier.Location = new System.Drawing.Point(1088, 688);
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
            this.Supprimer.Location = new System.Drawing.Point(935, 688);
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
            this.idDataGridViewTextBoxColumn,
            this.nomDataGridViewTextBoxColumn,
            this.prenomDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.datenaissanceDataGridViewTextBoxColumn,
            this.numtelDataGridViewTextBoxColumn,
            this.adresseDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.isadminDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.usersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(288, 122);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(947, 560);
            this.dataGridView1.TabIndex = 45;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.FillWeight = 50F;
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "nom";
            this.nomDataGridViewTextBoxColumn.FillWeight = 60F;
            this.nomDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            this.nomDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prenomDataGridViewTextBoxColumn
            // 
            this.prenomDataGridViewTextBoxColumn.DataPropertyName = "prenom";
            this.prenomDataGridViewTextBoxColumn.FillWeight = 60F;
            this.prenomDataGridViewTextBoxColumn.HeaderText = "Prénom";
            this.prenomDataGridViewTextBoxColumn.Name = "prenomDataGridViewTextBoxColumn";
            this.prenomDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "username";
            this.usernameDataGridViewTextBoxColumn.FillWeight = 80F;
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Nom Utilisateur";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datenaissanceDataGridViewTextBoxColumn
            // 
            this.datenaissanceDataGridViewTextBoxColumn.DataPropertyName = "datenaissance";
            this.datenaissanceDataGridViewTextBoxColumn.FillWeight = 80F;
            this.datenaissanceDataGridViewTextBoxColumn.HeaderText = "Date de Naissance";
            this.datenaissanceDataGridViewTextBoxColumn.Name = "datenaissanceDataGridViewTextBoxColumn";
            this.datenaissanceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numtelDataGridViewTextBoxColumn
            // 
            this.numtelDataGridViewTextBoxColumn.DataPropertyName = "numtel";
            this.numtelDataGridViewTextBoxColumn.FillWeight = 80F;
            this.numtelDataGridViewTextBoxColumn.HeaderText = "Num Tel";
            this.numtelDataGridViewTextBoxColumn.Name = "numtelDataGridViewTextBoxColumn";
            this.numtelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adresseDataGridViewTextBoxColumn
            // 
            this.adresseDataGridViewTextBoxColumn.DataPropertyName = "adresse";
            this.adresseDataGridViewTextBoxColumn.FillWeight = 130F;
            this.adresseDataGridViewTextBoxColumn.HeaderText = "Adresse";
            this.adresseDataGridViewTextBoxColumn.Name = "adresseDataGridViewTextBoxColumn";
            this.adresseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Mot de passe";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isadminDataGridViewTextBoxColumn
            // 
            this.isadminDataGridViewTextBoxColumn.DataPropertyName = "isadmin";
            this.isadminDataGridViewTextBoxColumn.FillWeight = 50F;
            this.isadminDataGridViewTextBoxColumn.HeaderText = "isadmin";
            this.isadminDataGridViewTextBoxColumn.Name = "isadminDataGridViewTextBoxColumn";
            this.isadminDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.gestionEcoleDataSet;
            // 
            // gestionEcoleDataSet
            // 
            this.gestionEcoleDataSet.DataSetName = "GestionEcoleDataSet";
            this.gestionEcoleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Ajouter
            // 
            this.Ajouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(141)))), ((int)(((byte)(54)))));
            this.Ajouter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Ajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ajouter.Font = new System.Drawing.Font("Open Sans SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ajouter.ForeColor = System.Drawing.Color.White;
            this.Ajouter.Location = new System.Drawing.Point(92, 679);
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Size = new System.Drawing.Size(147, 41);
            this.Ajouter.TabIndex = 44;
            this.Ajouter.Text = "Ajouter";
            this.Ajouter.UseVisualStyleBackColor = false;
            this.Ajouter.Click += new System.EventHandler(this.Ajouter_Click);
            // 
            // numTeluser
            // 
            this.numTeluser.Font = new System.Drawing.Font("Open Sans", 12F);
            this.numTeluser.Location = new System.Drawing.Point(26, 316);
            this.numTeluser.Mask = "00 00 00 00 00 00";
            this.numTeluser.Name = "numTeluser";
            this.numTeluser.Size = new System.Drawing.Size(215, 29);
            this.numTeluser.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 437);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 22);
            this.label7.TabIndex = 38;
            this.label7.Text = "Nom d\'utilisateur";
            // 
            // isadmin
            // 
            this.isadmin.Font = new System.Drawing.Font("Open Sans", 12F);
            this.isadmin.FormattingEnabled = true;
            this.isadmin.Items.AddRange(new object[] {
            "Oui",
            "Non"});
            this.isadmin.Location = new System.Drawing.Point(27, 632);
            this.isadmin.Name = "isadmin";
            this.isadmin.Size = new System.Drawing.Size(213, 30);
            this.isadmin.TabIndex = 37;
            // 
            // datenaissanceuser
            // 
            this.datenaissanceuser.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datenaissanceuser.Location = new System.Drawing.Point(28, 262);
            this.datenaissanceuser.Name = "datenaissanceuser";
            this.datenaissanceuser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.datenaissanceuser.Size = new System.Drawing.Size(213, 25);
            this.datenaissanceuser.TabIndex = 36;
            this.datenaissanceuser.Value = new System.DateTime(2022, 12, 7, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 22);
            this.label6.TabIndex = 35;
            this.label6.Text = "Date de naissance";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 22);
            this.label4.TabIndex = 32;
            this.label4.Text = "Numéro de téléphone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 22);
            this.label3.TabIndex = 31;
            this.label3.Text = "Prénom";
            // 
            // prenomuser
            // 
            this.prenomuser.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prenomuser.Location = new System.Drawing.Point(27, 204);
            this.prenomuser.Name = "prenomuser";
            this.prenomuser.Size = new System.Drawing.Size(213, 29);
            this.prenomuser.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 22);
            this.label2.TabIndex = 29;
            this.label2.Text = "Nom";
            // 
            // nomuser
            // 
            this.nomuser.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomuser.Location = new System.Drawing.Point(27, 150);
            this.nomuser.Name = "nomuser";
            this.nomuser.Size = new System.Drawing.Size(213, 29);
            this.nomuser.TabIndex = 28;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Location = new System.Drawing.Point(272, 0);
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
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(27, 462);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(213, 29);
            this.textBox3.TabIndex = 50;
            // 
            // motpasse
            // 
            this.motpasse.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.motpasse.Location = new System.Drawing.Point(27, 518);
            this.motpasse.Name = "motpasse";
            this.motpasse.Size = new System.Drawing.Size(213, 29);
            this.motpasse.TabIndex = 52;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(23, 493);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 22);
            this.label8.TabIndex = 51;
            this.label8.Text = "Mot de passe";
            // 
            // confirmMotPasse
            // 
            this.confirmMotPasse.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmMotPasse.Location = new System.Drawing.Point(27, 576);
            this.confirmMotPasse.Name = "confirmMotPasse";
            this.confirmMotPasse.Size = new System.Drawing.Size(213, 29);
            this.confirmMotPasse.TabIndex = 54;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(23, 551);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(193, 22);
            this.label9.TabIndex = 53;
            this.label9.Text = "Confirmer mot de passe";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(23, 607);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 22);
            this.label10.TabIndex = 55;
            this.label10.Text = "Est un admin";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(22, 357);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 22);
            this.label11.TabIndex = 57;
            this.label11.Text = "Adresse";
            // 
            // adresseuser
            // 
            this.adresseuser.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adresseuser.Location = new System.Drawing.Point(26, 382);
            this.adresseuser.Multiline = true;
            this.adresseuser.Name = "adresseuser";
            this.adresseuser.Size = new System.Drawing.Size(213, 52);
            this.adresseuser.TabIndex = 56;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(22, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 22);
            this.label12.TabIndex = 28;
            this.label12.Text = "> Utilisateur";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label12);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1255, 77);
            this.panel2.TabIndex = 72;
            // 
            // UserControle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.adresseuser);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.confirmMotPasse);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.motpasse);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.Modifier);
            this.Controls.Add(this.Supprimer);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.username);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Ajouter);
            this.Controls.Add(this.numTeluser);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.isadmin);
            this.Controls.Add(this.datenaissanceuser);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.prenomuser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nomuser);
            this.Controls.Add(this.panel1);
            this.Name = "UserControle";
            this.Size = new System.Drawing.Size(1255, 740);
            this.Load += new System.EventHandler(this.UserControle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionEcoleDataSet)).EndInit();
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
        private System.Windows.Forms.MaskedTextBox numTeluser;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox isadmin;
        private System.Windows.Forms.DateTimePicker datenaissanceuser;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox prenomuser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nomuser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox motpasse;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox confirmMotPasse;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox adresseuser;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private GestionEcoleDataSet gestionEcoleDataSet;
        private GestionEcoleDataSetTableAdapters.usersTableAdapter usersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datenaissanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numtelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isadminDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel2;
    }
}
