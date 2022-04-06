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
    public partial class AjouterMatiere : Form
    {
        public AjouterMatiere()
        {
            InitializeComponent();
        }

        // format json pour la requete de connexion
        private string jsonAjouter(string libelle)
        {
            string json = "{" +
                "\"libelle\":\"" + libelle + "\"" +
                "}";
            return json;
        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            Methods methods = new Methods();

            // requete post
            string url = "/matieres/ajouter";
            string json = jsonAjouter(tb_libelle.Text);

            // on recupere data
            var data = methods.postRequest(url, json);

            // si connecte
            if (string.Equals(data["erreur"].ToString(), "[]"))
            {
                // msg valid
                MessageBox.Show(data["valid"][0].ToString());
                this.Close();
            }
            else
            {
                // msg erreur
                MessageBox.Show(data["erreur"][0].ToString());
            }
        }
    }
}
