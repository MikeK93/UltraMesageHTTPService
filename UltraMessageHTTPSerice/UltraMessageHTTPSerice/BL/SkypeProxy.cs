using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SKYPE4COMLib;
using Newtonsoft.Json;

namespace UltraMessageHTTPSerice.BL
{
    public class SkypeProxy
    {
        private Skype skype_machine;

        public SkypeProxy()
        {
            skype_machine = new Skype();
        }

        public bool SendMessage(string key, string message)
        {
            if (skype_machine.Client.IsRunning)
            {
                skype_machine.Attach(6, true);
                try
                {
                    skype_machine.SendMessage(key, message);
                    return true;
                }
                catch (Exception ex) {
                    return false;    
                }
                
            }
            return false;
        }

        public string GetFriends()
        {
            Dictionary<string, string> userList = new Dictionary<string, string>();
            skype_machine = new Skype();
            foreach (User user in skype_machine.Friends)
            {
                // Full name - Value
                // Handle - Key
                userList.Add(user.Handle, user.FullName);
            }
            return JsonConvert.SerializeObject(userList);
        }
    }
}