using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace NexioPaySample
{
    public static class PaymentService
    {
        public static string JWT_idToken = "";
        public static string JWT_refreshToken = "";
        public static string JWT_accessToken = "";
        public static string JWT_expiresin = "";
        public static string API_URL = "";
        public static string Merchantid = "";
        public static string Tokenex_token = "";
        public static string GatewayName = "";

        public static string transid = "";

        //login and refresh response data structure
        [DataContract]
        class JWTResponse
        {
            [DataMember(Name = "idToken")]
            public String idToken { get; set; }

            [DataMember(Name = "refreshToken")]
            public String refreshToken { get; set; }

            [DataMember(Name = "accessToken")]
            public String accessToken { get; set; }

            [DataMember(Name = "expiresIn")]
            public String expiresIn { get; set; }
        }

        private static void parseJWTResponse(String JSONString)
        {
            DataContractJsonSerializer serializer1 = new DataContractJsonSerializer(typeof(JWTResponse));

            JWTResponse response = null;

            try
            {
                response = Deserialize<JWTResponse>(JSONString);
            }
            catch (Exception e)
            {
                Console.WriteLine("Parsing response get Exception: " + e.Message);
                return;
            }


            JWT_idToken = response.idToken;
            JWT_refreshToken = response.refreshToken;
            JWT_accessToken = response.accessToken;
            JWT_expiresin = response.expiresIn;

            Console.WriteLine("idtoken: " + JWT_idToken);
            Console.WriteLine("refreshtoken: " + JWT_refreshToken);
            Console.WriteLine("accesstoken: " + JWT_accessToken);
            Console.WriteLine("expiresin: " + JWT_expiresin);

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

        //iFrame Get JWT
        public static String GetJWT()
        {
            Console.WriteLine("begin GetJWT process...");

            string url = API_URL + "/user/v3/login";
            //https://api.nexiopaysandbox.com/user/v3/login;



            String data = "{\"username\":\"" + BasicAuth.username + "\", \"password\":\"" + BasicAuth.password + "\"}";



            String result;
            try
            {
                result = Tools.SendRequest("POST", url, data, false, null);

                parseJWTResponse(result);

                return result;

            }
            catch (Exception e)
            {
                throw e;
            }
        }


        //Refresh JWT
        public static String RefreshJWT()
        {
            string url = API_URL + "/user/v3/refresh";



            String data = "{\"refreshToken\":\"" + JWT_refreshToken + "\"}";



            String result;
            try
            {
                result = Tools.SendRequest("POST", url, data, false, null);

                parseJWTResponse(result);

                return result;

            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public static String RunTransaction()
        {
            string url = API_URL + "/pay/v3/process";

            String data = "{\"merchantId\":\"" + Merchantid + "\",\"gateway\":{\"name\":\""+ GatewayName +"\"},\"data\":{\"amount\":12.34}, \"card\":{\"expirationMonth\":\"04\",\"expirationYear\":\"2019\"},\"tokenex\":{\"token\":\"" + Tokenex_token + "\" }}";



            String result;
            try
            {
                result = Tools.SendRequest("POST", url, data, true, BasicAuth.basicauth);

                
                Console.WriteLine("run transaction result is: " + result);

                return result;

            }
            catch (Exception e)
            {
                throw e;
            }
            

        }


        public static String VoidTransaction()
        {
            string url = API_URL + "/pay/v3/void";

            String data = "{\"data\":{\"amount\":12.34}, \"id\":\"" + transid + "\"}";

            String result;
            try
            {
                result = Tools.SendRequest("POST", url, data, true, BasicAuth.basicauth);

                Console.WriteLine("run void transaction result is: " + result);

                return result;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public static String RefundTransaction()
        {
            string url = API_URL + "/pay/v3/refund";

            String data = "{\"data\":{\"amount\":12.34}, \"id\":\"" + transid + "\"}";

            String result;
            try
            {
                result = Tools.SendRequest("POST", url, data, true, BasicAuth.basicauth);

                Console.WriteLine("run refund transaction result is: " + result);

                return result;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static String CaptureTransaction()
        {
            string url = API_URL + "/pay/v3/capture";

            String data = "{\"data\":{\"amount\":12.34}, \"id\":\"" + transid + "\"}";

            String result;
            try
            {
                result = Tools.SendRequest("POST", url, data, true, BasicAuth.basicauth);


                Console.WriteLine("run capture transaction result is: " + result);

                return result;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

    }
}
