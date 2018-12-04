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
    class TransactionService
    {
        public static String TransactionWithTransactionId(String urldata)
        {
            try
            {
                string url = urldata;//ConfigItems.API_URL + "/transaction/v3/{{" + transid +"}}";

                HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
                request.ProtocolVersion = HttpVersion.Version11;
                request.KeepAlive = false;
                request.Method = "GET";
                request.ContentType = "application/json";
                request.Referer = null;
                request.AllowAutoRedirect = true;
                request.Headers["Authorization"] = BasicAuth.basicauth;
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

        
        public static String Transaction(String urldata)
        {
            try
            {
                string url = urldata;//ConfigItems.API_URL + "/transaction/v3?plugin.originalId=" + Originaltransid;
                //string url = ConfigItems.API_URL + "/transaction/v3?merchantIds=100039";
                HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
                request.ProtocolVersion = HttpVersion.Version11;
                request.KeepAlive = false;
                request.Method = "GET";
                request.ContentType = "application/json";
                request.Referer = null;
                request.AllowAutoRedirect = true;
                request.Headers["Authorization"] = BasicAuth.basicauth;
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

        public static String MatchingTransactionForFDRChargeback(String urldata)
        {
            try
            {
                //string url = ConfigItems.API_URL + "/transaction/v3/getMatchingTransactionForFDRChargeback";
                string url = urldata;//ConfigItems.API_URL + "/transaction/v3/getMatchingTransactionForFDRChargeback?authCode=" + authcode + "&transactionDate=" + transdate + "&cardNumber=" + cardNum;
                HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
                request.ProtocolVersion = HttpVersion.Version11;
                request.KeepAlive = false;
                request.Method = "GET";
                request.ContentType = "application/json";
                request.Referer = null;
                request.AllowAutoRedirect = true;
                request.Headers["Authorization"] = BasicAuth.basicauth;
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

        public static String TransactionCount(String urldata)
        {
            try
            {
                string url = urldata;// ConfigItems.API_URL + "/transaction/v3/count";

                HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
                request.ProtocolVersion = HttpVersion.Version11;
                request.KeepAlive = false;
                request.Method = "GET";
                request.ContentType = "application/json";
                request.Referer = null;
                request.AllowAutoRedirect = true;
                request.Headers["Authorization"] = BasicAuth.basicauth;
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

        
        public static String DailyTransactionsSummary(String urldata)
        {
            try
            {
                string url = urldata;//ConfigItems.API_URL + "/transaction/v3/dailyTransactionsSummary";

                HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
                request.ProtocolVersion = HttpVersion.Version11;
                request.KeepAlive = false;
                request.Method = "GET";
                request.ContentType = "application/json";
                request.Referer = null;
                request.AllowAutoRedirect = true;
                request.Headers["Authorization"] = BasicAuth.basicauth;
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

        public static String RefundTransaction(String urldata, String postdata)
        {
            try
            {
                string url = urldata;// ConfigItems.API_URL + "/transaction/v3/refund";

                //String postdata = "{\"amount\": 35.05, \"id\":\"" + transid + "\"}";

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

        public static String TransactionsTotal(String urldata)
        {
            try
            {
                string url = urldata;// ConfigItems.API_URL + "/transaction/v3/total?";
                Console.WriteLine(url);
                HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
                request.ProtocolVersion = HttpVersion.Version11;
                request.KeepAlive = false;
                request.Method = "GET";
                request.ContentType = "application/json";
                request.Referer = null;
                request.AllowAutoRedirect = true;
                request.Headers["Authorization"] = BasicAuth.basicauth;
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

        public static String PaymentTypes(String urldata)
        {
            try
            {
                string url = urldata;//ConfigItems.API_URL + "/transaction/v3/paymentTypes";

                HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
                request.ProtocolVersion = HttpVersion.Version11;
                request.KeepAlive = false;
                request.Method = "GET";
                request.ContentType = "application/json";
                request.Referer = null;
                request.AllowAutoRedirect = true;
                request.Headers["Authorization"] = BasicAuth.basicauth;
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


        public static String BulkVoid(String urldata, String postdata)
        {
            try
            {
                string url = urldata;//ConfigItems.API_URL + "/transaction/v3/void/bulk";

                //String postdata = "{\"transactionIds\":[\""+ transid +"\", \"" + transid2 + "\"]}";

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

        public static String SearchTransactions(String urldata)
        {
            try
            {
                string url = urldata;// ConfigItems.API_URL + "/transaction/v3/search";

                HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
                request.ProtocolVersion = HttpVersion.Version11;
                request.KeepAlive = false;
                request.Method = "GET";
                request.ContentType = "application/json";
                request.Referer = null;
                request.AllowAutoRedirect = true;
                request.Headers["Authorization"] = BasicAuth.basicauth;
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

        public static String BulkCapture(String transid, String transid2)
        {
            try
            {
                string url = ConfigItems.API_URL + "/transaction/v3/capture/bulk";

                String postdata = "{\"transactionIds\":[\"" + transid + "\", \"" + transid2 + "\"]}";

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

        public static String Transactions()
        {
            try
            {
                string url = ConfigItems.API_URL + "/transaction/v3";

                HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
                request.ProtocolVersion = HttpVersion.Version11;
                request.KeepAlive = false;
                request.Method = "GET";
                request.ContentType = "application/json";
                request.Referer = null;
                request.AllowAutoRedirect = true;
                request.Headers["Authorization"] = BasicAuth.basicauth;
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

        public static String MatchingTransactionForTsysChargeback()
        {
            try
            {
                string url = ConfigItems.API_URL + "/transaction/v3/getMatchingTransactionForTsysChargeback";

                HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
                request.ProtocolVersion = HttpVersion.Version11;
                request.KeepAlive = false;
                request.Method = "GET";
                request.ContentType = "application/json";
                request.Referer = null;
                request.AllowAutoRedirect = true;
                request.Headers["Authorization"] = BasicAuth.basicauth;
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

        public static String CaptureTransaction(String urldata, String postdata)
        {
            try
            {
                string url = urldata;// ConfigItems.API_URL + "/transaction/v3/capture";

                //String postdata = "{\"id\":\"" + transid + "\"}";

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


        public static String CountPerAchDetail()
        {
            try
            {
                string url = ConfigItems.API_URL + "/transaction/v3/achDetail/count?achDetails123,999=";

                HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
                request.ProtocolVersion = HttpVersion.Version11;
                request.KeepAlive = false;
                request.Method = "GET";
                request.ContentType = "application/json";
                request.Referer = null;
                request.AllowAutoRedirect = true;
                request.Headers["Authorization"] = BasicAuth.basicauth;
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


        public static String VoidTransaction(String urldata, String postdata)
        {
            try
            {
                string url = urldata;// ConfigItems.API_URL + "/transaction/v3/void";

                //String postdata = "{\"id\":\"" + transid + "\"}";

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


        public static String TransactionSummary(String urldata)
        {
            try
            {
                string url = urldata;// ConfigItems.API_URL + "/transaction/v3/transactionsSummary";

                HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
                request.ProtocolVersion = HttpVersion.Version11;
                request.KeepAlive = false;
                request.Method = "GET";
                request.ContentType = "application/json";
                request.Referer = null;
                request.AllowAutoRedirect = true;
                request.Headers["Authorization"] = BasicAuth.basicauth;
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

    }

}
