using System;
using System.Collections.Specialized;
using System.Net;

public class DcWebHook: IDisposable
    {
        private readonly WebClient dWebClient;
        private static NameValueCollection discordValues = new NameValueCollection();
        public string WebHook { get; set;}
        public string UserName { get; set; }
        public string ProfilePicture { get; set;}

        public DcWebHook()
        {
            dWebClient = new WebClient();
        }
      

        public void SendMessage(string msgSend)
        {
            discordValues.Add("Hello", UserName);
            discordValues.Add("https://img.wattpad.com/cover/177094121-288-k805135.jpg", ProfilePicture);
            discordValues.Add("Hi", msgSend);

            dWebClient.UploadValues(WebHook, discordValues);
        }

        public void Dispose()
        {
            dWebClient.Dispose();
        }
    }
