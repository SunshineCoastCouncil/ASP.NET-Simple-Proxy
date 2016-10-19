using System;
using System.Web;
using System.Web.UI;
using System.Net;
using System.IO;

namespace Proxy
{
    public partial class _Proxy : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string proxyURL = string.Empty;
            try
            {
                proxyURL = HttpUtility.UrlDecode(Request.QueryString["u"]);
            }
            catch { }

            if (proxyURL != string.Empty)
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(proxyURL);
                request.Method = "GET";
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                if (response.StatusCode.ToString().ToLower() == "ok")
                {
                    string contentType = response.ContentType;
                    Stream content = response.GetResponseStream();
                    StreamReader contentReader = new StreamReader(content);
                    Response.ContentType = contentType;
                    Response.Write(contentReader.ReadToEnd());
                }
            }
        }
    }
}
