using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Dapper;

namespace DataAccessLibrary
{
    class DataAccess<T>
    {
        private List<T> GetData()
        {
            using (IDbConnection connection = new SqlConnection(Helper.GetConnectionString()))
            {
                var output = connection.Query<Event>($"select * from EventsTable where Id = @Id", new { Id = id }).ToList();

                if (output.Count > 0)
                {
                    return output.First();
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
