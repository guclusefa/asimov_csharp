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
    public partial class FormMatiere : Form
    {
        // importation des methodes
        Methods methods = new Methods();

        public FormMatiere()
        {
            InitializeComponent();

            // si modifier
            if (LesMatieres.modifier == 1)
            {
                this.Text = "Modifier matière";
                label1.Text = "Modifier";
                btn_valider.Text = "Modifier";
                tb_libelle.Text = LesMatieres.matiere_libelle;
            }
        }

        // format json pour ajouter
        private string jsonAjouter(string libelle)
        {
            string json = "{" +
                "\"libelle\":\"" + libelle + "\"" +
                "}";
            return json;
        }

        // format json pour modifier
        private string jsonModifier(string libelle, string id)
        {
            string json = "{" +
                "\"libelle\":\"" + libelle + "\"," +
                "\"id\":\"" + id + "\"" +
                "}";
            return json;
        }

        // valider
        private void btn_valider_Click(object sender, EventArgs e)
        {
            var url = "";
            var json = "";

            // si pour ajouter sinon pour ajouter
            if (LesMatieres.modifier == 0)
            {
                url = "/matieres/ajouter";
                json = jsonAjouter(tb_libelle.Text);
            } else
            {
                url = "/matieres/modifier/" + LesMatieres.matiere_id;
                json = jsonModifier(tb_libelle.Text, LesMatieres.matiere_id);
            }

            // on recupere data
            var data = methods.postRequest(url, json);

            // si pas d'erreur
            if (string.Equals(data["erreur"].ToString(), "[]"))
            {
                MessageBox.Show(data["valid"][0].ToString(), "Succès");
                this.Close();
            }
            else
            {
                MessageBox.Show(data["erreur"][0].ToString(), "Erreur");
            }
        }
    }
}
