using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NexioPaySample
{
    public static class BasicAuth
    {
        //authroization info
        internal static string username = "";
        internal static string password = "";
        internal static string basicauth = "";


        internal static void GetBasicAuth()
        {
            basicauth = "Basic " + Tools.Base64Encode(username + ":" + password);
        }

    }
}
