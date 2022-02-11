using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.IO;
using System.Windows.Forms;

namespace GuteFrage_Crawler
{
    public class WebVisitor
    {
        private CookieContainer container = new CookieContainer();
        private RichTextBox htmlBox;
        private WebBrowser browser;
        private string pageSource;
        private WebResponse response;
        //private HtmlToText converter;
        public WebVisitor(WebBrowser browser = null, RichTextBox htmlBox = null)
        {
            if (htmlBox != null)
                this.htmlBox = htmlBox;

            if (browser != null)
                this.browser = browser;

            // converter = new HtmlToText();
        }

        public string PostRequest(string url, string formParams)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.CookieContainer = container;
            request.Proxy = null; //um es schneller zu machen
                                  //request.Proxy.Credentials = CredentialCache.DefaultCredentials; //Fuer Firmen-Proxy
            request.ContentType = "application/x-www-form-urlencoded";
            request.Method = "POST";
            byte[] bytes = Encoding.ASCII.GetBytes(formParams);
            request.ContentLength = bytes.Length;

            using (Stream os = request.GetRequestStream())
            {
                os.Write(bytes, 0, bytes.Length);
            }

            response = request.GetResponse();

            using (StreamReader sr = new StreamReader(response.GetResponseStream()))
            {
                pageSource = sr.ReadToEnd();
            }

            return pageSource;
        }

        public string GetRequest(string url, bool proxy, bool plainText = false)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.ContentType = "application/x-www-form-urlencoded";
            request.Method = "GET";
            response = request.GetResponse();
            request.CookieContainer = container;

            if (proxy)
                request.Proxy.Credentials = CredentialCache.DefaultCredentials; //Fuer Firmen-Proxy
            else
                request.Proxy = null;

            using (StreamReader sr = new StreamReader(response.GetResponseStream()))
            {
                pageSource = sr.ReadToEnd();
            }

            return pageSource;
        }

        public string request_Resource(string url)
        {
            WebClient wc = new WebClient();
            byte[] data = wc.DownloadData(url);
            return Encoding.UTF8.GetString(data);
        }

        public List<string> GetCookies(Uri url)
        {
            List<string> cookies = new List<string>();

            foreach (Cookie c in container.GetCookies(url))
            {
                cookies.Add(
                    "cName: " + c.Name + "\n" +
                    " cValue:  " + c.Value + "\n" +
                    " cPath:   " + c.Path + "\n" +
                    " cDomain: " + c.Domain);
            }

            return cookies;
        }

        public void CutPageSource(string cutBegin, string cutEnd)
        {
            string newPageSource = "";
            bool cut = false;

            foreach (string line in htmlBox.Lines)
            {
                if (line.Contains(cutBegin))
                    cut = true;

                if (!cut)
                    newPageSource += line;

                if (line.Contains(cutEnd))
                    cut = false;
            }
        }
    }
}
