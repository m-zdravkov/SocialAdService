using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceTier
{
    [ServiceContract]
    public interface ISocialAdService
    {
        [OperationContract]
        void Register(string email, string password, string name, string pictureURL);

        [OperationContract]
        void Authenticate(string email, string password);

        [OperationContract]
        User GetAuthenticatedUser();

        [OperationContract]
        void LogOut();

        [OperationContract]
        User GetUser(string userId);

        [OperationContract]
        int CountUsers();

        [OperationContract]
        IList<User> GetUsers(int skip, int amount);

        [OperationContract]
        int GetData();

        [OperationContract]
        IList<Ad> FetchAds(int skip, int amount);

        [OperationContract]
        void PostAd(string title, string content, string location);
    }
}
