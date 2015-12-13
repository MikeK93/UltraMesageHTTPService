using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace UltraMessageHTTPSerice
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ISkypeProxyService" in both code and config file together.
    [ServiceContract]
    public interface ISkypeProxyService
    {
    //{
    //    [OperationContract]
    //    Dictionary<string, string> GetFriends();

        [OperationContract]
        string GetFriends();

        [OperationContract]
        bool SendMessage(string friendId, string message);

        [OperationContract]
        bool SendEmail(string email, string subject, string body);
    }
}
