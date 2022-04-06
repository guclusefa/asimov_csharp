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
    public partial class Index : Form
    {
        // importation des methods
        Methods methods = new Methods();

        public Index()
        {
            InitializeComponent();

            // recuperer data user
            string url = "/";
            var data = methods.getRequest(url);
            label_nomUser.Text = data["user_info"]["user_prenom"].ToString() + " " + data["user_info"]["user_nom"].ToString();
        }

        private void btn_deconnexion_Click(object sender, EventArgs e)
        {
            // requete deconnexion
            string url = "/deconnexion";
            var data = methods.getRequest(url);

            // si valid
            if (data["valid"] != null)
            {
                MessageBox.Show(data["valid"][0].ToString());
            } else {
                MessageBox.Show(data["erreur"][0].ToString());
            }
            
            // revenir page de connexion
            this.Hide();
            Connexion connexion = new Connexion();
            connexion.Show();
        }

        private void btn_matieres_Click(object sender, EventArgs e)
        {
            // hide this and open lesMatieres
            this.Hide();
            LesMatieres lesMatieres = new LesMatieres();
            lesMatieres.Show();
        }
    }
}
