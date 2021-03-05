using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLibrary
{
    public class UsersHandler
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="email"></param>
        /// <returns>A list of users with the specified email address</returns>
        public List<User> GetUsers(string email)
        {
            string command = "select * from UsersTable where Email = @Email";
            DataAccess<User, object> dataAccess = new DataAccess<User, object>();

            List<User> usersFound = dataAccess.GetData(command, new { Email = email });
            return usersFound;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>A list of users with the specified Id</returns>
        public List<User> GetUsers(int id)
        {
            string command = "select * from UsersTable where Id = @Id";
            DataAccess<User, object> dataAccess = new DataAccess<User, object>();

            List<User> usersFound = dataAccess.GetData(command, new { Id = id });
            return usersFound;
        }

        /// <summary>
        /// Inserts a new user into the UsersTable
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns>True if operation was successful, returns false otherwise</returns>
        public bool InsertUser(string email, string password)
        {
            int newUserId = GetHighestUserId() + 1;
            string command = "insert into UsersTable(Id, Email, Password) values (@Id, @Email, @Password)";
            DataAccess<User, object> dataAccess = new DataAccess<User, object>();

            int rowsAffected = dataAccess.WriteData(command, new { Id = newUserId, Email = email, Password = password });

            if (rowsAffected == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>A list of all users in the UsersTable</returns>
        public List<User> GetAllUsers()
        {
            string command = "select * from UsersTable";
            DataAccess<User, object> dataAccess = new DataAccess<User, object>();

            return dataAccess.GetData(command);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>The highest Id in the UsersTable</returns>
        private int GetHighestUserId()
        {
            string command = "select * from UsersTable order by Id desc";
            DataAccess<User, object> dataAccess = new DataAccess<User, object>();

            List<User> allUsers = dataAccess.GetData(command);
            if (allUsers.Count > 0)
            {
                return allUsers[0].Id;
            }
            else
            {
                return 0;
            }
        }
    }
}
