using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net;

namespace asimov
{
    public partial class Connexion : Form
    {
        // importation des methodes
        Methods methods = new Methods();

        // initilisation
        public Connexion()
        {
            InitializeComponent();
        }

        // connexion
        private void btn_connexion_Click(object sender, EventArgs e)
        {
            // requete post
            string url = "/connexion";

            // les params
            string[] lesParams = { "identification", tb_identification.Text,
                                   "motdepasse", tb_motdepasse.Text };

            // conversion json
            string json = methods.generateJson(lesParams);
            
            // on recupere data
            var data = methods.postRequest(url, json);

            // si connecte
            if (data["user_info"] != null)
            {
                /*
                // msg valid
                MessageBox.Show(data["valid"][0].ToString(), "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                */
                
                // ouvrir index
                this.Hide();
                Index index = new Index();
                index.Show();
            } else {
                // msg erreur
                MessageBox.Show(data["erreur"][0].ToString(), "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}