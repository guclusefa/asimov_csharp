using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace asimov
{
    internal class Methods
    {
        // host & cookie
        public static string host = "http://localhost:8080";
        public static CookieContainer cookieContainer = new CookieContainer();

        // post request
        public JObject postRequest(string url, string json)
        {
            try
            {
                string api = host + url;
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(api);
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "POST";
                httpWebRequest.CookieContainer = cookieContainer;

                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    streamWriter.Write(json);
                    streamWriter.Flush();
                    streamWriter.Close();
                }

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    var data = (JObject)JsonConvert.DeserializeObject<dynamic>(result);
                    return data;
                }
            }
            catch
            {
                MessageBox.Show("Une erreur est survenue lors de la récupération des données, veuillez réessayer plus tard.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // end application
                Environment.Exit(0);

                return null;
            }
        }

        // make get request
        public JObject getRequest(string url)
        {
            try
            {
                string api = host + url;
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(api);
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "GET";
                httpWebRequest.CookieContainer = cookieContainer;

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    var data = (JObject)JsonConvert.DeserializeObject<dynamic>(result);
                    return data;
                }
            }
            catch
            {
                MessageBox.Show("Une erreur est survenue lors de la récupération des données, veuillez réessayer plus tard.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // end application
                Environment.Exit(0);

                return null;
            }
        }

        // open form
        public void openForm(string url, Form form, Form formAOuvrir)
        {
            // requete
            var data = getRequest(url);

            // si valid
            if (string.Equals(data["erreur"].ToString(), "[]"))
            {
                // hide this and open lesMatieres
                form.Hide();
                formAOuvrir.Show();
            }

            /*
            else
            {
                MessageBox.Show(data["erreur"][0].ToString(), "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            */
        }

        // revenir index
        public void revenirIndex(Form form)
        {
            // revnir index
            form.Hide();
            Index index = new Index();
            index.Show();
        }

        // search in datagrid
        public void searchDataGrid(DataGridView dgv, TextBox tb_search)
        {
            // filter in grid
            dgv.CurrentCell = null;
            foreach (DataGridViewRow r in dgv.Rows)
            {
                r.Visible = false;
            }
            foreach (DataGridViewRow r in dgv.Rows)
            {
                foreach (DataGridViewCell c in r.Cells)
                {
                    if ((c.Value.ToString().ToUpper()).IndexOf(tb_search.Text.ToUpper()) == 0)
                    {
                        r.Visible = true;
                        break;
                    }
                }
            }
            // if filtered row count 0
            if (dgv.Rows.GetRowCount(DataGridViewElementStates.Visible) == 0)
            {
                // create label
                Label l = new Label();
                l.Text = "Aucun résultat";
                l.AutoSize = true;
                l.Font = new Font("Segoe UI", 12);
                // no background color
                l.BackColor = Color.Transparent;
                // lable in middle of dategrid
                l.Location = new Point((dgv.Width / 2) - (l.Width / 2), (dgv.Height / 2) - (l.Height / 2));
                // label to front
                dgv.Controls.Add(l);
            }
            else
            {
                // label visible false
                foreach (Control c in dgv.Controls)
                {
                    if (c is Label)
                    {
                        c.Visible = false;
                    }
                }
            }
        }


        // ######################################### DEBUT CRUD #####################################################################################

        // remplir datagridview --------------------------------------------------------------------------
        public void fillDataGrid(DataGridView dgv, string url, string type)
        {
            // requete 
            var data = getRequest(url);

            // si autorisé a lister
            if (string.Equals(data["erreur"].ToString(), "[]"))
            {
                // clear tableau
                dgv.Rows.Clear();
                dgv.Refresh();

                // delete all collums
                dgv.Columns.Clear();

                // dgv format
                dataGridFormat(dgv, data, type);
            }
            else
            {
                MessageBox.Show(data["erreur"][0].ToString(), "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // dataGrid format
        public void dataGridFormat(DataGridView dgv, JObject data, string type)
        {
            // si matiere
            if (type == "MAT")
            {
                // ajout des colonnes
                dgv.Columns.Add("id", "#");
                dgv.Columns.Add("libelle", "Libellé");

                // affichage des data dans le tableau
                foreach (var item in data["lesMatieres"])
                {
                    dgv.Rows.Add(item["matiere_id"], item["matiere_libelle"]);
                }
            }

            // si eleve
            if (type == "ELE" || type == "PRO")
            {
                // ajout des colonnes
                dgv.Columns.Add("id", "#");
                dgv.Columns.Add("nom", "NOM");
                dgv.Columns.Add("sexe", "Sexe");
                dgv.Columns.Add("tel", "Tel");
                dgv.Columns.Add("mail", "Mail");

                // si lesEleves ou lesProfs
                string typeuser = "lesEleves";
                if (type == "PRO")
                {
                    typeuser = "lesProfs";
                }

                // affichage des data dans le tableau
                foreach (var item in data[typeuser])
                {
                    dgv.Rows.Add(item["user_id"], item["user_nom"] + " " + item["user_prenom"] + " (" + item["user_age"] + "ans)", item["user_sexe"], item["user_tel"], item["user_mail"]);
                }

                // hide id column
                dgv.Columns["id"].Visible = false;
            }

            // si classes
            if (type == "CLA")
            {
                // ajout des colonnes
                dgv.Columns.Add("id", "#");
                dgv.Columns.Add("annee", "Année Sscolaire");
                dgv.Columns.Add("classe", "Classe");
                dgv.Columns.Add("libelle", "Libellé");
                dgv.Columns.Add("principal", "Prof. Principal");

                // affichage des data dans le tableau
                foreach (var item in data["lesClasses"])
                {
                    dgv.Rows.Add(item["cursus_id"], item["cursus_anneeScolaire"], item["classe_libelle"], item["cursus_libelle"], item["user_nom"] + " " + item["user_prenom"]);
                }
            }
        }



        // afficher detail --------------------------------------------------------------------------
        public void showDetail(string route, DataGridView dgv, string type)
        {
            // url en fonction route
            string url = route + "/fiche/";

            if (dgv.SelectedRows.Count != 0)
            {
                // recupere id selectionné
                DataGridViewRow row = dgv.SelectedRows[0];

                // requete des matieres
                url = url + row.Cells["id"].Value.ToString();
                var data = getRequest(url);

                // si autorisé a detailer
                if (string.Equals(data["erreur"].ToString(), "[]"))
                {
                    // detail format
                    string detail = detailFormat(data, type);

                    // affichage
                    MessageBox.Show(detail, "Détail", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(data["erreur"][0].ToString(), "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Veuillez selectionner une ligne", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        // detail format
        public string detailFormat(JObject data, string type)
        {
            // initilisation
            string detail = "";

            // si matiere
            if (type == "MAT")
            {
                // les détails
                detail = "id : " + data["uneMatiere"]["matiere_id"].ToString();
                detail += "\nLibellé : " + data["uneMatiere"]["matiere_libelle"].ToString();
            }

            // si eleves
            if (type == "ELE" || type == "PRO")
            {
                // si eleve ou prof
                string typeuser = "unEleve";
                if (type == "PRO")
                {
                    typeuser = "unProf";
                }
                // les détails
                detail = "id : " + data[typeuser]["user_id"].ToString();
                detail += "\nNOM : " + data[typeuser]["user_nom"].ToString();
                detail += "\nPrénom : " + data[typeuser]["user_prenom"].ToString();
                detail += "\nDate de naissance : " + data[typeuser]["user_dateNaissance"].ToString() + " (" + data[typeuser]["user_age"].ToString() + "ans)";
                detail += "\nTél : " + data[typeuser]["user_tel"].ToString();
                detail += "\nEmail : " + data[typeuser]["user_mail"].ToString();
            }

            // si classe
            if (type == "CLA")
            {
                // les détails
                detail = "id : " + data["uneClasse"]["cursus_id"].ToString();
                detail += "\nAnnée Scolaire : " + data["uneClasse"]["cursus_anneeScolaire"].ToString();
                detail += "\nClasse : " + data["uneClasse"]["classe_libelle"].ToString();
                detail += "\nLibellé : " + data["uneClasse"]["cursus_libelle"].ToString();
                detail += "\nProfesseur principal : " + data["uneClasse"]["user_nom"].ToString() + " " + data["uneClasse"]["user_prenom"].ToString();

                // count lesElevesClasse
                detail += "\n\nLes élèves : " + countArray(data["lesElevesClasse"]);

                // les eleves
                foreach (var item in data["lesElevesClasse"])
                {
                    detail += "\n" + item["user_nom"].ToString() + " " + item["user_prenom"].ToString();
                }

                // count lesElevesClasse
                detail += "\n\nLes professeurs : " + countArray(data["lesProfsClasse"]);

                // les profs
                foreach (var item in data["lesProfsClasse"])
                {
                    detail += "\n" + item["user_nom"].ToString() + " " + item["user_prenom"].ToString() + " (" + item["matiere_libelle"] + ")";
                }

            }

            // retourner detail
            return detail;
        }



        // afficher ajouter --------------------------------------------------------------------------
        public void showAdd(string route, DataGridView dgv, string type)
        {
            // url en fonction route
            string url = route + "/ajouter";

            // request
            var data = getRequest(url);

            // si autorisé a ajouter
            if (string.Equals(data["erreur"].ToString(), "[]"))
            {
                // ouvrir form en fonction type
                formatAdd(type);

                // refresh
                fillDataGrid(dgv, route + "/liste", type);
            }
            else
            {
                MessageBox.Show(data["erreur"][0].ToString(), "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ajouter format
        public void formatAdd(string type)
        {
            // si matieres
            if (type == "MAT")
            {
                FormMatiere form = new FormMatiere(0, "0");
                form.ShowDialog();
            }

            // si eleves
            if (type == "ELE")
            {
                FormUser form = new FormUser(0, "0", "ELE");
                form.ShowDialog();
            }

            // si profs
            if (type == "PRO")
            {
                FormUser form = new FormUser(0, "0", "PRO");
                form.ShowDialog();
            }


            // si classe
            if (type == "CLA")
            {
                FormClasse form = new FormClasse(0, "0");
                form.ShowDialog();
            }
        }



        // afficher modifier --------------------------------------------------------------------------
        public void showModify(string route, DataGridView dgv, string type)
        {
            // url en fonction route
            string url = route + "/modifier/";

            if (dgv.SelectedRows.Count != 0)
            {
                // recupere id selectionné
                DataGridViewRow row = dgv.SelectedRows[0];

                // requete des matieres
                url = url + row.Cells["id"].Value.ToString();
                var data = getRequest(url);

                // si autorisé a modifier
                if (string.Equals(data["erreur"].ToString(), "[]"))
                {
                    // ouvrir form modifier
                    formatModify(type, row);

                    // refresh
                    fillDataGrid(dgv, route + "/liste", type);
                }
                else
                {
                    MessageBox.Show(data["erreur"][0].ToString(), "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Veuillez selectionner une ligne", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // modifier format
        public void formatModify(string type, DataGridViewRow row)
        {
            // si matieres
            if (type == "MAT")
            {
                FormMatiere form = new FormMatiere(1, row.Cells["id"].Value.ToString());
                form.ShowDialog();
            }
            // si eleves
            if (type == "ELE")
            {
                FormUser form = new FormUser(1, row.Cells["id"].Value.ToString(), "ELE");
                form.ShowDialog();
            }

            // si profs
            if (type == "PRO")
            {
                FormUser form = new FormUser(1, row.Cells["id"].Value.ToString(), "PRO");
                form.ShowDialog();
            }

            // si classes
            if (type == "CLA")
            {
                FormClasse form = new FormClasse(1, row.Cells["id"].Value.ToString());
                form.ShowDialog();
            }

        }


        // suppirmer --------------------------------------------------------------------------
        public void delete(string route, DataGridView dgv, string type)
        {
            // url en fonction route
            string url = route + "/supprimer/";

            // si ligne choisie
            if (dgv.SelectedRows.Count != 0)
            {
                // confirmations
                var confirmResult = MessageBox.Show("Êtes-vous sûr de supprimer " + dgv.SelectedRows.Count.ToString() + " ligne(s) ?",
                    "Confirmation",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);


                // si supprimer
                if (confirmResult == DialogResult.Yes)
                {
                    int i = 0;
                    // les requetes de delete
                    foreach (DataGridViewRow r in dgv.SelectedRows)
                    {
                        // requete get
                        string urlDelete;

                        urlDelete = url + r.Cells["id"].Value.ToString();
                        var data = getRequest(urlDelete);
                        // si erreur lors supp
                        if (!string.Equals(data["erreur"].ToString(), "[]"))
                        {
                            MessageBox.Show(data["erreur"][0].ToString(), "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            i++;
                        }
                    }

                    // msg succès avec le total de supp avec succès
                    MessageBox.Show("Supprimé " + (dgv.SelectedRows.Count - i).ToString() + " ligne(s) avec succès", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // refresh
                    fillDataGrid(dgv, route + "/liste", type);
                }
            }
            else
            {
                MessageBox.Show("Veuillez selectionner une ligne", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // valider formulaire --------------------------------------------------------------------------
        public void validate(string url, string json, Form form)
        {
            // on recupere data
            var data = postRequest(url, json);

            // si pas d'erreur
            if (string.Equals(data["erreur"].ToString(), "[]"))
            {
                MessageBox.Show(data["valid"][0].ToString(), "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                form.Close();
            }
            else
            {
                MessageBox.Show(data["erreur"][0].ToString(), "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // generate json from string array
        public string generateJson(string[] data)
        {
            // initilisation
            string json = "{";

            // boucle
            for (int i = 0; i < data.Length; i++)
            {
                // si c un array on met pas less '"'
                if (data[i+1].StartsWith("["))
                {
                    json += "\"" + data[i] + "\"" + ":" + data[i + 1] + ",";
                }
                else
                {
                    json += "\"" + data[i] + "\"" + ":" + "\"" + data[i + 1] + "\",";
                }

                i++;

                // erase last comma
                if (i == data.Length - 1)
                {
                    json = json.Remove(json.Length - 1);
                }
            }

            // fermeture
            json += "}";

            // retourner json
            return json;
        }

        // ######################################### FIN CRUD #####################################################################################

        // init combobox sexer
        public void initSexe(ComboBox cb)
        {
            // init sexe
            cb.DisplayMember = "Text";
            cb.ValueMember = "Value";

            cb.Items.Clear();
            cb.Items.Add(new { Text = "Choisir un sexe", Value = "" });
            cb.Items.Add(new { Text = "Masculin", Value = "M" });
            cb.Items.Add(new { Text = "Féminin", Value = "F" });
            cb.SelectedIndex = 0;
        }


        // init combobox classes
        public void initClasses(ComboBox cb, JToken data)
        {
            // init classe
            cb.DisplayMember = "Text";
            cb.ValueMember = "Value";

            cb.Items.Clear();
            cb.Items.Add(new { Text = "Choisir une classe", Value = "" });

            // for each data
            foreach (var item in data)
            {
                cb.Items.Add(new { Text = item["classe_libelle"].ToString(), Value = item["classe_id"].ToString() });
            }

            // selection 1er
            cb.SelectedIndex = 0;
        }

        // init combobox profs
        public void initProfsPrincipal(ComboBox cb, JToken data)
        {
            // init classe
            cb.DisplayMember = "Text";
            cb.ValueMember = "Value";

            cb.Items.Clear();
            cb.Items.Add(new { Text = "Choisir un professeur principal", Value = "" });

            // for each data
            foreach (var item in data)
            {
                cb.Items.Add(new { Text = item["user_nom"].ToString() + " " + item["user_prenom"].ToString(), Value = item["user_id"].ToString() });
            }

            // selection 1er
            cb.SelectedIndex = 0;
        }

        // add combo box to panel
        public void addLesMatieres(Panel p, JToken data, JToken dataProfs)
        {
            // init
            int i = 0;
            int x = 10;
            int y = 10;
            // width
            int w = 337 - 25;
            // height
            int h = 30;
            // font
            Font font = new Font("Segoe UI", 12);
            // drop down style
            ComboBoxStyle style = ComboBoxStyle.DropDownList;
            //width 
            int dropDownWidth = 200;
            // height
            int dropDownHeight = 337;
            // margin bottom
            int marginBottom = 20;

            // for each data
            foreach (var item in data)
            {
                // init
                ComboBox cb = new ComboBox();
                cb.Name = "cb_matiere"+ item["matiere_id"].ToString();
                cb.Location = new Point(x, y);
                cb.Font = font;
                cb.DropDownStyle = style;
                cb.DropDownWidth = dropDownWidth;
                cb.DropDownHeight = dropDownHeight;
                // width
                cb.Width = w;
                // height
                cb.Height = h;
                // margin bottom
                cb.Margin = new Padding(0, 0, 0, marginBottom);
                // full width
                cb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
                // add to form
                p.Controls.Add(cb);

                // init combobox
                initProfsMatieres(cb, item, dataProfs);

                // next
                i++;
            }

            // erase margin bottom from last combobox
            p.Controls[p.Controls.Count - 1].Margin = new Padding(0, 0, 0, 0);
        }

        // init combobox profs
        public void initProfsMatieres(ComboBox cb, JToken data, JToken dataProfs)
        {
            // init classe
            cb.DisplayMember = "Text";
            cb.ValueMember = "Value";

            cb.Items.Clear();
            cb.Items.Add(new { Text = "Choisir un professeur de " + data["matiere_libelle"], Value = "" });

            // for each data
            foreach (var item in dataProfs)
            {
                cb.Items.Add(new { Text = item["user_nom"].ToString() + " " + item["user_prenom"].ToString(), Value = item["user_id"].ToString()+", "+ data["matiere_id"].ToString() });
            }

            // selection 1er
            cb.SelectedIndex = 0;
        }

        // add combo box to panel
        public void addLesEleves(Panel p, JToken data)
        {
            // init
            int i = 0;
            int x = 10;
            int y = 10;
            // width
            int w = 337 - 25;
            // height
            int h = 30;
            // font
            Font font = new Font("Segoe UI", 12);
            // drop down style
            ComboBoxStyle style = ComboBoxStyle.DropDownList;
            //width 
            int dropDownWidth = 200;
            // height
            int dropDownHeight = 337;
            // margin bottom
            int marginBottom = 20;

                // init
                ComboBox cb = new ComboBox();
                cb.Name = "cb_eleve" + i.ToString();
                cb.Location = new Point(x, y);
                cb.Font = font;
                cb.DropDownStyle = style;
                cb.DropDownWidth = dropDownWidth;
                cb.DropDownHeight = dropDownHeight;
                // width
                cb.Width = w;
                // height
                cb.Height = h;
                // margin bottom
                cb.Margin = new Padding(0, 0, 0, marginBottom);
                // full width
                cb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
                // add to form
                p.Controls.Add(cb);

                // init combobox
                initEleves(cb, data);

                // next
                i++;
        }

        // delete combo box
        public void deleteComboBox(Panel p)
        {
            // for each control
            foreach (Control c in p.Controls)
            {
 

                // last combobox
                if (c is ComboBox && p.Controls.Count > 1)
                {
                    // remove
                    p.Controls.Remove(c);
                    // break
                    break;
                }
            }
        }


        // init les eleves
        public void initEleves(ComboBox cb, JToken data)
        {
            // init classe
            cb.DisplayMember = "Text";
            cb.ValueMember = "Value";

            cb.Items.Clear();
            cb.Items.Add(new { Text = "Choisir un élève", Value = "" });

            // for each data
            foreach (var item in data)
            {
                cb.Items.Add(new { Text = item["user_nom"].ToString() + " " + item["user_prenom"].ToString(), Value = item["user_id"].ToString() });
            }

            // selection 1er
            cb.SelectedIndex = 0;
        }


        // get values of all combo boxes of panel
        public string getValuesComboBox(Panel p)
        {
            // init
            string values = "[";
            // for each control
            foreach (Control c in p.Controls)
            {
                // if combobox
                if (c is ComboBox)
                {
                    // c as combobox
                    ComboBox cb = (ComboBox)c;
                    string v = (cb.SelectedItem as dynamic).Value.ToString();

                    // if trim of v not empty
                    if (v.Trim() != "")
                    {
                        // add to values    
                        values += '"' + v + '"' + ",";
                    }
                }
            }

            // if values not empty
            if (values.Trim() != "[")
            {
                // remove last ,
                values = values.Substring(0, values.Length - 1);
            }

            values += "]";

            // return
            return values;
        }

        // generate date time from yyyy
        public string generateDateTime(string yyyy)
        {
            // init
            string date = "";

            // if yyyy not empty
            if (yyyy.Trim() != "")
            {
                // init
                int y = Convert.ToInt32(yyyy);
                // format dd/mm/yyyy
                date = "01/01/" + y.ToString() + " 00:00:00";
            }

            // return
            return date;
        }

        // get select comboBox
        public void getSelect(ComboBox cb, string data)
        {
            foreach (var item in (cb.Items as dynamic))
            {
                // if item value is equal to data
                if (item.Value.ToString() == data)
                {
                    // select item
                    cb.SelectedItem = item;
                }
            }
        }

        // count array
        public int countArray(JToken data)
        {
            int i = 0;
            foreach (var item in data)
            {
                i++;
            }
            return i;
        }
    }
}
