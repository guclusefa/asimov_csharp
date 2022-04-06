using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net;

namespace asimov
{
    public partial class Connexion : Form
    {
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
        private void button1_Click(object sender, EventArgs e)
        {
            // importation des methods
            Methods methods = new Methods();

            // requete post
            string url = "http://localhost:8080/connexion";
            string json = jsonConnexion(tb_identification.Text, tb_motdepasse.Text);
            
            // on recupere data
            var data = methods.postRequest(url, json);

            // si connecte
            if (data["user_info"] != null)
            {
                MessageBox.Show(data["valid"].ToString());
                // open index
                this.Hide();
                Index index = new Index();
                index.Show();
            } else {
               MessageBox.Show(data["erreur"].ToString());
            }
        }
    }
}