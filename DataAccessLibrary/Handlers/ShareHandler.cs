using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLibrary
{
    public class ShareHandler
    {
        public bool Share(int projectId, int userId)
        {
            string command = "insert into CollaborationsTable(ProjectId, UserId) values (@ProjectId, @UserId)";
            DataAccess<Collaboration, object> dataAccess = new DataAccess<Collaboration, object>();

            int rowsAffected = dataAccess.WriteData(command, new { ProjectId = projectId, UserId = userId });

            if (rowsAffected == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Collaboration> GetCollaborations(int projectId)
        {
            string command = "select * from CollaborationsTable where ProjectId = @ProjectId";
            DataAccess<Collaboration, object> dataAccess = new DataAccess<Collaboration, object>();
            
            List<Collaboration> collaborationsFound = dataAccess.GetData(command, new { ProjectId = projectId });
            return collaborationsFound;
        }

        public List<Collaboration> GetCollaborationsWithUser(int userId)
        {
            string command = "select * from CollaborationsTable where UserId = @UserId";
            DataAccess<Collaboration, object> dataAccess = new DataAccess<Collaboration, object>();

            List<Collaboration> collaborationsFound = dataAccess.GetData(command, new { UserId = userId });
            return collaborationsFound;
        }
    }
}
