using System.Collections.Generic;
using System.Net;

namespace GuteFrage_Crawler
{
    public class Report
    {
        public Answer Answer;
        public int Page;
        public string IllegalUrl;

        private static WebClient wClient = new WebClient();

        public Report(Answer answer, int page, string illegalUrl)
        {
            Answer = answer;
            Page = page;
            IllegalUrl = illegalUrl;
        }

        public static IEnumerable<Report> GetReports(int i, bool proxy)
        {
            wClient = new WebClient();
            wClient.Proxy.Credentials = setProxy(proxy);


            string source = wClient.DownloadString("http://www.gutefrage.net/antworten/neue/" + i); // = visitor.request_Resource("http://www.gutefrage.net/antworten/neue/" + i);

            foreach (var answer in Answer.GetAnswers(source))
            {
                foreach (var illegalUrl in answer.GetIllegalUrls())
                {
                    if (illegalUrl != null)
                    {
                        yield return new Report(answer, i, illegalUrl);
                    }
                }
            }
        }

        public static ICredentials setProxy(bool proxy)
        {
            if (proxy)
                return CredentialCache.DefaultCredentials; //Fuer Firmen-Proxy
            else
                return null;
        }
    }
}
