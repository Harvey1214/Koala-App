using System;
using System.Collections.Generic;
using System.Text;
using Dapper;

namespace DataAccessLibrary
{
    public class TwigsHandler
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="projectId"></param>
        /// <returns>A list of twigs with the specified projectId</returns>
        public List<Twig> GetTwigsOfProject(int projectId)
        {
            string command = "select * from TwigsTable where ProjectId = @ProjectId";
            DataAccess<Twig, object> dataAccess = new DataAccess<Twig, object>();

            List<Twig> TwigsFound = dataAccess.GetData(command, new { ProjectId = projectId });
            if (TwigsFound != null) TwigsFound.ForEach(o => o.Decrypt());
            return TwigsFound;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>A list of all twigs with the specified ProjectId</returns>
        public List<Twig> GetTwig(int id)
        {
            string command = "select * from TwigsTable where Id = @Id";
            DataAccess<Twig, object> dataAccess = new DataAccess<Twig, object>();

            List<Twig> TwigsFound = dataAccess.GetData(command, new { Id = id });
            if (TwigsFound != null) TwigsFound.ForEach(o => o.Decrypt());
            return TwigsFound;
        }

        /// <summary>
        /// Inserts a new Twig into the TwigsTable
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="title"></param>
        /// <returns>True if operation was successful, returns false if otherwise</returns>
        public bool InsertTwig(int projectId, int? parentId = null)
        {
            DateTime now = DateTime.Now;

            string command = "insert into TwigsTable(ProjectId, Title, DueDate, Priority, Description, State, ParentId, ShowChildren) " +
                "values (@ProjectId, @Title, @DueDate, @Priority, @Description, @State, @ParentId, @ShowChildren)";
            DataAccess<Twig, object> dataAccess = new DataAccess<Twig, object>();

            int rowsAffected = dataAccess.WriteData(command,
                new {ProjectId = projectId, Title = Security.Encrypt("New Twig"), DueDate = DateTime.Now, Priority = 0, Description = "", State = State.NOTSTARTED, ParentId = parentId, ShowChildren = true }); ;

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
        /// Removes the twig with specified Id from the TwigsTable
        /// </summary>
        /// <param name="id"></param>
        /// <returns>True if operation was successful, false otherwise</returns>
        public bool RemoveTwig(int id)
        {
            string command = "delete from TwigsTable where Id = @Id";
            DataAccess<Twig, object> dataAccess = new DataAccess<Twig, object>();

            int rowsAffected = dataAccess.WriteData(command, new { Id = id });

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
        /// Updates the twig values to the specified twig
        /// </summary>
        /// <param name="twig"></param>
        /// <returns>True if the operation was successful, returns false otherwise</returns>
        public bool UpdateTwig(Twig twigToUpdate)
        {
            Twig twig = twigToUpdate.Copy();
            twig.Encrypt();

            string command = "update TwigsTable set Title = @Title, Priority = @Priority, State = @State";
            if (twig.Description != null)
                command += ", Description = @Description";
            command += " where Id = @Id";

            DataAccess<Twig, object> dataAccess = new DataAccess<Twig, object>();

            int rowsAffected = dataAccess.WriteData(command,
                new { Id = twig.Id, Title = twig.Title, Priority = twig.Priority, Description = twig.Description, State = twig.State }); ;

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
        /// Updates the ShowChildren column of a twig
        /// </summary>
        /// <param name="twig"></param>
        /// <returns>True if the operation was successful, false otherwise</returns>
        public bool UpdateTwigShowChildren(Twig twig)
        {
            string command = "update TwigsTable set ShowChildren = @ShowChildren where Id = @Id";
            DataAccess<Twig, object> dataAccess = new DataAccess<Twig, object>();

            int rowsAffected = dataAccess.WriteData(command,
                new { Id = twig.Id, ShowChildren = twig.ShowChildren }); ;

            if (rowsAffected == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool UpdateTwigParent(Twig twig)
        {
            string command = "update TwigsTable set ParentId = @ParentId where Id = @Id";
            DataAccess<Twig, object> dataAccess = new DataAccess<Twig, object>();

            int rowsAffected = dataAccess.WriteData(command,
                new { Id = twig.Id, ParentId = twig.ParentId }); ;

            if (rowsAffected == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool UpdateTwigDueDate(Twig twig)
        {
            if (twig.DueDate == null || twig.DueDate.Year < 1800 || twig.DueDate.Year > 9000)
            {
                return false;
            }

            string command = "update TwigsTable set DueDate = @DueDate where Id = @Id";

            DataAccess<Twig, object> dataAccess = new DataAccess<Twig, object>();

            int rowsAffected = dataAccess.WriteData(command,
                new { Id = twig.Id, DueDate = twig.DueDate }); ;

            if (rowsAffected == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool UpdateTwigCompletedDate(Twig twig)
        {
            if (twig.CompletedDate.HasValue)
            {
                if (twig.CompletedDate.Value.Year < 1800 || twig.CompletedDate.Value.Year > 9000)
                {
                    return false;
                }
            }

            string command = "update TwigsTable set CompletedDate = @CompletedDate where Id = @Id";
            DataAccess<Twig, object> dataAccess = new DataAccess<Twig, object>();

            int rowsAffected = dataAccess.WriteData(command,
                new { Id = twig.Id, CompletedDate = twig.CompletedDate }); ;

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
        /// <returns>All Twigs in the TwigsTable</returns>
        public List<Twig> GetAllTwigs()
        {
            string command = "select * from TwigsTable";
            DataAccess<Twig, object> dataAccess = new DataAccess<Twig, object>();

            return dataAccess.GetData(command);
        }

        public int GetLastId()
        {
            string command = "select max(Id) from TwigsTable";
            DataAccess<int, object> dataAccess = new DataAccess<int, object>();

            return dataAccess.GetData(command)[0];
        }
    }
}
