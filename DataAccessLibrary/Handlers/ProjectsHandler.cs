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

            string command = "insert into ProjectsTable(UserId, Name, DateCreated, LastOpened) " +
                "values (@UserId, @Name, @DateCreated, @LastOpened)";
            DataAccess<Project, object> dataAccess = new DataAccess<Project, object>();

            int rowsAffected = dataAccess.WriteData(command,
                new { UserId = userId, Name = name, DateCreated = now, LastOpened = now }); ;

            if (rowsAffected == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool UpdateProjectSortBy(Project project)
        {
            string command = "update ProjectsTable set SortBy = @SortBy where Id = @Id";

            DataAccess<Twig, object> dataAccess = new DataAccess<Twig, object>();

            int rowsAffected = dataAccess.WriteData(command,
                new { Id = project.Id, SortBy = project.SortBy });

            if (rowsAffected == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool UpdateProjectShowCompleted(Project project)
        {
            string command = "update ProjectsTable set ShowCompleted = @ShowCompleted where Id = @Id";

            DataAccess<Twig, object> dataAccess = new DataAccess<Twig, object>();

            int rowsAffected = dataAccess.WriteData(command,
                new { Id = project.Id, ShowCompleted = project.ShowCompleted }); ;

            if (rowsAffected == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool UpdateProjectLastOpened(Project project)
        {
            string command = "update ProjectsTable set LastOpened = @LastOpened where Id = @Id";

            DataAccess<Twig, object> dataAccess = new DataAccess<Twig, object>();

            int rowsAffected = dataAccess.WriteData(command,
                new { Id = project.Id, LastOpened = project.LastOpened }); ;

            if (rowsAffected == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool UpdateProjectEditWindow(Project project)
        {
            string command = "update ProjectsTable set EditWindow = @EditWindow where Id = @Id";

            DataAccess<Twig, object> dataAccess = new DataAccess<Twig, object>();

            int rowsAffected = dataAccess.WriteData(command,
                new { Id = project.Id, EditWindow = project.EditWindowDimensions.ToString() }); ;

            if (rowsAffected == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool UpdateProjectRightContainer(Project project)
        {
            string command = "update ProjectsTable set RightContainer = @RightContainer where Id = @Id";

            DataAccess<Twig, object> dataAccess = new DataAccess<Twig, object>();

            int rowsAffected = dataAccess.WriteData(command,
                new { Id = project.Id, EditWindow = project.RightContainerDimensions.ToString() }); ;

            if (rowsAffected == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool UpdateProjectDescriptionFieldWidth(Project project)
        {
            string command = "update ProjectsTable set DescriptionFieldWidth = @DescriptionFieldWidth where Id = @Id";

            DataAccess<Twig, object> dataAccess = new DataAccess<Twig, object>();

            int rowsAffected = dataAccess.WriteData(command,
                new { Id = project.Id, DescriptionFieldWidth = project.DescriptionFieldWidth }); ;

            if (rowsAffected == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool UpdateProjectSearchSortWindowWidth(Project project)
        {
            string command = "update ProjectsTable set SearchSortWindowWidth = @SearchSortWindowWidth where Id = @Id";

            DataAccess<Twig, object> dataAccess = new DataAccess<Twig, object>();

            int rowsAffected = dataAccess.WriteData(command,
                new { Id = project.Id, SearchSortWindowWidth = project.SearchSortWindowWidth }); ;

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
    }
}
