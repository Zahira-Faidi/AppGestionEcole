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

namespace AppGestionEcole
{
    public partial class EtudiantControle : UserControl
    {
        SqlConnection conn;
        SqlCommand cmd;
        string cs = "Persist Security Info=False;Integrated Security=true;Initial Catalog=GestionEcole;Server=(LocalDB)\\Local";
        public EtudiantControle()
        {
            InitializeComponent();
        }
        public void fillData()
        {
            string sql = "SELECT etudiant.idEtudiant, etudiant.nom , etudiant.prenom , etudiant.datenaissance , etudiant.numtel , etudiant.adresse, etudiant.mail , etudiant.genre , classe.nomClasse FROM etudiant join classe on etudiant.idClasse = classe.idClasse;";
            SqlCommand sqlCommand = new SqlCommand(sql, conn);
            SqlDataAdapter sqlData = new SqlDataAdapter(sqlCommand);
            DataTable dataTable2 = new DataTable();
            sqlData.Fill(dataTable2);
            dataGridView1.DataSource = dataTable2;
        }
        private void EtudiantControle_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(cs);
            try
            {
                conn.Open();
                string query = "select DISTINCT(nomClasse) , idClasse from classe;";
                cmd = new SqlCommand(query, conn);
                SqlDataReader dr = cmd.ExecuteReader();

                DataTable dataTable = new DataTable();

                dataTable.Load(dr);

                classeEtu.DataSource= dataTable;
                classeEtu.ValueMember = "idClasse";
                classeEtu.DisplayMember = "nomClasse";
                this.fillData();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void Ajouter_Click(object sender, EventArgs e)
        {
            try
            {
                string insert = "INSERT INTO etudiant(nom, prenom, datenaissance, numtel, adresse , mail , genre , idClasse ) VALUES('" + nomEtu.Text + "','" + prenomEtu.Text + "','" + datenaissanceEtu.Value.ToString() + "','" + numTelEtu.Text + "','" + adresseEtu.Text + "','" + mailEtu.Text + "','" + genreEtu.Text + "'," + classeEtu.SelectedValue + ");";
                cmd.CommandText = insert;
                cmd.ExecuteNonQuery();
                dataGridView1.RefreshEdit();
                this.clear();
                this.fillData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }
        public void clear()
        {
            nomEtu.Text = "";
            prenomEtu.Text = "";
            datenaissanceEtu.Value = DateTime.Now;
            numTelEtu.Text = "";
            adresseEtu.Text = "";
            mailEtu.Text = "";
            genreEtu.Text = "";
            classeEtu.Text = "";
        }
        int t = -1;

        private void Modifier_Click(object sender, EventArgs e)
        {
            int id = dataGridView1.CurrentCell.RowIndex;
            int index = int.Parse(dataGridView1.Rows[id].Cells[0].Value.ToString());

            try
            {
                if (t != 1)
                {
                    nomEtu.Text = dataGridView1.Rows[id].Cells[1].Value.ToString(); ;
                    prenomEtu.Text = dataGridView1.Rows[id].Cells[2].Value.ToString(); ;
                    datenaissanceEtu.Text = dataGridView1.Rows[id].Cells[3].Value.ToString(); ;
                    numTelEtu.Text =dataGridView1.Rows[id].Cells[4].Value.ToString(); ;
                    adresseEtu.Text = dataGridView1.Rows[id].Cells[5].Value.ToString(); ;
                    mailEtu.Text = dataGridView1.Rows[id].Cells[6].Value.ToString(); ;
                    genreEtu.Text = dataGridView1.Rows[id].Cells[7].Value.ToString(); ;
                    classeEtu.Text = dataGridView1.Rows[id].Cells[8].Value.ToString(); ;

                    Ajouter.Enabled = false;
                    Supprimer.Enabled = false;
                }

                if (t != -1)
                {
                    DialogResult result = MessageBox.Show("Est ce que vous voulez vraiment modifier cette enregistrement", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        SqlCommand cmd = conn.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "update etudiant set nom = '"+nomEtu.Text+"', prenom='"+prenomEtu.Text+"', datenaissance='"+datenaissanceEtu.Value.Date.ToString()+"', numtel='"+numTelEtu.Text+"', adresse='"+adresseEtu.Text+"' , mail='"+mailEtu.Text+"' , genre ='"+genreEtu.Text+"', idClasse="+classeEtu.SelectedValue+ " where idEtudiant = "+index;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Opération bien effectuer ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.clear();
                        Ajouter.Enabled = true;
                        Supprimer.Enabled = true;
                        this.fillData();
                        
                    }
                    else
                    {
                        this.clear();
                        Ajouter.Enabled = true;
                        Supprimer.Enabled = true;
                    }
                    t = -1;
                }
                else
                {
                    t = 1;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Supprimer_Click(object sender, EventArgs e)
        {
            try
            {
                int id = dataGridView1.CurrentCell.RowIndex;
                int index = int.Parse(dataGridView1.Rows[id].Cells[0].Value.ToString());
                DialogResult result = MessageBox.Show("Est ce que vous voulez vraiment supprimer cette enregistrement", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult.Yes == result)
                {
                    string query = "DELETE FROM etudiant where idEtudiant = " + index;
                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();
                    this.fillData();
                    dataGridView1.RefreshEdit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void username_TextChanged(object sender, EventArgs e)
        {
            string sql = "SELECT * from etudiant where nom Like '%" + username.Text + "%' or prenom Like '%" + username.Text + "%'";
            SqlCommand sqlCommand = new SqlCommand(sql, conn);
            SqlDataAdapter sqlData = new SqlDataAdapter(sqlCommand);
            DataTable dataTable2 = new DataTable();
            sqlData.Fill(dataTable2);
            dataGridView1.DataSource = dataTable2;
        }
    }
}
