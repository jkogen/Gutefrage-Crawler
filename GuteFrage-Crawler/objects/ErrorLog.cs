namespace GuteFrage_Crawler
{
    public class ErrorLog
    {
        public string Error;
        public int Page;

        public ErrorLog(string error, int page)
        {
            Error = error;
            Page = page;
        }
    }
}
