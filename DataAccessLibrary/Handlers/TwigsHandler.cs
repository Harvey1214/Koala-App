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
            int newTwigId = GetHighestTwigId() + 1;

            string command = "insert into TwigsTable(Id, ProjectId, Title, DueDate, CompletedDate, Priority, Description, State) " +
                "values (@Id, @ProjectId, @Title, @DueDate, @CompletedDate, @Priority, @Description, @State)";
            DataAccess<Twig, object> dataAccess = new DataAccess<Twig, object>();

            int rowsAffected = dataAccess.WriteData(command,
                new { Id = newTwigId, ProjectId = projectId, Title = "New Twig", DueDate = DateTime.MaxValue, CompletedDate = new DateTime(), Priority = 0, Description = "", State = State.NOTSTARTED }); ;

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

        /// <summary>
        /// Finds the highest Twig id in the TwigsTable
        /// </summary>
        /// <returns>Highest Twig Id</returns>
        private int GetHighestTwigId()
        {
            string command = "select * from TwigsTable order by Id desc";
            DataAccess<Twig, object> dataAccess = new DataAccess<Twig, object>();

            List<Twig> allTwigs = dataAccess.GetData(command);
            if (allTwigs.Count > 0)
            {
                return allTwigs[0].Id;
            }
            else
            {
                return 0;
            }
        }
    }
}
