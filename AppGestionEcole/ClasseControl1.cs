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
    public partial class ClasseControl1 : UserControl
    {
        SqlConnection conn;
        SqlCommand cmd;
        string cs = "Persist Security Info=False;Integrated Security=true;Initial Catalog=GestionEcole;Server=(LocalDB)\\Local";
        public ClasseControl1()
        {
            InitializeComponent();
        }
        public void fillData()
        {
            string sql = "SELECT classe.idClasse, classe.nomClasse, classe.niveau, classe.anneesScolaire, filiere.abréviation FROM classe join filiere on classe.idFiliere = filiere.idFiliere;";
            SqlCommand sqlCommand = new SqlCommand(sql, conn);
            SqlDataAdapter sqlData = new SqlDataAdapter(sqlCommand);
            DataTable dataTable2 = new DataTable();
            sqlData.Fill(dataTable2);
            dataGridView1.DataSource = dataTable2;
        }

        private void ClasseControl1_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(cs);
            try
            {
                conn.Open();
                string query = "Select idFiliere, abréviation from filiere";
                cmd = new SqlCommand(query, conn);
                SqlDataReader dr = cmd.ExecuteReader();

                DataTable dataTable = new DataTable();

                dataTable.Load(dr);

                filiere.DataSource = dataTable;
                filiere.ValueMember = "idFiliere";
                filiere.DisplayMember = "abréviation";
                this.fillData();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void clear()
        {
            nomClasse.Text = "";
            niveauClasse.Text = "";
            anneeClasse.Text = "";
            filiere.Text = "";
        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            try
            {
                string insert = "INSERT INTO classe VALUES('"+nomClasse.Text+"','"+niveauClasse.Text+"','"+anneeClasse.Text+"',"+filiere.SelectedValue+")";
                cmd.CommandText = insert;
                cmd.ExecuteNonQuery();
                dataGridView1.RefreshEdit();
                this.fillData();
                this.clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Supprimer_Click(object sender, EventArgs e)
        {
            int id = dataGridView1.CurrentCell.RowIndex;
            if (id != -1)
            {
                int index = int.Parse(dataGridView1.Rows[id].Cells[0].Value.ToString());
                DialogResult result = MessageBox.Show("Est ce que vous voulez vraiment supprimer cette enregistrement", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult.Yes == result)
                {
                    string query = "delete classe where idClasse=" + index + ";";
                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();
                    this.fillData();
                    dataGridView1.RefreshEdit();
                }
            }
            else
            {
                MessageBox.Show("La table est vide ! ", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                    nomClasse.Text = dataGridView1.Rows[id].Cells[1].Value.ToString();
                    niveauClasse.Text = dataGridView1.Rows[id].Cells[2].Value.ToString();
                    anneeClasse.Text = dataGridView1.Rows[id].Cells[3].Value.ToString();
                    filiere.Text = dataGridView1.Rows[id].Cells[4].Value.ToString();
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
                        cmd.CommandText = "UPDATE classe SET nomClasse = '"+nomClasse.Text+ "', niveau = '"+niveauClasse.Text+ "', anneesScolaire = '"+anneeClasse.Text+ "', idFiliere="+filiere.SelectedValue+ " WHERE idClasse="+index;
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

        private void username_TextChanged(object sender, EventArgs e)
        {
            string sql = "SELECT classe.idClasse, classe.nomClasse, classe.niveau, classe.anneesScolaire, filiere.abréviation FROM classe join filiere on classe.idFiliere = filiere.idFiliere where classe.nomClasse Like '%" + username.Text + "%'";
            SqlCommand sqlCommand = new SqlCommand(sql, conn);
            SqlDataAdapter sqlData = new SqlDataAdapter(sqlCommand);
            DataTable dataTable2 = new DataTable();
            sqlData.Fill(dataTable2);
            dataGridView1.DataSource = dataTable2;
        }
    }
}
