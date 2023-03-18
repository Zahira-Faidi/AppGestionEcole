using DevExpress.XtraReports.UI;
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
    public partial class paimentEtu : UserControl
    {
        SqlConnection conn;
        SqlCommand cmd;
        string cs = "Persist Security Info=False;Integrated Security=true;Initial Catalog=GestionEcole;Server=(LocalDB)\\Local";
        public paimentEtu()
        {
            InitializeComponent();
        }
        public void fillData()
        {
            string sql = "select paiementEtu.idPaiement , CONCAT( etudiant.nom, ' ',  etudiant.prenom) AS nometu, paiementEtu.DatePaiement , paiementEtu.Mois , paiementEtu.Montant ,paiementEtu.typePaiement from paiementEtu join etudiant on paiementEtu.idEtudiant = etudiant.idEtudiant;";
            SqlCommand sqlCommand = new SqlCommand(sql, conn);
            SqlDataAdapter sqlData = new SqlDataAdapter(sqlCommand);
            DataTable dataTable2 = new DataTable();
            sqlData.Fill(dataTable2);
            dataGridView1.DataSource = dataTable2;
        }
        private void paimentEtu_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(cs);
            try
            {
                conn.Open();
                string query = "SELECT idEtudiant , CONCAT(nom, ' ', prenom) AS nometu FROM etudiant;";
                cmd = new SqlCommand(query, conn);
                SqlDataReader dr = cmd.ExecuteReader();

                DataTable dataTable = new DataTable();

                dataTable.Load(dr);

                nomEtu.DataSource = dataTable;
                nomEtu.ValueMember = "idEtudiant";
                nomEtu.DisplayMember = "nometu";
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
            datepaiement.Value = DateTime.Now;
            moisPaiement.Text = "";
            montantPayer.Text = "";
            typePaiement.Text = "";
        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            try
            {
                string insert = "INSERT INTO paiementEtu VALUES('" + datepaiement.Value.ToString() + "','" + moisPaiement.Text + "'," + float.Parse(montantPayer.Text) + ",'" + typePaiement.Text + "','"+nomEtu.SelectedValue+"')";
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

        private void Supprimer_Click(object sender, EventArgs e)
        {
            int id = dataGridView1.CurrentCell.RowIndex;
            if (id != -1)
            {
                int index = int.Parse(dataGridView1.Rows[id].Cells[0].Value.ToString());
                DialogResult result = MessageBox.Show("Est ce que vous voulez vraiment supprimer cette enregistrement", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult.Yes == result)
                {
                    string query = "delete paiementEtu where idPaiement=" + index + ";";
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
                    nomEtu.Text = dataGridView1.Rows[id].Cells[1].Value.ToString();
                    datepaiement.Text = dataGridView1.Rows[id].Cells[2].Value.ToString();
                    moisPaiement.Text = dataGridView1.Rows[id].Cells[3].Value.ToString();
                    montantPayer.Text = dataGridView1.Rows[id].Cells[4].Value.ToString();
                    typePaiement.Text = dataGridView1.Rows[id].Cells[5].Value.ToString();
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
                        cmd.CommandText = "UPDATE paiementEtu SET DatePaiement = '"+datepaiement.Value.ToString()+"', Mois = '"+moisPaiement.Text+"', Montant ="+float.Parse(montantPayer.Text)+" , typePaiement = '"+typePaiement.Text+"' , idEtudiant  ="+int.Parse(nomEtu.SelectedValue.ToString())+"  WHERE idPaiement = " + index;
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

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void chercher_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string sql = "select paiementEtu.idPaiement , CONCAT( etudiant.nom, ' ',  etudiant.prenom) AS nometu, paiementEtu.DatePaiement , paiementEtu.Mois , paiementEtu.Montant ,paiementEtu.typePaiement from paiementEtu join etudiant on paiementEtu.idEtudiant = etudiant.idEtudiant where etudiant.prenom Like '%" + chercher.Text + "%' or paiementEtu.Mois Like '%" + chercher.Text + "%' or paiementEtu.typePaiement Like '%" + chercher.Text + "%' or etudiant.nom Like '%" + chercher.Text + "%'";
                SqlCommand sqlCommand = new SqlCommand(sql, conn);
                SqlDataAdapter sqlData = new SqlDataAdapter(sqlCommand);
                DataTable dataTable2 = new DataTable();
                sqlData.Fill(dataTable2);
                dataGridView1.DataSource = dataTable2;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
