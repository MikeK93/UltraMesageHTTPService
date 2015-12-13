using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using UltraMessageHTTPSerice.BL;

namespace UltraMessageHTTPSerice
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "SkypeProxyService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select SkypeProxyService.svc or SkypeProxyService.svc.cs at the Solution Explorer and start debugging.
    public class SkypeProxyService : ISkypeProxyService
    {
        private SkypeProxy skypeClient = new SkypeProxy();
        private EmailProxy emailClient = new EmailProxy();

        //public Dictionary<string, string> GetFriends()
        public string GetFriends()
        {
            return skypeClient.GetFriends();
        }

        public bool SendMessage(string friendId, string message)
        {
            return skypeClient.SendMessage(friendId, message);
        }

        public bool SendEmail(string email, string subject, string body) {
            return emailClient.SendMessage(email, subject, body);
        }
    }
}
