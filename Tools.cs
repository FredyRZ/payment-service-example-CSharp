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
            ConfigItems.API_URL = GetConfig("API_URL");
            //Username
            BasicAuth.username = GetConfig("USERNAME");
            //Password
            BasicAuth.password = GetConfig("PASSWORD");

            //MERCHANT_ID
            ConfigItems.Merchantid = GetConfig("MERCHANT_ID");

            //TOKENEX_TOKEN
            ConfigItems.Tokenex_token = GetConfig("TOKENEX_TOKEN");

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

    }
}
