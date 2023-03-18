namespace AppGestionEcole
{
    partial class FiliereControl1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Modifier = new System.Windows.Forms.Button();
            this.Supprimer = new System.Windows.Forms.Button();
            this.username = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idFiliereDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomFiliereDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abréviationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datecreationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filiereBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestionEcoleDataSet2 = new AppGestionEcole.GestionEcoleDataSet2();
            this.Ajouter = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nomFiliere = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.datecreation = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.abrviation = new System.Windows.Forms.TextBox();
            this.filiereTableAdapter = new AppGestionEcole.GestionEcoleDataSet2TableAdapters.filiereTableAdapter();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filiereBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionEcoleDataSet2)).BeginInit();
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
            this.Modifier.Location = new System.Drawing.Point(1087, 674);
            this.Modifier.Name = "Modifier";
            this.Modifier.Size = new System.Drawing.Size(147, 41);
            this.Modifier.TabIndex = 65;
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
            this.Supprimer.Location = new System.Drawing.Point(934, 674);
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.Size = new System.Drawing.Size(147, 41);
            this.Supprimer.TabIndex = 64;
            this.Supprimer.Text = "Supprimer";
            this.Supprimer.UseVisualStyleBackColor = false;
            this.Supprimer.Click += new System.EventHandler(this.Supprimer_Click);
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("Open Sans SemiBold", 14.25F, System.Drawing.FontStyle.Bold);
            this.username.Location = new System.Drawing.Point(909, 83);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(291, 33);
            this.username.TabIndex = 62;
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
            this.idFiliereDataGridViewTextBoxColumn,
            this.nomFiliereDataGridViewTextBoxColumn,
            this.abréviationDataGridViewTextBoxColumn,
            this.datecreationDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.filiereBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(287, 122);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Size = new System.Drawing.Size(947, 535);
            this.dataGridView1.TabIndex = 61;
            // 
            // idFiliereDataGridViewTextBoxColumn
            // 
            this.idFiliereDataGridViewTextBoxColumn.DataPropertyName = "idFiliere";
            this.idFiliereDataGridViewTextBoxColumn.FillWeight = 50F;
            this.idFiliereDataGridViewTextBoxColumn.HeaderText = "idFiliere";
            this.idFiliereDataGridViewTextBoxColumn.Name = "idFiliereDataGridViewTextBoxColumn";
            this.idFiliereDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomFiliereDataGridViewTextBoxColumn
            // 
            this.nomFiliereDataGridViewTextBoxColumn.DataPropertyName = "nomFiliere";
            this.nomFiliereDataGridViewTextBoxColumn.HeaderText = "Nom Filiere";
            this.nomFiliereDataGridViewTextBoxColumn.Name = "nomFiliereDataGridViewTextBoxColumn";
            this.nomFiliereDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // abréviationDataGridViewTextBoxColumn
            // 
            this.abréviationDataGridViewTextBoxColumn.DataPropertyName = "abréviation";
            this.abréviationDataGridViewTextBoxColumn.FillWeight = 50F;
            this.abréviationDataGridViewTextBoxColumn.HeaderText = "Abréviation";
            this.abréviationDataGridViewTextBoxColumn.Name = "abréviationDataGridViewTextBoxColumn";
            this.abréviationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datecreationDataGridViewTextBoxColumn
            // 
            this.datecreationDataGridViewTextBoxColumn.DataPropertyName = "datecreation";
            this.datecreationDataGridViewTextBoxColumn.HeaderText = "Date de creation";
            this.datecreationDataGridViewTextBoxColumn.Name = "datecreationDataGridViewTextBoxColumn";
            this.datecreationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // filiereBindingSource
            // 
            this.filiereBindingSource.DataMember = "filiere";
            this.filiereBindingSource.DataSource = this.gestionEcoleDataSet2;
            // 
            // gestionEcoleDataSet2
            // 
            this.gestionEcoleDataSet2.DataSetName = "GestionEcoleDataSet2";
            this.gestionEcoleDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Ajouter
            // 
            this.Ajouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(141)))), ((int)(((byte)(54)))));
            this.Ajouter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Ajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ajouter.Font = new System.Drawing.Font("Open Sans SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ajouter.ForeColor = System.Drawing.Color.White;
            this.Ajouter.Location = new System.Drawing.Point(93, 305);
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Size = new System.Drawing.Size(147, 41);
            this.Ajouter.TabIndex = 60;
            this.Ajouter.Text = "Ajouter";
            this.Ajouter.UseVisualStyleBackColor = false;
            this.Ajouter.Click += new System.EventHandler(this.Ajouter_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 22);
            this.label2.TabIndex = 55;
            this.label2.Text = "Nom de Filiére";
            // 
            // nomFiliere
            // 
            this.nomFiliere.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomFiliere.Location = new System.Drawing.Point(27, 143);
            this.nomFiliere.Name = "nomFiliere";
            this.nomFiliere.Size = new System.Drawing.Size(213, 29);
            this.nomFiliere.TabIndex = 54;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Location = new System.Drawing.Point(271, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 741);
            this.panel1.TabIndex = 53;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Image = global::AppGestionEcole.Properties.Resources.icons8_search_32;
            this.pictureBox3.Location = new System.Drawing.Point(1194, 83);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 33);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 63;
            this.pictureBox3.TabStop = false;
            // 
            // datecreation
            // 
            this.datecreation.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datecreation.Location = new System.Drawing.Point(27, 262);
            this.datecreation.Name = "datecreation";
            this.datecreation.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.datecreation.Size = new System.Drawing.Size(213, 25);
            this.datecreation.TabIndex = 67;
            this.datecreation.Value = new System.DateTime(2022, 12, 6, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 22);
            this.label6.TabIndex = 66;
            this.label6.Text = "Date de création";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 22);
            this.label3.TabIndex = 69;
            this.label3.Text = "Abréviation";
            // 
            // abrviation
            // 
            this.abrviation.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abrviation.Location = new System.Drawing.Point(27, 201);
            this.abrviation.Name = "abrviation";
            this.abrviation.Size = new System.Drawing.Size(213, 29);
            this.abrviation.TabIndex = 68;
            // 
            // filiereTableAdapter
            // 
            this.filiereTableAdapter.ClearBeforeFill = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(22, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 22);
            this.label10.TabIndex = 28;
            this.label10.Text = "> Filiére";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label10);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1255, 77);
            this.panel2.TabIndex = 70;
            // 
            // FiliereControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.abrviation);
            this.Controls.Add(this.datecreation);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Modifier);
            this.Controls.Add(this.Supprimer);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.username);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Ajouter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nomFiliere);
            this.Controls.Add(this.panel1);
            this.Name = "FiliereControl1";
            this.Size = new System.Drawing.Size(1255, 740);
            this.Load += new System.EventHandler(this.FiliereControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filiereBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionEcoleDataSet2)).EndInit();
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nomFiliere;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker datecreation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox abrviation;
        private System.Windows.Forms.BindingSource filiereBindingSource;
        private GestionEcoleDataSet2 gestionEcoleDataSet2;
        private GestionEcoleDataSet2TableAdapters.filiereTableAdapter filiereTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFiliereDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomFiliereDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn abréviationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datecreationDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel2;
    }
}
