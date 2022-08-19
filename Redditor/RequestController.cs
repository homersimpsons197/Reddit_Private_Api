using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Redditor
{
    internal class RequestController
    {
        Form1 f;

        Reddit_Api api = new Reddit_Api();

        RestClient client;
        RestRequest request;
        RestResponse response;

        private const string restClient = "https://www.reddit.com/";
        private const string getRequestCsrfToken = "https://www.reddit.com/account/login";
        private const string postRequestLogin = "https://www.reddit.com/account/login";
        private const string requestUpvote = "https://oauth.reddit.com/api/vote?redditWebClient=desktop2x&app=desktop2x-client-production&raw_json=1&gilding_detail=1";
        private const string requestComment = "https://oauth.reddit.com/api/comment.json?rtj=only&emotes_as_images=true&redditWebClient=desktop2x&app=desktop2x-client-production&raw_json=1&gilding_detail=1";
        private const string getRequestInbox = "https://old.reddit.com/message/unread/";

        public RequestController(Form1 f)
        {
            this.f = f;
        }

        public void Login()
        {
            api.CsrfGet(f, client = new RestClient(restClient), request = new RestRequest(getRequestCsrfToken, Method.Get), response);
            api.LoginReq(f, client = new RestClient(restClient), request = new RestRequest(postRequestLogin, Method.Post), response);
            api.BearerTokenGet(f, client = new RestClient(restClient), request = new RestRequest(restClient, Method.Get), response);
        }

        public void UpVote()
        {
            api.UpvoteOptions(f, client = new RestClient(restClient), request = new RestRequest(requestUpvote, Method.Options), response);
            api.UpvotePost(f, client = new RestClient(restClient), request = new RestRequest(requestUpvote, Method.Post), response);
        }

        public void Comment()
        {
            api.CommentOptions(f, client = new RestClient(restClient), request = new RestRequest(requestComment, Method.Options), response);
            api.CommentPost(f, client = new RestClient(restClient), request = new RestRequest(requestComment, Method.Post), response);
        }

        public void Inbox()
        {
            api.InboxGet(f, client = new RestClient(restClient), request = new RestRequest(getRequestInbox, Method.Get), response);
        }
    }
}
