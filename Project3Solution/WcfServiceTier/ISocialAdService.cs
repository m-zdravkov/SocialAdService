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
        UserDTO GetAuthenticatedUser();

        [OperationContract]
        void LogOut();

        [OperationContract]
        UserDTO GetUser(string userId);

        [OperationContract]
        int CountUsers();

        [OperationContract]
        IList<UserDTO> GetUsers(int skip, int amount);
    }
}
