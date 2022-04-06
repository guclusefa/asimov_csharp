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
        public Index()
        {
            InitializeComponent();
            Methods methods = new Methods();
            string url = "/";
            var data = methods.getRequest(url);
            label_nomUser.Text = data["user_info"]["user_prenom"].ToString() + " " + data["user_info"]["user_nom"].ToString();
        }

        private void btn_deconnexion_Click(object sender, EventArgs e)
        {
            // importation des methods
            Methods methods = new Methods();

            // requete get
            string url = "/deconnexion";
            var data = methods.getRequest(url);
            if (data["valid"] != null)
            {
                // msg valid
                MessageBox.Show(data["valid"][0].ToString());
            } else {
                // msg erreur
                MessageBox.Show(data["erreur"][0].ToString());
            }
            
            // revenir page de connexion
            this.Hide();
            Connexion connexion = new Connexion();
            connexion.Show();
        }
    }
}
