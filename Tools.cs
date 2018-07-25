using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace NexioPaySample
{
    public static class Tools
    {
        private static String ConfigFile = "";

        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        public static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }


        public static void ReadConfig()
        {
            //API_URL
            PaymentService.API_URL = GetConfig("API_URL");
            //Username
            BasicAuth.username = GetConfig("USERNAME");
            //Password
            BasicAuth.password = GetConfig("PASSWORD");

            //MERCHANT_ID
            PaymentService.Merchantid = GetConfig("MERCHANT_ID");

            //TOKENEX_TOKEN
            PaymentService.Tokenex_token = GetConfig("TOKENEX_TOKEN");

        }

        //read Config.xml to get settings
        private static String GetConfig(String Node)
        {
            XmlDocument xml = new XmlDocument();

            String FilePath = @"./config.xml";

            //open file first
            try
            {
                xml.Load(FilePath);
            }
            catch (Exception e)
            {
                Console.WriteLine("Open config.xml get exception: " + e.Message);
                return "ERR";
            }

            //continue 
            XmlNode RootNode = xml.SelectSingleNode("Nexio");//get root node
            XmlNodeList Nodelist = RootNode.ChildNodes;//get all child nodes
            foreach (XmlNode xn in Nodelist)
            {
                if (xn.Name.Equals(Node))
                {

                    return xn.InnerText;
                }
            }

            return "";
        }

        //Set service config xml values
        public static void UpdateServiceConfigXml(String key, String value)
        {
            XmlDocument xmlDoc = new XmlDocument();

            try
            {
                xmlDoc.Load(ConfigFile);//loading config xml file
            }
            catch (Exception e)
            {
                Console.WriteLine("Open config.xml get exception: " + e.Message);
            }

            XmlNode xns = xmlDoc.SelectSingleNode("Nexio");//get root node
            XmlNodeList xnl = xns.ChildNodes;//get all child nodes
            foreach (XmlNode xn in xnl)
            {
                switch (xn.Name)
                {
                    case "API_URL":
                    case "USERNAME":
                    case "PASSWORD":
                    case "JWT":
                    case "MERCHANT_ID":
                    case "GATEWAY_NAME":
                    case "TOKENEX_TOKEN":
                    case "TRANSACTION_REF_NUMBER":
                        if (xn.Name.Equals(key))
                        {
                            xn.InnerText = value;
                            xmlDoc.Save(ConfigFile);
                        }

                        break;
                    default:
                        Console.WriteLine("Key " + xn.Name + " is not supported in config.xml");
                        break;
                }
            }

        }

        public static String SendRequest(string method, string url, string postData, Boolean AuthorizationFlag, String basicauth)
        {
            Console.WriteLine("Begin sending request to Nexio server...");
            try
            {
                HttpWebRequest request = null;
                if (url.StartsWith("https", StringComparison.OrdinalIgnoreCase))
                {
                    request = WebRequest.Create(url) as HttpWebRequest;
                    ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(CheckValidationResult);
                    request.ProtocolVersion = HttpVersion.Version11;
                    //Here set protocol
                    ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;// SecurityProtocolType.Tls1.2; 
                    request.KeepAlive = false;
                    ServicePointManager.CheckCertificateRevocationList = true;
                    ServicePointManager.DefaultConnectionLimit = 100;
                    ServicePointManager.Expect100Continue = false;
                }
                else
                {
                    request = (HttpWebRequest)WebRequest.Create(url);
                }

                switch (method.ToUpper())
                {
                    case "POST":
                        request.Method = "POST";
                        break;
                    case "PUT":
                        request.Method = "PUT";
                        break;
                    case "GET":
                        request.Method = "GET";
                        break;
                    case "DELETE":
                        request.Method = "DELETE";
                        break;
                    default:
                        request.Method = "POST";
                        break;
                }


                request.ContentType = "application/json";
                request.Referer = null;

                if (AuthorizationFlag)
                    request.Headers["Authorization"] = basicauth;

                request.AllowAutoRedirect = true;
                //request.UserAgent = "Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 5.2; .NET CLR 1.1.4322; .NET CLR 2.0.50727)";
                request.Accept = "*/*";

                byte[] data = null;

                //only send data when method is POST or PUT
                if (!method.ToUpper().Equals("GET") && !method.ToUpper().Equals("DELETE"))
                    data = Encoding.UTF8.GetBytes(postData);



                //only send data when method is POST or PUT
                if (!method.ToUpper().Equals("GET") && !method.ToUpper().Equals("DELETE"))
                {
                    Stream newStream = request.GetRequestStream();
                    newStream.Write(data, 0, data.Length);
                    newStream.Close();
                }


                //get response of webpage
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream stream = response.GetResponseStream();
                //client.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
                string result = string.Empty;
                using (StreamReader sr = new StreamReader(stream))
                {
                    result = sr.ReadToEnd();
                }

                return result;
            }
            catch (Exception e)
            {
                //Winlog.WriteErrorLog("PostURL get exception: " + e.Message);
                throw e;
            }

        }

        private static bool CheckValidationResult(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
        {
            //todo need your own certficate validate code here;
            Console.WriteLine("skip certificate validation step, just return true");
            return true;
        }

    }
}
