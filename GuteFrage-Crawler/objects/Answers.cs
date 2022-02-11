using System;
using System.Collections.Generic;

namespace GuteFrage_Crawler
{
    public class Answer
    {
        public string User = "";
        public string AnswerText = "";
        public string Question = "";

        public Answer(string user, string answer, string question)
        {
            User = user;
            AnswerText = answer;
            Question = question;
        }

        public static List<Answer> GetAnswers(string html)
        {
            List<Answer> answerList = new List<Answer>();
            string[] answers = html.Split(new string[] { "<a class=\"AnswerTeaser-title\" href=\"" }, StringSplitOptions.None);

            string currentUser = null;

            foreach (var answer in answers)
            {
                if (answer.Contains("<!DOCTYPE html>"))
                    continue;

                currentUser = getUser(answer);
                string currentAnswer = answer;
                string currentQuestion = getQuestion(answer);

                if (currentUser != null)
                    answerList.Add(new Answer(currentUser, currentAnswer, currentQuestion));
            }

            return answerList;
        }

        private static string getUser(string answer)
        {
            string user = null;

            string[] splittedUser = answer.Split(new string[] { "track\":\"user\"}'>" }, StringSplitOptions.None);

            if (splittedUser.Length > 1)
                user = splittedUser[1];
            else
                return user;


            return user.Split(new string[] { "</a>" } , StringSplitOptions.RemoveEmptyEntries)[0];
        }

        private static string getQuestion(string answer)
        {
            return answer.Split(new string[] { "/frage/" }, StringSplitOptions.None)[1].Split(new char[] { '\"' })[0];
        }

        public IEnumerable<string> GetIllegalUrls()
        {
            if (AnswerText.Contains("<a href=\"http"))
            {
                if (AnswerText.Contains("Paginator Paginator__belowBlock"))
                    AnswerText = AnswerText.Split(new string[] { "Paginator Paginator__belowBlock" }, StringSplitOptions.None)[0];

                string[] urls = AnswerText.Split(new string[] { "<a href=\"http" }, StringSplitOptions.RemoveEmptyEntries);

                foreach (var url in urls)
                {
                    if (url.Contains("gesetze"))
                        yield return null;

                    string illegalUrl = "http" + url.Split(new char[] { ' ' })[0];
                    illegalUrl = illegalUrl.Split(new char[] { '\"' })[0];

                    if(illegalUrl[4] != '/')
                        yield return illegalUrl;
                }
            }
        }
    }
}
