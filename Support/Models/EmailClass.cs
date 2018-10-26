using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;

namespace Support.Models
{
    public class EmailClass
    {
        public const string TOKEN = "DY-bXX-eQjijqwiQFPz8wrolt-jNYhOaf-6nBsBtETp2mfWYzrrtnh6HrB5smRq1bSOu4rgN-yd9cLHnYr8g9RXXbsmNtkvYGjSmk34qA5-OTasRCS2dHJSykTKe_LH-gwXnUgHFu2CY62qeB_6lW7-ffKm4wBldXW04qC6NIPHOrEK0_lLt8rr38WTiP0UTw0FXQZlD0AUqVJNXbfRklxpNwfoKTfzzoENBYPuHauAoDv7KcwesicKDm9hK1XLU";
        public static string sendEmail(string url, EmailParam requestParam)
        {
            var json = JsonConvert.SerializeObject(requestParam);
            string resCodeString;
            string responseText = null;

            HttpWebRequest httpWebReq = (HttpWebRequest)WebRequest.Create(url);
            httpWebReq.ContentType = "application/json";
            byte[] postData = Encoding.UTF8.GetBytes(json);
            httpWebReq.ContentLength = postData.Length;
            httpWebReq.Headers["Authorization"] = "Bearer" + " " + TOKEN;
            httpWebReq.Method = "POST";
            Stream dataStream = httpWebReq.GetRequestStream();
            dataStream.Write(postData, 0, postData.Length);
            dataStream.Close();

            using (HttpWebResponse httpResponse = (HttpWebResponse)httpWebReq.GetResponse())
            {
                if (httpResponse.StatusCode != HttpStatusCode.OK)
                {
                    return responseText;
                }

                using (StreamReader streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    responseText = streamReader.ReadToEnd();
                }

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