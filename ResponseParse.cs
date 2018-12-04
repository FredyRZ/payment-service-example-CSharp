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
    static class ResponseParse
    {
        
        //CreditCard transaction
        [DataContract]
        class RunTransResponse
        {
            [DataMember(Name = "id")]
            public String id { get; set; }

            [DataMember(Name = "authCode")]
            public String authCode { get; set; }

            [DataMember(Name = "amount")]
            public String amount { get; set; }

            [DataMember(Name = "gatewayResponse")]
            public RunTrans_gateway gatewayResponse { get; set; }
        }

        [DataContract]
        class RunTrans_gateway
        {
            [DataMember(Name = "result")]
            public String result { get; set; }

            [DataMember(Name = "refNumber")]
            public String refNumber { get; set; }

            [DataMember(Name = "gatewayName")]
            public String gatewayName { get; set; }
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

        public static void TransResponseParse(Form1 form, String JSONString)
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

            Console.WriteLine("id: " + response.id);
            Console.WriteLine("authCode: " + response.authCode);
            Console.WriteLine("amount: " + response.amount);
            Console.WriteLine("result: " + response.gatewayResponse.result);
            Console.WriteLine("gatewayName: " + response.gatewayResponse.gatewayName);

            form.TransList.Rows.Add(false,response.id, response.amount);
        }


        //SaveCard response
        [DataContract]    
        class SaveCardResponse
        {
            [DataMember(Name = "token")]
            
            public SaveCard_token token { get; set; }

            [DataMember(Name = "card")]
            public SaveCard_card card { get; set; }
        }

        [DataContract]
        class SaveCard_token
        {
            [DataMember(Name = "token")]
            public String token { get; set; }
        }

        [DataContract]
        class SaveCard_card
        {
            [DataMember(Name = "cardHolderName")]
            public String cardHolderName { get; set; }
        }

        public static void SaveCardResponseParse(Form1 form, String JSONString)
        {
            DataContractJsonSerializer serializer1 = new DataContractJsonSerializer(typeof(SaveCardResponse));

            SaveCardResponse response = null;
            Console.WriteLine(JSONString);
            try
            {
                response = Deserialize<SaveCardResponse>(JSONString);
            }
            catch (Exception e)
            {
                Console.WriteLine("Parsing response get Exception: " + e.Message);
                throw e;
            }

            Console.WriteLine("token: " + response.token.token);
            Console.WriteLine("cardholder name: " + response.card.cardHolderName);

            form.TokenList.Rows.Add(response.token.token);
            
        }


        //Search Transactions
        [DataContract]
        class TransactionsResponse
        {
            [DataMember(Name = "rows")]
            public Trans_rows[] rows { get; set; }
        }

        [DataContract]
        class Trans_rows
        {
            [DataMember(Name = "id")]
            public String id { get; set; }
            
            public String authCode { get; set; }

            [DataMember(Name = "amount")]
            public String amount { get; set; }

            [DataMember(Name = "gateway")]
            public RunTrans_gateway gatewayResponse { get; set; }
        }

        [DataContract]
        class Trans_gateway
        {
            [DataMember(Name = "refNumber")]
            public String refNumber { get; set; }

            [DataMember(Name = "gatewayType")]
            public String gatewayType { get; set; }
        }

        public static void SearchTransResponse(Form1 form, String JSONString)
        {
            DataContractJsonSerializer serializer1 = new DataContractJsonSerializer(typeof(TransactionsResponse));

            TransactionsResponse response = null;
            Console.WriteLine(JSONString);
            try
            {
                response = Deserialize<TransactionsResponse>(JSONString);
            }
            catch (Exception e)
            {
                Console.WriteLine("Parsing response get Exception: " + e.Message);
                throw e;
            }

            Console.WriteLine("rows count: " + response.rows.Length);
            for (int i = 0; i < response.rows.Length; i++)
            {
                form.TransFromNexioList.Rows.Add(false, response.rows[i].id, response.rows[i].amount);
            }
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
