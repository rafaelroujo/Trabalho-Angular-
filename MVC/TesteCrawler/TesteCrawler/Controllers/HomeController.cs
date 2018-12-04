using System;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Web.Mvc;

namespace TesteCrawler.Controllers
{
    public class HomeController : Controller
    {

        //setar apenas uma booleana, correspondente a tarefa a ser executada no firebase
        //no update acessar o breakponit e mudar o texto no campo ao lado do breakponit
        string result = "";
        public ActionResult Index()
        {
            bool post = true,
                read = false,
                update = false,
                delete = false;


            #region area de testes

            if (post)
                PostFb();
            if (read)
                ReadFb();
            if (update)
            {
                ReadFb();
                UpdateFb();
            }
            if (delete)
            {
                ReadFb();
                DeleteFb();
            }
            #endregion



            ViewBag.Message = result;

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        #region TestesFirebase
        bool auth = false,
        testes = false,
        mensagens = true;
        string authKey = "AIzaSyCW_ALAwO-r-E5kxM4rlemCaKfh_7YN9sE",
            TxbKey = "",
            TxbValor = "Feito pelo C# MVC";

        //string firebaseLink = "https://teste-aula-1c847.firebaseio.com/";

        string firebaseLink = "https://fabulosas-16e68.firebaseio.com/";

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
            result = $"chave: {words[3]}";
            ViewBag.Message = result;

        }
        private void ReadFb()
        {

            var request = WebRequest.CreateHttp($"{firebaseLink}");
            if (!auth)
            {
                if (TxbKey != "")
                    request = WebRequest.CreateHttp($"{firebaseLink}{TxbKey}.json");
                else
                    request = WebRequest.CreateHttp($"{firebaseLink}.json");
            }
            else
            {
                if (TxbKey != "")
                    request = WebRequest.CreateHttp($"{firebaseLink}{TxbKey}.json?auth={authKey}");
                else
                    request = WebRequest.CreateHttp($"{firebaseLink}.json?auth={authKey}");
            }
            var Response = (HttpWebResponse)request.GetResponse();
            var StreamReader = new StreamReader(Response.GetResponseStream()).ReadToEnd();
            string[] words = StreamReader.Split('"');

            if (TxbKey != "")
            {
                result = $"chave:{TxbKey}\n" +
                    $"{words[1]} : {words[3]}\n" +
                    $"{words[5]} : {words[7]}\n";
            }
            else
            {
                for (int i = 1, length = words.Length; i < length; i++)
                {
                    result = $"chave:{words[i]}\n" +
                        $"{words[i + 2]} : {words[i + 4]}\n" +
                        $"{words[i + 6]} : {words[i + 8]}\n";
                    TxbKey = words[i];
                    i = i + 9;
                }
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
                if (TxbKey != "")
                    request = WebRequest.CreateHttp($"{firebaseLink}{TxbKey}.json");
                else
                    request = WebRequest.CreateHttp($"{firebaseLink}.json");
            }
            else
            {
                if (TxbKey != "")
                    request = WebRequest.CreateHttp($"{firebaseLink}{TxbKey}.json?auth={authKey}");
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
                result = $"chave:{TxbKey}\n" +
                    $"{words[1]} : {words[3]}\n" +
                    $"{words[5]} : {words[7]}\n";
            }
        }
        private void DeleteFb()
        {

            var request = WebRequest.CreateHttp($"{firebaseLink}");

            if (!auth)
            {
                if (TxbKey != "")
                    request = WebRequest.CreateHttp($"{firebaseLink}{TxbKey}.json");
                else
                    request = WebRequest.CreateHttp($"{firebaseLink}.json");
            }
            else
            {
                if (TxbKey != "")
                    request = WebRequest.CreateHttp($"{firebaseLink}{TxbKey}.json?auth={authKey}");
                else
                    request = WebRequest.CreateHttp($"{firebaseLink}.json?auth={authKey}");
            }
            request.Method = "DELETE";
            request.ContentType = "application/json";
            var response = request.GetResponse();


            result = $"WELL DONE ({TxbKey})";
        }
        private string JsonConf(string json, string time)
        {
            json = Newtonsoft.Json.JsonConvert.SerializeObject(new
            {
                Valor = TxbValor,
                Hora = time,

            });
            return json;
        }
        #endregion
    }
}