namespace AppGestionEcole
{
    partial class EcoleControl1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nomEcole = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Ajouter = new System.Windows.Forms.Button();
            this.Modifier = new System.Windows.Forms.Button();
            this.username = new System.Windows.Forms.TextBox();
            this.Supprimer = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idEcoleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomEcoleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseEcoleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numtelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailEcoleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sitewebDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ribDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ecoleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestionEcoleDataSet1 = new AppGestionEcole.GestionEcoleDataSet1();
            this.label3 = new System.Windows.Forms.Label();
            this.AdresseEcole = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numTelEcole = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mailEcole = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.siteweb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rib = new System.Windows.Forms.TextBox();
            this.ecoleTableAdapter = new AppGestionEcole.GestionEcoleDataSet1TableAdapters.ecoleTableAdapter();
            this.logo = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ecoleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionEcoleDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Location = new System.Drawing.Point(272, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 741);
            this.panel1.TabIndex = 27;
            // 
            // nomEcole
            // 
            this.nomEcole.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomEcole.Location = new System.Drawing.Point(23, 206);
            this.nomEcole.Name = "nomEcole";
            this.nomEcole.Size = new System.Drawing.Size(231, 29);
            this.nomEcole.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 22);
            this.label2.TabIndex = 29;
            this.label2.Text = "Nom Ecole";
            // 
            // Ajouter
            // 
            this.Ajouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(141)))), ((int)(((byte)(54)))));
            this.Ajouter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Ajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ajouter.Font = new System.Drawing.Font("Open Sans SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ajouter.ForeColor = System.Drawing.Color.White;
            this.Ajouter.Location = new System.Drawing.Point(90, 663);
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Size = new System.Drawing.Size(147, 41);
            this.Ajouter.TabIndex = 44;
            this.Ajouter.Text = "Ajouter";
            this.Ajouter.UseVisualStyleBackColor = false;
            this.Ajouter.Click += new System.EventHandler(this.Ajouter_Click);
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
            this.Modifier.TabIndex = 49;
            this.Modifier.Text = "Modifier";
            this.Modifier.UseVisualStyleBackColor = false;
            this.Modifier.Click += new System.EventHandler(this.Modifier_Click);
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
            this.Supprimer.TabIndex = 48;
            this.Supprimer.Text = "Supprimer";
            this.Supprimer.UseVisualStyleBackColor = false;
            this.Supprimer.Click += new System.EventHandler(this.Supprimer_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idEcoleDataGridViewTextBoxColumn,
            this.nomEcoleDataGridViewTextBoxColumn,
            this.adresseEcoleDataGridViewTextBoxColumn,
            this.numtelDataGridViewTextBoxColumn,
            this.emailEcoleDataGridViewTextBoxColumn,
            this.sitewebDataGridViewTextBoxColumn,
            this.ribDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ecoleBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(288, 122);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Size = new System.Drawing.Size(947, 535);
            this.dataGridView1.TabIndex = 45;
            // 
            // idEcoleDataGridViewTextBoxColumn
            // 
            this.idEcoleDataGridViewTextBoxColumn.DataPropertyName = "idEcole";
            this.idEcoleDataGridViewTextBoxColumn.HeaderText = "idEcole";
            this.idEcoleDataGridViewTextBoxColumn.Name = "idEcoleDataGridViewTextBoxColumn";
            this.idEcoleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomEcoleDataGridViewTextBoxColumn
            // 
            this.nomEcoleDataGridViewTextBoxColumn.DataPropertyName = "nomEcole";
            this.nomEcoleDataGridViewTextBoxColumn.HeaderText = "nomEcole";
            this.nomEcoleDataGridViewTextBoxColumn.Name = "nomEcoleDataGridViewTextBoxColumn";
            this.nomEcoleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adresseEcoleDataGridViewTextBoxColumn
            // 
            this.adresseEcoleDataGridViewTextBoxColumn.DataPropertyName = "adresseEcole";
            this.adresseEcoleDataGridViewTextBoxColumn.HeaderText = "adresseEcole";
            this.adresseEcoleDataGridViewTextBoxColumn.Name = "adresseEcoleDataGridViewTextBoxColumn";
            this.adresseEcoleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numtelDataGridViewTextBoxColumn
            // 
            this.numtelDataGridViewTextBoxColumn.DataPropertyName = "numtel";
            this.numtelDataGridViewTextBoxColumn.HeaderText = "numtel";
            this.numtelDataGridViewTextBoxColumn.Name = "numtelDataGridViewTextBoxColumn";
            this.numtelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailEcoleDataGridViewTextBoxColumn
            // 
            this.emailEcoleDataGridViewTextBoxColumn.DataPropertyName = "emailEcole";
            this.emailEcoleDataGridViewTextBoxColumn.HeaderText = "emailEcole";
            this.emailEcoleDataGridViewTextBoxColumn.Name = "emailEcoleDataGridViewTextBoxColumn";
            this.emailEcoleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sitewebDataGridViewTextBoxColumn
            // 
            this.sitewebDataGridViewTextBoxColumn.DataPropertyName = "siteweb";
            this.sitewebDataGridViewTextBoxColumn.HeaderText = "siteweb";
            this.sitewebDataGridViewTextBoxColumn.Name = "sitewebDataGridViewTextBoxColumn";
            this.sitewebDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ribDataGridViewTextBoxColumn
            // 
            this.ribDataGridViewTextBoxColumn.DataPropertyName = "rib";
            this.ribDataGridViewTextBoxColumn.HeaderText = "rib";
            this.ribDataGridViewTextBoxColumn.Name = "ribDataGridViewTextBoxColumn";
            this.ribDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ecoleBindingSource
            // 
            this.ecoleBindingSource.DataMember = "ecole";
            this.ecoleBindingSource.DataSource = this.gestionEcoleDataSet1;
            // 
            // gestionEcoleDataSet1
            // 
            this.gestionEcoleDataSet1.DataSetName = "GestionEcoleDataSet1";
            this.gestionEcoleDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 410);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 22);
            this.label3.TabIndex = 51;
            this.label3.Text = "Adresse Ecole";
            // 
            // AdresseEcole
            // 
            this.AdresseEcole.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdresseEcole.Location = new System.Drawing.Point(22, 435);
            this.AdresseEcole.Multiline = true;
            this.AdresseEcole.Name = "AdresseEcole";
            this.AdresseEcole.Size = new System.Drawing.Size(231, 89);
            this.AdresseEcole.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 22);
            this.label4.TabIndex = 53;
            this.label4.Text = "Numéro Telephone";
            // 
            // numTelEcole
            // 
            this.numTelEcole.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTelEcole.Location = new System.Drawing.Point(22, 318);
            this.numTelEcole.Multiline = true;
            this.numTelEcole.Name = "numTelEcole";
            this.numTelEcole.Size = new System.Drawing.Size(234, 89);
            this.numTelEcole.TabIndex = 52;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 22);
            this.label5.TabIndex = 55;
            this.label5.Text = "Email Ecole";
            // 
            // mailEcole
            // 
            this.mailEcole.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mailEcole.Location = new System.Drawing.Point(24, 261);
            this.mailEcole.Name = "mailEcole";
            this.mailEcole.Size = new System.Drawing.Size(231, 29);
            this.mailEcole.TabIndex = 54;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 525);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 22);
            this.label6.TabIndex = 57;
            this.label6.Text = "Site Web";
            // 
            // siteweb
            // 
            this.siteweb.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siteweb.Location = new System.Drawing.Point(24, 550);
            this.siteweb.Name = "siteweb";
            this.siteweb.Size = new System.Drawing.Size(231, 29);
            this.siteweb.TabIndex = 56;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 582);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 22);
            this.label7.TabIndex = 59;
            this.label7.Text = "RIB";
            // 
            // rib
            // 
            this.rib.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rib.Location = new System.Drawing.Point(25, 607);
            this.rib.Name = "rib";
            this.rib.Size = new System.Drawing.Size(231, 29);
            this.rib.TabIndex = 58;
            // 
            // ecoleTableAdapter
            // 
            this.ecoleTableAdapter.ClearBeforeFill = true;
            // 
            // logo
            // 
            this.logo.Image = global::AppGestionEcole.Properties.Resources.logo_1;
            this.logo.Location = new System.Drawing.Point(22, 85);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(233, 93);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 60;
            this.logo.TabStop = false;
            this.logo.Click += new System.EventHandler(this.logo_Click);
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
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(22, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 22);
            this.label12.TabIndex = 28;
            this.label12.Text = "> Info Ecole";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label12);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1273, 77);
            this.panel2.TabIndex = 73;
            // 
            // EcoleControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rib);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.siteweb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mailEcole);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numTelEcole);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AdresseEcole);
            this.Controls.Add(this.Modifier);
            this.Controls.Add(this.Supprimer);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.username);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Ajouter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nomEcole);
            this.Controls.Add(this.panel1);
            this.Name = "EcoleControl1";
            this.Size = new System.Drawing.Size(1273, 740);
            this.Load += new System.EventHandler(this.EcoleControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ecoleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionEcoleDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox nomEcole;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Ajouter;
        private System.Windows.Forms.Button Modifier;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Button Supprimer;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AdresseEcole;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox numTelEcole;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox mailEcole;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox siteweb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox rib;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.BindingSource ecoleBindingSource;
        private GestionEcoleDataSet1 gestionEcoleDataSet1;
        private GestionEcoleDataSet1TableAdapters.ecoleTableAdapter ecoleTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEcoleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomEcoleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseEcoleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numtelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailEcoleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sitewebDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ribDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel2;
    }
}
