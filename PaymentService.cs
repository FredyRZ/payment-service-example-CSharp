using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace NexioPaySample
{
    public static class PaymentService
    {
        public static String SaveCard()
        {
            try
            {
                String url = ConfigItems.API_URL+"/pay/v3/saveCard";
                  String postdata = "{\"token\":\"" + ConfigItems.OneTimeToken_token +
                //using Nexio public key to encrypt the card number to get encryptedNumber
                              "\",\"card\":{\"encryptedNumber\":\"" + "cu3yRktaYFK2LUC6DpNK289tYDsGRCi7cO+GeG0hkeYFvT7Y8/oY5r53obMz6Q/BZ38gk2u2Ufwy8ojBcX2sfNjG5jplGTXA4NNlSIUjMFfiHe1sff1JFpThoiW/IIlifGlbWu+S1/9pqWPTzJ2+DcjwohbHzsDahhYewFhXgC8qsK0ypi/Shlp+CwRITyIvbVXESD0xz3YOTRHeZLlChvVqN8z4ZzN8nm0MXkmT1wcpYI73bH4KdnPwNU3s7XxvP/ernQP73SHHAOKSLlz4F6AEHFjJiCoXzeLF7LwEjRdxDJ0sKVXbRk3i9BGh+8Nle2VYgjpUWtk2763QkvZiQQ==" +
                              "\",\"expirationMonth\":\"" + "1" +
                              "\",\"expirationYear\":\"" + "2024" +
                              "\",\"cardHolderName\":\"" + "Kevin Batchelor" +
                              "\",\"securityCode\":\"" + "123" + "\"}," +
                              "\"procesingOptions\":{\"verifyAvs\":\"3\"}}";
                Console.WriteLine(postdata);
                HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;

                //set configurations
                request.ProtocolVersion = HttpVersion.Version11;
                request.KeepAlive = false;
                request.Method = "POST";
                request.ContentType = "application/json";
                request.Referer = null;
                request.AllowAutoRedirect = true;
                //request.Headers["Authorization"] = BasicAuth.basicauth;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                ServicePointManager.CheckCertificateRevocationList = true;
                request.Accept = "*/*";

                byte[] data = null;
                data = Encoding.UTF8.GetBytes(postdata);

                //send post data to Nexio
                Stream newStream = request.GetRequestStream();
                newStream.Write(data, 0, data.Length);
                newStream.Close();

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

        public static String RunCreditCardTransaction(String urldata, String postdata)
        {
            try
            {
                string url = urldata;// ConfigItems.API_URL + "/pay/v3/process";

                
                HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;

                //set configurations
                request.ProtocolVersion = HttpVersion.Version11;
                request.KeepAlive = false;
                request.Method = "POST";
                request.ContentType = "application/json";
                request.Referer = null;
                request.AllowAutoRedirect = true;
                request.Headers["Authorization"] = BasicAuth.basicauth;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                ServicePointManager.CheckCertificateRevocationList = true;
                request.Accept = "*/*";

                byte[] data = null;
                data = Encoding.UTF8.GetBytes(postdata);

                //send post data to Nexio
                Stream newStream = request.GetRequestStream();
                newStream.Write(data, 0, data.Length);
                newStream.Close();

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


        public static String VoidTransaction(String urldata, String postdata)
        {
            try
            {
                string url = urldata; //ConfigItems.API_URL + "/pay/v3/void";

                //String postdata = "{\"data\":{\"amount\":12.34}, \"id\":\"" + transid + "\"}";

                HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;

                //set configurations
                request.ProtocolVersion = HttpVersion.Version11;
                request.KeepAlive = false;
                request.Method = "POST";
                request.ContentType = "application/json";
                request.Referer = null;
                request.AllowAutoRedirect = true;
                request.Headers["Authorization"] = BasicAuth.basicauth;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                ServicePointManager.CheckCertificateRevocationList = true;
                request.Accept = "*/*";

                byte[] data = null;
                data = Encoding.UTF8.GetBytes(postdata);

                //send post data to Nexio
                Stream newStream = request.GetRequestStream();
                newStream.Write(data, 0, data.Length);
                newStream.Close();

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
        public static String RefundTransaction(String urldata, String postdata)
        {
            try
            {
                string url = urldata;// ConfigItems.API_URL + "/pay/v3/refund";

                //String postdata = "{\"data\":{\"amount\": 5, \"partialAmount\": 5}, \"id\":\"" + transid + "\"}";

                HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;

                //set configurations
                request.ProtocolVersion = HttpVersion.Version11;
                request.KeepAlive = false;
                request.Method = "POST";
                request.ContentType = "application/json";
                request.Referer = null;
                request.AllowAutoRedirect = true;
                request.Headers["Authorization"] = BasicAuth.basicauth;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                ServicePointManager.CheckCertificateRevocationList = true;
                request.Accept = "*/*";

                byte[] data = null;
                data = Encoding.UTF8.GetBytes(postdata);

                //send post data to Nexio
                Stream newStream = request.GetRequestStream();
                newStream.Write(data, 0, data.Length);
                newStream.Close();

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

        public static String CaptureTransaction(String urldata, String postdata)
        {
            try
            {
                string url = urldata;// ConfigItems.API_URL + "/pay/v3/capture";

                //String postdata = "{\"data\":{\"amount\":5.05}, \"id\":\"" + transid + "\"}";

                HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;

                //set configurations
                request.ProtocolVersion = HttpVersion.Version11;
                request.KeepAlive = false;
                request.Method = "POST";
                request.ContentType = "application/json";
                request.Referer = null;
                request.AllowAutoRedirect = true;
                request.Headers["Authorization"] = BasicAuth.basicauth;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                ServicePointManager.CheckCertificateRevocationList = true;
                request.Accept = "*/*";

                byte[] data = null;
                data = Encoding.UTF8.GetBytes(postdata);

                //send post data to Nexio
                Stream newStream = request.GetRequestStream();
                newStream.Write(data, 0, data.Length);
                newStream.Close();

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


        public static String RunECheckTransaction(String urldata, String postdata)
        {
            try
            {
                string url = urldata;// ConfigItems.API_URL + "/pay/v3/processECheck";

                /*String postdata = "{" +
                                     "\"tokenex\":{" +
                                         "\"token\":\"" + ConfigItems.Tokenex_token + "\"" +
                                     "}," +
                                     "\"bank\": {" +
                                       "\"accountHolderName\": \"Test Name\"," +
                                       "\"routingNumber\": \"999546788\"" +
                                     "}," +
                                     "\"data\": {" +
                                       "\"amount\": 1.00," +
                                       "\"currency\": \"USD\"," +
                                       "\"description\": \"test purchase\"," +
                                       "\"customFields\": {" +
                                         "\"custom1\": \"hi mom\"," +
                                         "\"custom2\": \"P#dfk1234kdf\"" +
                                       "}," +
                                       "\"customer\": {" +
                                         "\"billToAddressOne\": \"123 Street\"," +
                                         "\"billToAddressTwo\": \"Box 232\"," +
                                         "\"billToCity\": \"Amarillo\"," +
                                         "\"billToState\": \"TX\"," +
                                         "\"billToPostal\": \"79118\"," +
                                         "\"billToCountry\": \"USA\"" +
                                       "}," +
                                       "\"cart\":{" +
                                               "\"items\":[" +
                                                   "{\"item\":\"E100\", \"description\":\"Electric Socks\", \"quantity\":2, \"price\":5, \"type\":\"sale\"}" +
                                               "]" +
                                           "}" +
                                     "}" +
                                    "}";*/
                Console.WriteLine(postdata);
                HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;

                //set configurations
                request.ProtocolVersion = HttpVersion.Version11;
                request.KeepAlive = false;
                request.Method = "POST";
                request.ContentType = "application/json";
                request.Referer = null;
                request.AllowAutoRedirect = true;
                request.Headers["Authorization"] = BasicAuth.basicauth;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                ServicePointManager.CheckCertificateRevocationList = true;
                request.Accept = "*/*";

                byte[] data = null;
                data = Encoding.UTF8.GetBytes(postdata);

                //send post data to Nexio
                Stream newStream = request.GetRequestStream();
                newStream.Write(data, 0, data.Length);
                newStream.Close();

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

        public static String DeleteCardTokens(String urldata, String postdata)
        {
            try
            {
                string url = urldata;// ConfigItems.API_URL + "/pay/v3/deleteToken";

                /*String postdata = "{\"tokens\":[\"p6711abg-41fd-m56a-81a1-t0k3n287799b\"," +
                                                "\"f5899abf-41fd-49fa-80a0-t0k3n187763a\"]}";*/

                HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;

                //set configurations
                request.ProtocolVersion = HttpVersion.Version11;
                request.KeepAlive = false;
                request.Method = "POST";
                request.ContentType = "application/json";
                request.Referer = null;
                request.AllowAutoRedirect = true;
                request.Headers["Authorization"] = BasicAuth.basicauth;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                ServicePointManager.CheckCertificateRevocationList = true;
                request.Accept = "*/*";

                byte[] data = null;
                data = Encoding.UTF8.GetBytes(postdata);

                //send post data to Nexio
                Stream newStream = request.GetRequestStream();
                newStream.Write(data, 0, data.Length);
                newStream.Close();

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



        [DataContract]
        class RunTransResponse
        {
            [DataMember(Name = "id")]
            public String id { get; set; }
        }

        public static String GetTransId(String JSONString)
        {
            DataContractJsonSerializer serializer1 = new DataContractJsonSerializer(typeof(RunTransResponse));

            RunTransResponse response = null;

            try
            {
                response = Deserialize<RunTransResponse>(JSONString);
            }
            catch (Exception e)
            {
                Console.WriteLine("Parsing response get Exception: " + e.Message);
                throw e;
            }

            return response.id;

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
}
