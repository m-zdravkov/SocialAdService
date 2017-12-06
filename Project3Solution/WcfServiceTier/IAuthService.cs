using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using Model;

namespace WcfServiceTier
{
    [ServiceContract]
    public interface IAuthService
    {
        [OperationContract]
        bool Login(string email, string password);

        [OperationContract]
        bool Register(string email, string name, string password, string pictureUrl);

        [OperationContract]
        IList<Ad> GetAds(int skip, int amount);

        [OperationContract]
        IList<Ad> GetAdsWithinLocation(int skip, int amount, string location);

        [OperationContract]
        IList<Ad> FindAds(int skip, int amount, string location, string searchQuery, AdType type);

        [OperationContract]
        IList<Comment> GetAdReplies(int skip, int amount, string adId);
    }
}
