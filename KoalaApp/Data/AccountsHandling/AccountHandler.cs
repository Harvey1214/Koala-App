using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccessLibrary;
using KoalaApp.Shared;

namespace KoalaApp.Data
{
    public class AccountHandler
    {
        public Sidebar NavMenu { get; set; }

        private UsersHandler UsersHandler = new UsersHandler();
        private CookieSecurityHandler CookieSecurityHandler = new CookieSecurityHandler();

        private User user;
        public User User 
        {
            get
            {
                return user;
            }
            set
            {
                if (NavMenu != null)
                {
                    NavMenu.Update();
                }

                user = value;
            }
        }

        public void HandleCookies(string? cookieContent)
        {
            if (cookieContent == null) return;

            int id;
            bool success = Int32.TryParse(CookieSecurityHandler.DecryptCookie(cookieContent), out id);

            if (success)
            {
                List<User> users = UsersHandler.GetUsers(id).ToList();
                if (users == null) return;
                if (users.Count != 1) return;

                User = users.First();
                if (NavMenu != null) NavMenu.Update();
            }
        }
    }
}
