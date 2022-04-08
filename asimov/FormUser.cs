using Newtonsoft.Json.Linq;
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
    public partial class FormUser : Form
    {
        // importation des methodes
        Methods methods = new Methods();

        // les params
        public static int modifier;
        public static string id;
        public static string user_type;

        public FormUser(int modifierForm, string idForm, string typeForm)
        {
            InitializeComponent();

            // initialisation des params
            modifier = modifierForm;
            id = idForm;
            user_type = typeForm;

            // init sexe
            methods.initSexe(cb_sexe);

            // si prof ou eleve
            string typeData;
            string urlData;
            string titleForm;
            string actionForm;

            // si modifier
            if (modifier == 1)
            {
                // les params
                if (typeForm == "ELE")
                {
                    typeData = "unEleve";
                    urlData = "/eleves/modifier/" + id;
                    titleForm = "Modifier un elève";
                } else
                {
                    typeData = "unProf";
                    urlData = "/profs/modifier/" + id;
                    titleForm = "Modifier un professeur";
                }
                actionForm = "Modifier";

                // mettre les values
                var data = methods.getRequest(urlData);
                tb_nom.Text = data[typeData]["user_nom"].ToString();
                tb_prenom.Text = data[typeData]["user_prenom"].ToString();
                tb_mail.Text = data[typeData]["user_mail"].ToString();
                tb_tel.Text = data[typeData]["user_tel"].ToString();

                // get select
                methods.getSelect(cb_sexe, data[typeData]["user_sexe"].ToString());

                // set date to data
                dtp_date.Value = DateTime.Parse(data[typeData]["user_dateNaissance"].ToString());
            } else
            {
                if (typeForm == "ELE")
                {
                    titleForm = "Ajouter un elève";
                }
                else
                {
                    titleForm = "Ajouter un professeur";
                }
                actionForm = "Ajouter";
            }
            // les labels
            this.Text = titleForm;
            label1.Text = titleForm;
            btn_valider.Text = actionForm;
        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            // les params
            string url;
            string[] lesParams = {
                    "nom", tb_nom.Text,
                    "prenom", tb_prenom.Text,
                    "mdp", dtp_date.Text,
                    "date", dtp_date.Text,
                    "sexe", (cb_sexe.SelectedItem as dynamic).Value.ToString(),
                    "tel", tb_tel.Text,
                    "email", tb_mail.Text
                };

            // si pour ajouter sinon pour ajouter
            if (modifier == 0)
            {
                if (user_type == "ELE")
                {
                    url = "/eleves/ajouter";
                } else
                {
                    url = "/profs/ajouter";
                }
            } else
            {
                if (user_type == "ELE")
                {
                    url = "/eleves/modifier/" + id;
                }
                else
                {
                    url = "/profs/modifier/" + id;
                }
                // add to lesParams
                lesParams = lesParams.Concat(new string[] { "id", id }).ToArray();
            }
            // json
            string json = methods.generateJson(lesParams);

            //requete ajouter
            methods.validate(url, json, this);
        }
    }
}
