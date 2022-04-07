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
    }
}
