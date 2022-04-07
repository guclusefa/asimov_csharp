using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace asimov
{
    public partial class LesMatieres : Form
    {
        // importation des methods
        Methods methods = new Methods();

        public LesMatieres()
        {
            InitializeComponent();
            getLesMatieres();
        }

        // recuper les matieres
        public void getLesMatieres()
        {
            // requete des matieres
            string url = "/matieres/liste";
            var data = methods.getRequest(url);

            // clear tableau
            dg_lesMatieres.Rows.Clear();
            dg_lesMatieres.Refresh();

            // affichage des data dans le tableau
            foreach (var item in data["lesMatieres"])
            {
                dg_lesMatieres.Rows.Add(item["matiere_id"], item["matiere_libelle"]);
            }
        }

        // les params qu'on fait passer
        public static int modifier = 0;
        public static string matiere_id = "";
        public static string matiere_libelle = "";

        // ajouter
        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            // requete des matieres
            string url = "/matieres/ajouter";
            var data = methods.getRequest(url);

            // si autorisé a ajouter
            if (string.Equals(data["erreur"].ToString(), "[]"))
            {
                // modification a 0
                modifier = 0;

                // open ajouter matiere dialog
                FormMatiere formMatiere = new FormMatiere();
                formMatiere.ShowDialog();

                // refresh
                getLesMatieres();
            }
            else
            {
                MessageBox.Show(data["erreur"][0].ToString(), "Erreur");
            }
        }

        // modifier
        private void btn_modifierMatiere_Click(object sender, EventArgs e)
        {
            if (dg_lesMatieres.SelectedRows.Count != 0)
            {
                // recupere id selectionné
                DataGridViewRow row = this.dg_lesMatieres.SelectedRows[0];

                // faire passer params
                modifier = 1;
                matiere_id = row.Cells["id"].Value.ToString();
                matiere_libelle = row.Cells["libelle"].Value.ToString();

                // requete des matieres
                string url = "/matieres/modifier/" + matiere_id;
                var data = methods.getRequest(url);

                // si autorisé a modifier
                if (string.Equals(data["erreur"].ToString(), "[]"))
                {
                    // open ajouter matiere dialog
                    FormMatiere formMatiere = new FormMatiere();
                    formMatiere.ShowDialog();

                    // refresh
                    getLesMatieres();
                }
                else
                {
                    MessageBox.Show(data["erreur"][0].ToString(), "Erreur");
                }
            }
            else
            {
                MessageBox.Show("Veuillez selectionner une matiere", "Erreur");
            }
        }

        // supprimer 
        private void btn_supprimerMatiere_Click(object sender, EventArgs e)
        {
            // si ligne choisie
            if (dg_lesMatieres.SelectedRows.Count != 0)
            {
                // confirmations
                var confirmResult = MessageBox.Show("Êtes-vous sûr de supprimer " + dg_lesMatieres.SelectedRows.Count.ToString() + " matière(s) ?",
                    "Confirmation",
                    MessageBoxButtons.YesNo);


                // si supprimer
                if (confirmResult == DialogResult.Yes)
                {
                    int i = 0;
                    // les requetes de delete
                    foreach (DataGridViewRow r in dg_lesMatieres.SelectedRows)
                    {
                        // requete get
                        string url = "/matieres/supprimer/" + r.Cells["id"].Value.ToString();
                        var data = methods.getRequest(url);
                        // si erreur lors supp
                        if (!string.Equals(data["erreur"].ToString(), "[]"))
                        {
                            MessageBox.Show(data["erreur"][0].ToString(), "Erreur");
                            i++;
                        }
                    }

                    // msg succès avec le total de supp avec succès
                    MessageBox.Show("Supprimé "+ (dg_lesMatieres.SelectedRows.Count - i).ToString() + " matière(s) avec succès", "Succès");

                    // refresh
                    getLesMatieres();
                }
            }
            else
            {
                MessageBox.Show("Veuillez selectionner une matiere", "Erreur");
            }
        }

        // quitter
        private void btn_quitter_Click(object sender, EventArgs e)
        {
            // revnir index
            this.Hide();
            Index index = new Index();
            index.Show();
        }

        // détail
        private void btn_detail_Click(object sender, EventArgs e)
        {
            // si ligne choisie
            if (dg_lesMatieres.SelectedRows.Count != 0)
            {
                // recupere id selectionné
                DataGridViewRow row = this.dg_lesMatieres.SelectedRows[0];
                
                // requete get
                string url = "/matieres/fiche/" + row.Cells["id"].Value.ToString();
                var data = methods.getRequest(url);

                // si autorisé a voir
                if (string.Equals(data["erreur"].ToString(), "[]"))
                {
                    // les détails
                    string detail = "id : " + data["uneMatiere"]["matiere_id"].ToString();
                    detail += "\nLibellé : " + data["uneMatiere"]["matiere_libelle"].ToString();

                    // affichage
                    MessageBox.Show(detail, "Détail matière");
                }
                else
                {
                    MessageBox.Show(data["erreur"][0].ToString(), "Erreur");
                }
            }
            else
            {
                MessageBox.Show("Veuillez selectionner une matiere", "Erreur");
            }
        }

        // chercher
        private void tb_chercher_TextChanged(object sender, EventArgs e)
        {
            // chercher dans datagrid
            methods.searchDataGrid(dg_lesMatieres, tb_chercher);
        }
    }
}
