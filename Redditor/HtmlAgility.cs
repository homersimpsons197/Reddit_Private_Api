using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;

namespace Redditor
{
    internal class HtmlAgility
    {
        public List<string> UpvoteBtnId()
        {
            string url = "https://www.reddit.com/r/dating/";
            WebClient client = new WebClient();
            client.Headers[HttpRequestHeader.UserAgent] = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/103.0.0.0 Safari/537.36";
            string html = client.DownloadString(url);
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();

            List<string> htmlToList = new List<string>(html.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries));

            List<string> ids = new List<string>();
            List<string> btnId = new List<string>();

            Regex reg = new Regex(@"(t3_)(.{6})");

            foreach (var match in htmlToList)
            {
                Match m = reg.Match(match);
                if (m.Success)
                {
                    string id = m.ToString();

                    ids.Add(id.ToString());
                }
            }
            
            foreach (var item in ids)
            {
                btnId = ids.Distinct().ToList();
            }

            return btnId;
        }

        public List<string> CommentBtnId()
        {
            string url = "https://www.reddit.com/r/dating/";
            WebClient client = new WebClient();
            client.Headers[HttpRequestHeader.UserAgent] = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/103.0.0.0 Safari/537.36";
            string html = client.DownloadString(url);
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();

            List<string> htmlToList = new List<string>(html.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries));

            List<string> ids = new List<string>();
            List<string> btnId = new List<string>();

            Regex reg = new Regex(@"(comment_t3_)(.{6})");

            foreach (var match in htmlToList)
            {
                Match m = reg.Match(match);
                if (m.Success)
                {
                    string id = m.ToString();

                    ids.Add(id.ToString());
                }
            }

            foreach (var item in ids)
            {
                btnId = ids.Distinct().ToList();
            }

            return btnId;
        }
    }
}
