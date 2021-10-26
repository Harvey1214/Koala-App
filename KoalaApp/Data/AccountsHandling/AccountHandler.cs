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

#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
        public void HandleCookies(string? cookieContent)
#pragma warning restore CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
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
