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
            return TwigsFound;
        }

        /// <summary>
        /// Inserts a new Twig into the TwigsTable
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="title"></param>
        /// <returns>True if operation was successful, returns false if otherwise</returns>
        public bool InsertTwig(int projectId)
        {
            DateTime now = DateTime.Now;

            string command = "insert into TwigsTable(ProjectId, Title, DueDate, Priority, Description, State) " +
                "values (@ProjectId, @Title, @DueDate, @Priority, @Description, @State)";
            DataAccess<Twig, object> dataAccess = new DataAccess<Twig, object>();

            int rowsAffected = dataAccess.WriteData(command,
                new {ProjectId = projectId, Title = "New Twig", DueDate = DateTime.Now.AddYears(100), Priority = 0, Description = "", State = State.NOTSTARTED }); ;

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
        public bool UpdateTwig(Twig twig)
        {
            string command = "update TwigsTable set Title = @Title, DueDate = @DueDate, CompletedDate = @CompletedDate, Priority = @Priority, Description = @Description, State = @State where Id = @Id";
            DataAccess<Twig, object> dataAccess = new DataAccess<Twig, object>();

            int rowsAffected = dataAccess.WriteData(command,
                new { Id = twig.Id, Title = twig.Title, DueDate = twig.DueDate, CompletedDate = twig.CompletedDate, Priority = twig.Priority, Description = twig.Description, State = twig.State }); ;

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
