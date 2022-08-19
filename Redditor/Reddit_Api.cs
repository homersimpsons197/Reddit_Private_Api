using RestSharp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Redditor
{
    internal class Reddit_Api
    {        
        //Credentials
        private static string username;
        private static string password;
        
        //Tokens
        private static string csrfToken;
        private static string bearerToken;

        //Cookies
        private static string cookies;
        private static string redditSession;
        private static string loid;
        private static string session_tracker;
        private static string token_v2;
        private static string csv;
        private static string edgebucket;

        //Counters      
        private static int rowCounter;
      
        public void CsrfGet(Form1 f, RestClient client, RestRequest request, RestResponse response)
        {
            try
            {
                //var options = new RestClientOptions("http://www.google.com")
                //{
                //    Proxy = new WebProxy(string.Format("127.0.0.1", 8888))
                //}

                request.AddHeader("authority", "www.reddit.com");
                request.AddHeader("accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.9");
                request.AddHeader("accept-language", "en-US,en;q=0.9");
                request.AddHeader("sec-ch-ua", "\".Not/A)Brand\";v=\"99\", \"Google Chrome\";v=\"104\", \"Chromium\";v=\"103\"");
                request.AddHeader("sec-ch-ua-mobile", "?0");
                request.AddHeader("sec-ch-ua-platform", "\"Windows\"");
                request.AddHeader("sec-fetch-dest", "document");
                request.AddHeader("sec-fetch-mode", "navigate");
                request.AddHeader("sec-fetch-site", "none");
                request.AddHeader("sec-fetch-user", "?1");
                request.AddHeader("upgrade-insecure-requests", "1");
                request.AddHeader("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/104.0.0.0 Safari/537.36");
                
                response = client.Execute(request);
                
                List<String> strList;
                strList = response.Content.Split('\n').ToList();
                
                Regex filter = new Regex(@"(csrf_token)(.*\>$)");

                foreach (var line in strList)
                {
                    var match = filter.Match(line.ToString());

                    if (match.Success)
                    {
                        csrfToken = match.ToString().Replace("\"", "").Replace("csrf_token value=", "").Replace(">", "");
                    }
                }

                strList.Clear();

                f.dgv.Rows.Add();
                f.dgv.Rows[rowCounter].Cells[3].Value = "CSRF_TOKEN";
                f.dgv.Rows[rowCounter].Cells[3].Value = csrfToken;

                if (response.IsSuccessful)
                {
                    f.dgv.Rows[rowCounter].Cells[4].Style.ForeColor = Color.Green;
                    f.dgv.Rows[rowCounter].Cells[4].Value = "Success";
                }
                else if (!response.IsSuccessful)
                {
                    f.dgv.Rows[rowCounter].Cells[4].Style.ForeColor = Color.Red;
                    f.dgv.Rows[rowCounter].Cells[4].Value = "Failed";
                }

                rowCounter++;
            }
            catch (Exception ex)
            {

            }
        }

        public void LoginReq(Form1 f, RestClient client, RestRequest request, RestResponse response)
        {
            try
            {
                request.AddHeader("authority", "www.reddit.com");
                request.AddHeader("accept", "*/*");
                request.AddHeader("accept-language", "en-US,en;q=0.9");
                request.AddHeader("content-type", "application/x-www-form-urlencoded");
                request.AddHeader("origin", "https://www.reddit.com");
                request.AddHeader("referer", "https://www.reddit.com/login/?experiment_d2x_2020ify_buttons=enabled&experiment_d2x_sso_login_link=enabled&experiment_d2x_google_sso_gis_parity=enabled&experiment_d2x_onboarding=enabled");
                request.AddHeader("sec-ch-ua", "\".Not/A)Brand\";v=\"99\", \"Google Chrome\";v=\"104\", \"Chromium\";v=\"104\"");
                request.AddHeader("sec-ch-ua-mobile", "?0");
                request.AddHeader("sec-ch-ua-platform", "\"Windows\"");
                request.AddHeader("sec-fetch-dest", "empty");
                request.AddHeader("sec-fetch-mode", "cors");
                request.AddHeader("sec-fetch-site", "same-origin");
                request.AddHeader("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/104.0.0.0 Safari/537.36");
                request.AddParameter("csrf_token", csrfToken);
                request.AddParameter("otp", "");
                request.AddParameter("password", "Fresc@13");
                request.AddParameter("dest", "https://www.reddit.com");
                request.AddParameter("username", "lookdadon197");

                response = client.Execute(request);
               
                f.dgv.Rows.Add();
                f.dgv.Rows[rowCounter].Cells[2].Value = "LOGIN";                

                if (response.IsSuccessful)
                {
                    f.dgv.Rows[rowCounter].Cells[4].Style.ForeColor = Color.Green;
                    f.dgv.Rows[rowCounter].Cells[4].Value = "Success";
                }
                else if (!response.IsSuccessful)
                {
                    f.dgv.Rows[rowCounter].Cells[4].Style.ForeColor = Color.Red;
                    f.dgv.Rows[rowCounter].Cells[4].Value = "Failed";
                }

                rowCounter++;
            }
            catch(Exception ex)
            {

            }
        }

        public void BearerTokenGet(Form1 f, RestClient client, RestRequest request, RestResponse response)
        {
            try
            {
                request.AddHeader("authority", "www.reddit.com");
                request.AddHeader("accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.9");
                request.AddHeader("accept-language", "en-US,en;q=0.9");
                request.AddHeader("sec-ch-ua", "\".Not/A)Brand\";v=\"99\", \"Google Chrome\";v=\"104\", \"Chromium\";v=\"104\"");
                request.AddHeader("sec-ch-ua-mobile", "?0");
                request.AddHeader("sec-ch-ua-platform", "\"Windows\"");
                request.AddHeader("sec-fetch-dest", "document");
                request.AddHeader("sec-fetch-mode", "navigate");
                request.AddHeader("sec-fetch-site", "none");
                request.AddHeader("sec-fetch-user", "?1");
                request.AddHeader("upgrade-insecure-requests", "1");
                request.AddHeader("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/104.0.0.0 Safari/537.36");
                response = client.Execute(request);
                
                cookies = client.CookieContainer.GetCookieHeader(new Uri("https://www.reddit.com/"));
                
                List<String> strList;
                strList = response.Content.Split('\n').ToList();
                
                string pattern = "(accessToken\":\")(.*?\")";
                Regex filter = new Regex(pattern);

                foreach (var line in strList)
                {
                    var match = filter.Match(line.ToString());

                    if (match.Success)
                    {
                        bearerToken = match.ToString().Replace("accessToken\":\"", "").Replace("\"", "");
                    }
                }

                strList.Clear();

                f.dgv.Rows.Add();
                f.dgv.Rows[rowCounter].Cells[2].Value = "BEARER_TOKEN";
                f.dgv.Rows[rowCounter].Cells[3].Value = bearerToken;

                if (response.IsSuccessful)
                {
                    f.dgv.Rows[rowCounter].Cells[4].Style.ForeColor = Color.Green;
                    f.dgv.Rows[rowCounter].Cells[4].Value = "Success";
                }
                else if (!response.IsSuccessful)
                {
                    f.dgv.Rows[rowCounter].Cells[4].Style.ForeColor = Color.Red;
                    f.dgv.Rows[rowCounter].Cells[4].Value = "Failed";
                }

                rowCounter++;
            }
            catch(Exception ex)
            {

            }
        }

        public void UpvoteOptions(Form1 f, RestClient client, RestRequest request, RestResponse response)
        {
            try
            {
                //request = new RestRequest("https://oauth.reddit.com/api/vote?redditWebClient=desktop2x&app=desktop2x-client-production&raw_json=1&gilding_detail=1", Method.Options);
                request.AddHeader("authority", "oauth.reddit.com");
                request.AddHeader("accept", "*/*");
                request.AddHeader("accept-language", "en-US,en;q=0.9");
                request.AddHeader("access-control-request-headers", "authorization,x-reddit-loid,x-reddit-session");
                request.AddHeader("access-control-request-method", "POST");
                request.AddHeader("origin", "https://www.reddit.com");
                request.AddHeader("referer", "https://www.reddit.com/");
                request.AddHeader("sec-fetch-dest", "empty");
                request.AddHeader("sec-fetch-mode", "cors");
                request.AddHeader("sec-fetch-site", "same-site");
                request.AddHeader("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/104.0.0.0 Safari/537.36");
                response = client.Execute(request);

                cookies = client.CookieContainer.GetCookieHeader(new Uri("https://www.reddit.com/")).Replace(" ", "");

                String[] cookieArr = cookies.Split(';');

                redditSession = cookieArr[5].Replace("session_tracker=", "");
                loid = cookieArr[4].Replace("loid=", "");
            }
            catch (Exception ex)
            {

            }
        }

        public void UpvotePost(Form1 f, RestClient client, RestRequest request, RestResponse response)
        {
            //request = new RestRequest("https://oauth.reddit.com/api/vote?redditWebClient=desktop2x&app=desktop2x-client-production&raw_json=1&gilding_detail=1", Method.Post);
            request.AddHeader("authority", "oauth.reddit.com");
            request.AddHeader("accept", "*/*");
            request.AddHeader("accept-language", "en-US,en;q=0.9");
            request.AddHeader("authorization", "Bearer " + bearerToken);
            request.AddHeader("content-type", "application/x-www-form-urlencoded");
            request.AddHeader("origin", "https://www.reddit.com");
            request.AddHeader("referer", "https://www.reddit.com/");
            request.AddHeader("sec-ch-ua", "\".Not/A)Brand\";v=\"99\", \"Google Chrome\";v=\"103\", \"Chromium\";v=\"103\"");
            request.AddHeader("sec-ch-ua-mobile", "?0");
            request.AddHeader("sec-ch-ua-platform", "\"Windows\"");
            request.AddHeader("sec-fetch-dest", "empty");
            request.AddHeader("sec-fetch-mode", "cors");
            request.AddHeader("sec-fetch-site", "same-site");
            request.AddHeader("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/104.0.0.0 Safari/537.36");
            request.AddHeader("x-reddit-loid", loid);
            request.AddHeader("x-reddit-session", redditSession);
            request.AddHeader("Cookie", cookies);
            request.AddParameter("id", "t3_voz5r7");
            request.AddParameter("dir", "1");
            request.AddParameter("api_type", "json");

            response = client.Execute(request);
        }

        public void CommentOptions(Form1 f, RestClient client, RestRequest request, RestResponse response)
        {
            try
            {
                request = new RestRequest("https://oauth.reddit.com/api/comment.json?rtj=only&emotes_as_images=true&redditWebClient=desktop2x&app=desktop2x-client-production&raw_json=1&gilding_detail=1", Method.Options);
                request.AddHeader("authority", "oauth.reddit.com");
                request.AddHeader("accept", "*/*");
                request.AddHeader("accept-language", "en-US,en;q=0.9");
                request.AddHeader("access-control-request-headers", "authorization,x-reddit-loid,x-reddit-session");
                request.AddHeader("access-control-request-method", "POST");
                request.AddHeader("origin", "https://www.reddit.com");
                request.AddHeader("referer", "https://www.reddit.com/");
                request.AddHeader("sec-fetch-dest", "empty");
                request.AddHeader("sec-fetch-mode", "cors");
                request.AddHeader("sec-fetch-site", "same-site");
                request.AddHeader("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/104.0.0.0 Safari/537.36");

                response = client.Execute(request);

                var cookies = client.CookieContainer.GetCookieHeader(new Uri("https://www.reddit.com/")).Replace(" ", "");

                String[] cookieArr = cookies.Split(';');

                redditSession = cookieArr[5].Replace("session_tracker=", "");
                loid = cookieArr[4].Replace("loid=", "");
            }
            catch (Exception ex)
            {

            }
        }

        public void CommentPost(Form1 f, RestClient client, RestRequest request, RestResponse response)
        {
            string comment = "";
            string id = "";

            try
            {
                request = new RestRequest("https://oauth.reddit.com/api/comment.json?rtj=only&emotes_as_images=true&redditWebClient=desktop2x&app=desktop2x-client-production&raw_json=1&gilding_detail=1", Method.Post);
                request.AddHeader("authority", "oauth.reddit.com");
                request.AddHeader("accept", "*/*");
                request.AddHeader("accept-language", "en-US,en;q=0.9");
                request.AddHeader("authorization", "Bearer " + bearerToken);
                request.AddHeader("content-type", "application/x-www-form-urlencoded");
                request.AddHeader("origin", "https://www.reddit.com");
                request.AddHeader("referer", "https://www.reddit.com/");
                request.AddHeader("sec-ch-ua", "\".Not/A)Brand\";v=\"99\", \"Google Chrome\";v=\"104\", \"Chromium\";v=\"104\"");
                request.AddHeader("sec-ch-ua-mobile", "?0");
                request.AddHeader("sec-ch-ua-platform", "\"Windows\"");
                request.AddHeader("sec-fetch-dest", "empty");
                request.AddHeader("sec-fetch-mode", "cors");
                request.AddHeader("sec-fetch-site", "same-site");
                request.AddHeader("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/104.0.0.0 Safari/537.36");
                request.AddHeader("x-reddit-loid", loid);
                request.AddHeader("x-reddit-session", redditSession);
                request.AddHeader("Cookie", cookies);
                request.AddParameter("api_type", "json");
                request.AddParameter("return_rtjson", "true");
                request.AddParameter("thing_id", id);
                request.AddParameter("text", "");
                request.AddParameter("richtext_json", string.Format("{\"document\":[{\"e\":\"par\",\"c\":[{\"e\":\"text\",\"t\":\"{0}\"}]}]}", comment));

                response = client.Execute(request);
            }
            catch (Exception ex)
            {

            }
        }

        public void InboxGet(Form1 f, RestClient client, RestRequest request, RestResponse response)
        {
            try
            {
                var request = new RestRequest("https://old.reddit.com/message/unread/", Method.Get);
                request.AddHeader("authority", "old.reddit.com");
                request.AddHeader("accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.9");
                request.AddHeader("accept-language", "en-US,en;q=0.9");
                request.AddHeader("cookie", "csv=2; pc=ji; " + cookieJar[1] + cookieJar[2] + cookieJar[3] + cookieJar[4] + cookieJar[5] + cookieJar[6]);
                request.AddHeader("referer", "https://old.reddit.com/user/lookdadon197/");
                request.AddHeader("sec-ch-ua", "\"Chromium\";v=\"104\", \" Not A;Brand\";v=\"99\", \"Google Chrome\";v=\"104\"");
                request.AddHeader("sec-ch-ua-mobile", "?0");
                request.AddHeader("sec-ch-ua-platform", "\"Windows\"");
                request.AddHeader("sec-fetch-dest", "document");
                request.AddHeader("sec-fetch-mode", "navigate");
                request.AddHeader("sec-fetch-site", "same-origin");
                request.AddHeader("sec-fetch-user", "?1");
                request.AddHeader("upgrade-insecure-requests", "1");
                request.AddHeader("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/104.0.0.0 Safari/537.36");
                response = client.Execute(request);
                MessageBox.Show(response.IsSuccessful.ToString());
                using (StreamWriter sw = File.CreateText(@"C:\Users\redrum\Desktop\request\contentInboxGet.txt"))
                {
                    sw.Write(response.Content);
                }
                string _cookies = client.CookieContainer.GetCookieHeader(new Uri("https://old.reddit.com/"));
                using (StreamWriter sw = File.CreateText(@"C:\Users\redrum\Desktop\request\inboxGetCookies.txt"))
                {
                    sw.Write(_cookies);
                }
            }
            catch(Exception ex)
            {

            }
        }


        public string CsrfToken
        {
            get { return csrfToken; }
            set { csrfToken = value; }
        }
        public string BearerToken
        {
            get { return bearerToken; }
            set { bearerToken = value; }
        }
    }
}
