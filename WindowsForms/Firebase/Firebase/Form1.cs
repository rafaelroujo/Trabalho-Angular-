using System;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace Firebase
{
    public partial class Form1 : Form
    {
        bool auth = false,
            testes = false,
            mensagens = false;
        string authKey = "AIzaSyCW_ALAwO-r-E5kxM4rlemCaKfh_7YN9sE";

        //string firebaseLink = "https://teste-aula-1c847.firebaseio.com/";

        string firebaseLink = "https://fabulosas-16e68.firebaseio.com/";

        public Form1()
        {
            InitializeComponent();
        }


        private void BrnCreate_Click(object sender, EventArgs e)
        {
            PostFb();
        }

        private void BrnRead_Click(object sender, EventArgs e)
        {
            ReadFb();
        }

        private void BrnUpdate_Click(object sender, EventArgs e)
        {
            UpdateFb();
        }

        private void BrnDelete_Click(object sender, EventArgs e)
        {
            DeleteFb();
        }

        private void cbxChaves_SelectedIndexChanged(object sender, EventArgs e)
        {
            TxbValor.Text = "";
            TxbKey.Text = cbxChaves.Text;
        }

        private void PostFb()
        {
            DateTime date = DateTime.Now;
            string Date = date.ToString("yyyy:MM:dd");
            string time = date.ToString("HH:mm:ss");


            var json = Newtonsoft.Json.JsonConvert.SerializeObject(new
            {
                Name = time,
                Value = date,

            });
            if (!testes)
            {
                json = JsonConf(json, time);
            }

            var request = WebRequest.CreateHttp($"{firebaseLink}");

            if (!auth)
            {
                request = WebRequest.CreateHttp($"{firebaseLink}.json");
            }
            else
            {
                request = WebRequest.CreateHttp($"{firebaseLink}.json?auth={authKey}");
            }

            request.Method = "POST";
            request.ContentType = "application/json";
            var buffer = Encoding.UTF8.GetBytes(json);
            request.ContentLength = buffer.Length;
            request.GetRequestStream().Write(buffer, 0, buffer.Length);
            var response = request.GetResponse();
            json = (new StreamReader(response.GetResponseStream())).ReadToEnd();
            string[] words = json.Split('"');

            TxbKey.Text = "";

            cbxChaves.Items.Add(words[3]);
            if (mensagens)
                MessageBox.Show($"chave: {words[3]}");

            MessageBox.Show("Feito!!!");
        }
        private void ReadFb()
        {

            var request = WebRequest.CreateHttp($"{firebaseLink}");
            if (!auth)
            {
                if (TxbKey.Text != "")
                    request = WebRequest.CreateHttp($"{firebaseLink}{TxbKey.Text}.json");
                else
                    request = WebRequest.CreateHttp($"{firebaseLink}.json");
            }
            else
            {
                if (TxbKey.Text != "")
                    request = WebRequest.CreateHttp($"{firebaseLink}{TxbKey.Text}.json?auth={authKey}");
                else
                    request = WebRequest.CreateHttp($"{firebaseLink}.json?auth={authKey}");
            }
            var Response = (HttpWebResponse)request.GetResponse();
            var StreamReader = new StreamReader(Response.GetResponseStream()).ReadToEnd();
            string[] words = StreamReader.Split('"');

            if (TxbKey.Text != "")
            {
                MessageBox.Show($"chave:{TxbKey.Text}\n" +
                    $"{words[1]} : {words[3]}\n" +
                    $"{words[5]} : {words[7]}\n");

                TxbValor.Text = words[7];


            }
            else
            {
                cbxChaves.Items.Clear();

                for (int i = 1, length = words.Length; i < length; i++)
                {
                    cbxChaves.Items.Add(words[i]);
                    if (mensagens)
                        MessageBox.Show($"chave:{words[i]}\n" +
                        $"{words[i + 2]} : {words[i + 4]}\n" +
                        $"{words[i + 6]} : {words[i + 8]}\n");

                    i = i + 9;
                }

                MessageBox.Show("Feito!!!");
            }
        }
        private void UpdateFb()
        {
            DateTime date = DateTime.Now;
            string Date = date.ToString("yyyy:MM:dd");
            string time = date.ToString("HH:mm:ss");

            var json = Newtonsoft.Json.JsonConvert.SerializeObject(new
            {
                Name = time,
                Value = date,

            });
            if (!testes)
            {
                json = JsonConf(json, time);
            }

            var request = WebRequest.CreateHttp($"{firebaseLink}");

            if (!auth)
            {
                if (TxbKey.Text != "")
                    request = WebRequest.CreateHttp($"{firebaseLink}{TxbKey.Text}.json");
                else
                    request = WebRequest.CreateHttp($"{firebaseLink}.json");
            }
            else
            {
                if (TxbKey.Text != "")
                    request = WebRequest.CreateHttp($"{firebaseLink}{TxbKey.Text}.json?auth={authKey}");
                else
                    request = WebRequest.CreateHttp($"{firebaseLink}.json?auth={authKey}");
            }
            request.Method = "PATCH";
            request.ContentType = "application/json";
            var buffer = Encoding.UTF8.GetBytes(json);
            request.ContentLength = buffer.Length;
            request.GetRequestStream().Write(buffer, 0, buffer.Length);
            var response = request.GetResponse();
            json = (new StreamReader(response.GetResponseStream())).ReadToEnd();

            if (mensagens)
            {
                string[] words = json.Split('"');
                MessageBox.Show($"chave:{TxbKey.Text}\n" +
                    $"{words[1]} : {words[3]}\n" +
                    $"{words[5]} : {words[7]}\n");
            }
            MessageBox.Show("Atualizado!!!");
        }
        private void DeleteFb()
        {

            var request = WebRequest.CreateHttp($"{firebaseLink}");

            if (!auth)
            {
                if (TxbKey.Text != "")
                    request = WebRequest.CreateHttp($"{firebaseLink}{TxbKey.Text}.json");
                else
                    request = WebRequest.CreateHttp($"{firebaseLink}.json");
            }
            else
            {
                if (TxbKey.Text != "")
                    request = WebRequest.CreateHttp($"{firebaseLink}{TxbKey.Text}.json?auth={authKey}");
                else
                    request = WebRequest.CreateHttp($"{firebaseLink}.json?auth={authKey}");
            }
            request.Method = "DELETE";
            request.ContentType = "application/json";
            var response = request.GetResponse();

            cbxChaves.Items.Remove(cbxChaves.Text);
            TxbKey.Text = "";
            cbxChaves.Text = "";
            TxbValor.Text = "";

            MessageBox.Show("OK");

        }
        private string JsonConf(string json, string time)
        {
            json = Newtonsoft.Json.JsonConvert.SerializeObject(new
            {
                Valor = TxbValor.Text,
                Hora = time,

            });
            return json;
        }
    }
}
