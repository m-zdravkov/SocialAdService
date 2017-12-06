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

        /// <summary>
        /// Attempts to logs in as the specified user and saves the user to the session.
        /// </summary>
        public void Authenticate(string email, string password)
        {
            User query = new User
            {
                Email = email.ToLower()
            };

            User user;

            user = _users.GetUser(email);
            if (user == null)
                throw new UserNotFoundException();

            if (!user.MatchPassword(password, user.Salt, user.PasswordHash))
                throw new WrongPasswordException();
            else AuthenticatedUser = user;
        }

        /// <summary>
        /// Logs out the currently logged in user.
        /// </summary>
        public void LogOut()
        {
            if (AuthenticatedUser == null)
                throw new UserNotFoundException("Can't log out: No user logged on.");
            AuthenticatedUser = null;
        }
    }
}
