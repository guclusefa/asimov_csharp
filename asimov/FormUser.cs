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

        public static JObject data;

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

                // les params
                if (typeForm == "RES")
                {
                    typeData = "unResponsable";
                    urlData = "/responsables/modifier/" + id;
                    titleForm = "Modifier un responsable";
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

                if (typeForm == "RES")
                {
                    titleForm = "Ajouter un responsable";
                }
                actionForm = "Ajouter";
            }
            
            // les labels
            this.Text = titleForm;
            label1.Text = titleForm;
            btn_valider.Text = actionForm;





            // e5
            data = methods.getRequest("/responsables/liste/");

            // remplir les datalist
            methods.initResponsable(cb_resp1, data["lesResponsables"]);
            methods.initResponsable(cb_resp2, data["lesResponsables"]);

            // cacher si responsable
            if (user_type == "RES")
            {
                cb_resp1.Visible = false;
                cb_resp2.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
            }
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

                    // si eleve on rajoute les params des resp
                    lesParams = lesParams.Concat(new string[] { "resp1", (cb_resp1.SelectedItem as dynamic).Value.ToString() }).ToArray();
                    lesParams = lesParams.Concat(new string[] { "resp2", (cb_resp2.SelectedItem as dynamic).Value.ToString() }).ToArray();
                } else
                {
                    url = "/profs/ajouter";
                }

                if (user_type == "RES")
                {
                    url = "/responsables/ajouter";
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

                if (user_type == "RES")
                {
                    url = "/responsables/modifier/" + id;
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
