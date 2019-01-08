using System;
using System.IO;
using System.Net;
using System.Reflection;

namespace ch2_fuzzing_xss_sqli
{
    class Fuzzer
    {
        static void Main(string[] args)
        {
            string url = args[0];
            int index = url.IndexOf("?");
            string[] pars = url.Remove(0, index + 1).Split('&');
            foreach (var p in pars)
            {
                string xssUrl = url.Replace(p, p + "fd<xss>sa");
                string sqlUrl = url.Replace(p, p + "fd'sa");

                HttpWebRequest request = (HttpWebRequest) WebRequest.Create(sqlUrl);
                request.Method = "GET";
                string sqlresp = string.Empty;
                using (StreamReader rdr = new StreamReader(request.GetResponse().GetResponseStream()))
                    sqlresp = rdr.ReadToEnd();

                request = (HttpWebRequest) WebRequest.Create(xssUrl);
                request.Method = "GET";
                string xssresp = string.Empty;
                using (StreamReader rdr = new StreamReader(request.GetResponse().GetResponseStream()))
                    xssresp = rdr.ReadToEnd();
                
                if (xssresp.Contains("<xss>"))
                    Console.WriteLine("Possible XSS point found in parameter: " + p);
                
                if (sqlresp.Contains("error in your SQL syntax"))
                    Console.WriteLine("SQL injection point found in parameter: " + p);
             
            }
        }
        
    }
}