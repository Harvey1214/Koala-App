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
        public NavMenu NavMenu { get; set; }

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
    }
}
