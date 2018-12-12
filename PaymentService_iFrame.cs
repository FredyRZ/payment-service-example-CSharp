using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace NexioPaySample
{
    class PaymentService_iFrame
    {
        
        public static String GetOneTimeToken(String postData)
        {
            try
            {
                string url = ConfigItems.API_URL + "/pay/v3/token";

                HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;

                //set configurations
                request.ProtocolVersion = HttpVersion.Version11;
                request.KeepAlive = false;
                request.Method = "POST";
                request.ContentType = "application/json";
                request.Referer = null;
                request.Headers["Authorization"] = BasicAuth.basicauth;
                request.AllowAutoRedirect = true;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                ServicePointManager.CheckCertificateRevocationList = true;
                request.Accept = "*/*";

                byte[] data = null;
                data = Encoding.UTF8.GetBytes(postData);

                //send post data to server
                Stream newStream = request.GetRequestStream();
                newStream.Write(data, 0, data.Length);
                newStream.Close();

                //get response from server
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream stream = response.GetResponseStream();

                string result = string.Empty;
                using (StreamReader sr = new StreamReader(stream))
                {
                    result = sr.ReadToEnd();
                }


                parseOneTimeTokenResponse(result);

                return ConfigItems.OneTimeToken_token;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static String RunCreditCardTransaction()
        {
            try
            {
                string url = ConfigItems.API_URL + "/pay/v3?token=" + ConfigItems.OneTimeToken_token;

                HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
                request.ProtocolVersion = HttpVersion.Version11;
                request.KeepAlive = false;
                request.Method = "GET";
                request.ContentType = "application/json";
                request.Referer = null;
                request.AllowAutoRedirect = true;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                ServicePointManager.CheckCertificateRevocationList = true;
                request.Accept = "*/*";

                //get response from Nexio
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream stream = response.GetResponseStream();
                
                string result = string.Empty;
                using (StreamReader sr = new StreamReader(stream))
                {
                    result = sr.ReadToEnd();
                }

                return result;

            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static String RunAsyncAlipayTransaction()
        {
            try
            {
                string url = ConfigItems.API_URL + "/pay/v3/async?token=" + ConfigItems.OneTimeToken_token;



                HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
                request.ProtocolVersion = HttpVersion.Version11;
                request.KeepAlive = false;
                request.Method = "GET";
                request.ContentType = "application/json";
                request.Referer = null;
                request.AllowAutoRedirect = true;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                ServicePointManager.CheckCertificateRevocationList = true;
                request.Accept = "*/*";
                
                //get response from Nexio
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream stream = response.GetResponseStream();

                string result = string.Empty;
                using (StreamReader sr = new StreamReader(stream))
                {
                    result = sr.ReadToEnd();
                }

                return result;

            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static String SaveCard()
        {
            try
            {
                string url = ConfigItems.API_URL + "/pay/v3/saveCard?token=" + ConfigItems.OneTimeToken_token;

                HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
                request.ProtocolVersion = HttpVersion.Version11;
                request.KeepAlive = false;
                request.Method = "GET";
                request.ContentType = "application/json";
                request.Referer = null;
                request.AllowAutoRedirect = true;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                ServicePointManager.CheckCertificateRevocationList = true;
                request.Accept = "*/*";

                //get response from Nexio
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream stream = response.GetResponseStream();

                string result = string.Empty;
                using (StreamReader sr = new StreamReader(stream))
                {
                    result = sr.ReadToEnd();
                }

                return result;

            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static String SaveECheck()
        {
            try
            {
                string url = ConfigItems.API_URL + "/pay/v3/saveECheck?token=" + ConfigItems.OneTimeToken_token;

                HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
                request.ProtocolVersion = HttpVersion.Version11;
                request.KeepAlive = false;
                request.Method = "GET";
                request.ContentType = "application/json";
                request.Referer = null;
                request.AllowAutoRedirect = true;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                ServicePointManager.CheckCertificateRevocationList = true;
                request.Accept = "*/*";

                //get response from Nexio
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream stream = response.GetResponseStream();

                string result = string.Empty;
                using (StreamReader sr = new StreamReader(stream))
                {
                    result = sr.ReadToEnd();
                }

                return result;

            }
            catch (Exception e)
            {
                throw e;
            }
        }


        public static String RunECheckTransaction()
        {
            try
            {
                string url = ConfigItems.API_URL + "/pay/v3/processECheck?token=" + ConfigItems.OneTimeToken_token;

                HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
                request.ProtocolVersion = HttpVersion.Version11;
                request.KeepAlive = false;
                request.Method = "GET";
                request.ContentType = "application/json";
                request.Referer = null;
                request.AllowAutoRedirect = true;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                ServicePointManager.CheckCertificateRevocationList = true;
                request.Accept = "*/*";

                //get response from Nexio
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream stream = response.GetResponseStream();

                string result = string.Empty;
                using (StreamReader sr = new StreamReader(stream))
                {
                    result = sr.ReadToEnd();
                }

                return result;

            }
            catch (Exception e)
            {
                throw e;
            }
        }
        

        private static void parseOneTimeTokenResponse(String JSONString)
        {
            DataContractJsonSerializer serializer1 = new DataContractJsonSerializer(typeof(OneTimeTokenResponse));

            OneTimeTokenResponse response = null;

            try
            {
                response = Deserialize<OneTimeTokenResponse>(JSONString);
            }
            catch (Exception e)
            {
                Console.WriteLine("Parsing response get Exception: " + e.Message);
                return;
            }

            ConfigItems.OneTimeToken_token = response.token;
            ConfigItems.OneTimeToken_expiration = response.expiration;

        }

        private static T Deserialize<T>(string json)
        {
            var instance = Activator.CreateInstance<T>();
            using (var ms = new MemoryStream(Encoding.Unicode.GetBytes(json)))
            {
                try
                {
                    var serializer = new DataContractJsonSerializer(instance.GetType());
                    return (T)serializer.ReadObject(ms);
                }
                catch (Exception e)
                {
                    throw e;
                }

            }
        }
    }

    //structure of One Time Token response
    [DataContract]
    class OneTimeTokenResponse
    {
        [DataMember(Name = "token")]
        public String token { get; set; }

        [DataMember(Name = "expiration")]
        public String expiration { get; set; }
    }
}
