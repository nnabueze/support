using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;

namespace Support.Models
{
    public class EmailClass
    {
        public const string TOKEN = "FNs6Noo-kkuqsM7QPzQ5f26MPs1-r1KXLEa4oZmRMLghzA256sFgnLJVFHweeiJgwKS9oXanr_3pSqEJ9TP01kHf-h3nGLrnM7v1vhsDIccAf6P2W29m5pB873fDcWbTLEyUTcXA6Feys1KX1sybsjbA_-sW7UL5OHLjCR9W6Igmp0p3XhYjk8I4aef8SCsJZOtqhrsBr5K8E9bm51_R5OW0xe_7pd0I9NNbuHbEEifGgRQDWPVWfdGSqJN8VOgw";
        public static string sendEmail(string url, EmailParam requestParam)
        {
            var json = JsonConvert.SerializeObject(requestParam);
            string resCodeString;
            string responseText;

            HttpWebRequest httpWebReq = (HttpWebRequest)WebRequest.Create(url);
            httpWebReq.Headers.Add("Authorization", "Bearer "+TOKEN);
            httpWebReq.ContentType = "application/json; charset=utf-8";
            httpWebReq.Method = "POST";

            using (StreamWriter streamWriter = new StreamWriter(httpWebReq.GetRequestStream()))
            {

                streamWriter.Write(json);
                streamWriter.Flush();
            }
            using (HttpWebResponse httpResponse = (HttpWebResponse)httpWebReq.GetResponse())
            {
                using (StreamReader streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    responseText = streamReader.ReadToEnd();
                }

                //var resCode = httpResponse.StatusCode;
                resCodeString = httpResponse.StatusCode.ToString();
            }


            //return responseText;
            return resCodeString;
        }
    }

    public class EmailParam
    {
        public string Phone { get; set; }
        public string Email { get; set; }
        public string SenderEmail { get; set; }
        public string From { get; set; }
        public string Message { get; set; }
    }
}