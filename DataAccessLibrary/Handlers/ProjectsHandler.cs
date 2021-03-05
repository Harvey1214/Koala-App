using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLibrary
{
    public class ProjectsHandler
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="userId"></param>
        /// <returns>All projects of the user with specified userId</returns>
        public List<Project> GetProjectsOfUser(int userId)
        {
            string command = "select * from ProjectsTable where UserId = @UserId";
            DataAccess<Project, object> dataAccess = new DataAccess<Project, object>();

            List<Project> ProjectsFound = dataAccess.GetData(command, new { UserId = userId });
            return ProjectsFound;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>A project with specified Id</returns>
        public List<Project> GetProject(int id)
        {
            string command = "select * from ProjectsTable where Id = @Id";
            DataAccess<Project, object> dataAccess = new DataAccess<Project, object>();

            List<Project> ProjectsFound = dataAccess.GetData(command, new { Id = id });
            return ProjectsFound;
        }

        /// <summary>
        /// Inserts new project into the ProjectsTable
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="name"></param>
        /// <returns>True if operation was successful, returns false if otherwise</returns>
        public bool InsertProject(int userId, string name)
        {
            DateTime now = DateTime.Now;
            int newProjectId = GetHighestProjectId() + 1;

            string command = "insert into ProjectsTable(Id, UserId, Name, DateCreated, LastOpened) " +
                "values (@Id, @UserId, @Name, @DateCreated, @LastOpened)";
            DataAccess<Project, object> dataAccess = new DataAccess<Project, object>();

            int rowsAffected = dataAccess.WriteData(command,
                new { Id = newProjectId, UserId = userId, Name = name, DateCreated = now, LastOpened = now }); ;

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
        /// <returns>All projects in the ProjectsTable</returns>
        public List<Project> GetAllProjects()
        {
            string command = "select * from ProjectsTable";
            DataAccess<Project, object> dataAccess = new DataAccess<Project, object>();

            return dataAccess.GetData(command);
        }

        /// <summary>
        /// Finds the highest project id in the ProjectsTable
        /// </summary>
        /// <returns>Highest project Id</returns>
        private int GetHighestProjectId()
        {
            string command = "select * from ProjectsTable order by Id desc";
            DataAccess<Project, object> dataAccess = new DataAccess<Project, object>();

            List<Project> allProjects = dataAccess.GetData(command);
            if (allProjects.Count > 0)
            {
                return allProjects[0].Id;
            }
            else
            {
                return 0;
            }
        }
    }
}
