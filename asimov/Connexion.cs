using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net;

namespace asimov
{
    public partial class Connexion : Form
    {
        // importation des methodes
        Methods methods = new Methods();

        public Connexion()
        {
            InitializeComponent();
        }

        // format json pour la requete de connexion
        private string jsonConnexion(string id, string mdp)
        {
            string json = "{" +
                "\"identification\":\"" + id + "\"," +
                "\"motdepasse\":\"" + mdp + "\"" +
                "}";
            return json;
        }

        // on envoie la requete de connexion
        private void btn_connexion_Click(object sender, EventArgs e)
        {
            // requete post
            string url = "/connexion";
            string json = jsonConnexion(tb_identification.Text, tb_motdepasse.Text);
            
            // on recupere data
            var data = methods.postRequest(url, json);

            // si connecte
            if (data["user_info"] != null)
            {
                // msg valid
                MessageBox.Show(data["valid"][0].ToString(), "Succès");

                // ouvrir index
                this.Hide();
                Index index = new Index();
                index.Show();
            } else {
                // msg erreur
                MessageBox.Show(data["erreur"][0].ToString(), "Erreur");
            }
        }
    }
}