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

        // make get request
        public JObject getRequest(string url)
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
            else
            {
                MessageBox.Show(data["erreur"][0].ToString(), "Erreur");
            }
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
        public void searchDataGrid(DataGridView dgv, TextBox tb_search) {
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
                l.Font = new Font("Arial", 12);
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


        // CRUD PAR TYPE --------------------------------------------------

        // remplir datagridview
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

                // si matiere
                if (type == "MAT")
                {
                    // affichage des data dans le tableau
                    foreach (var item in data["lesMatieres"])
                    {
                        dgv.Rows.Add(item["matiere_id"], item["matiere_libelle"]);
                    }
                }
            }
            else
            {
                MessageBox.Show(data["erreur"][0].ToString(), "Erreur");
            }
        }

        // afficher detail
        public void showDetail(string url, DataGridView dgv, string type)
        {
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
                    string detail = "";

                    if (type == "MAT")
                    {
                        // les détails
                        detail = "id : " + data["uneMatiere"]["matiere_id"].ToString();
                        detail += "\nLibellé : " + data["uneMatiere"]["matiere_libelle"].ToString();
                    }
                    // affichage
                    MessageBox.Show(detail, "Détail");
                }
                else
                {
                    MessageBox.Show(data["erreur"][0].ToString(), "Erreur");
                }
            }
            else
            {
                MessageBox.Show("Veuillez selectionner une ligne", "Erreur");
            }

        }        
        
        // afficher ajouter
        public void showAdd(string url, DataGridView dgv, string type)
        {
            // request
            var data = getRequest(url);

            // si autorisé a ajouter
            if (string.Equals(data["erreur"].ToString(), "[]"))
            {
                if (type == "MAT")
                {
                    // open ajouter matiere dialog
                    FormMatiere form = new FormMatiere(0, "0");
                    form.ShowDialog();
                    // refresh
                    fillDataGrid(dgv, "/matieres/liste", "MAT");
                }
            }
            else
            {
                MessageBox.Show(data["erreur"][0].ToString(), "Erreur");
            }
        }

        // afficher modifier
        public void showModify(string url, DataGridView dgv, string type)
        {
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
                    if (type == "MAT")
                    {
                        // open modifier matiere dialog
                        FormMatiere form = new FormMatiere(1, row.Cells["id"].Value.ToString());
                        form.ShowDialog();
                        // refresh
                        fillDataGrid(dgv, "/matieres/liste", "MAT");
                    }
                }
                else
                {
                    MessageBox.Show(data["erreur"][0].ToString(), "Erreur");
                }
            }
            else
            {
                MessageBox.Show("Veuillez selectionner une ligne", "Erreur");
            }
        }

        // suppirmer
        public void delete(string url, DataGridView dgv, string type)
        {
            // si ligne choisie
            if (dgv.SelectedRows.Count != 0)
            {
                // confirmations
                var confirmResult = MessageBox.Show("Êtes-vous sûr de supprimer " + dgv.SelectedRows.Count.ToString() + " ligne(s) ?",
                    "Confirmation",
                    MessageBoxButtons.YesNo);


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
                            MessageBox.Show(data["erreur"][0].ToString(), "Erreur");
                            i++;
                        }
                    }

                    // msg succès avec le total de supp avec succès
                    MessageBox.Show("Supprimé " + (dgv.SelectedRows.Count - i).ToString() + " ligne(s) avec succès", "Succès");

                    // refresh
                    if (type == "MAT")
                    {
                        // refresh
                        fillDataGrid(dgv, "/matieres/liste", "MAT");
                    }
                }
            }
            else
            {
                MessageBox.Show("Veuillez selectionner une ligne", "Erreur");
            }
        }

        // valider formulaire
        public void validate(string url, string json, Form form)
        {
            // on recupere data
            var data = postRequest(url, json);

            // si pas d'erreur
            if (string.Equals(data["erreur"].ToString(), "[]"))
            {
                MessageBox.Show(data["valid"][0].ToString(), "Succès");
                form.Close();
            }
            else
            {
                MessageBox.Show(data["erreur"][0].ToString(), "Erreur");
            }
        }
    }
}
