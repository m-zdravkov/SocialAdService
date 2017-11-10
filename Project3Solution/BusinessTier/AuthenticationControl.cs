using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace BusinessTier
{
    public class AuthenticationControl
    {
        private static AuthenticationControl _instance;

        private UserControl _users = UserControl.GetInstance();
        public User AuthenticatedUser { get; private set; }

        public static AuthenticationControl GetInstance()
        {
            if (_instance == null)
                _instance = new AuthenticationControl();
            return _instance;
        }

        private AuthenticationControl() { }

        public void Authenticate(string email, string password)
        {
            User query = new User
            {
                Email = email
            };
            
            User user = _users.GetUser(query);

            if (user == null)
                throw new UserNotFoundException();

            if (!user.MatchPassword(password, user.Salt, user.PasswordHash))
                throw new WrongPasswordException();
            else AuthenticatedUser = user;
        }
    }
}
