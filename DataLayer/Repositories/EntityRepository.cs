using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories
{
    abstract class EntityRepository<Entity>
    {
        private DBConnection connection;
        protected Dictionary<string, object> parameters;

        protected string querySelectAll;
        protected string querySelectAllWithId;
        protected string querySelectWithId;

        protected EntityRepository()
        {
            Init();
        }

        private void Init()
        {
            querySelectAll = DefineSelectAll();
            querySelectAllWithId = DefineSelectAllWithId();
            querySelectWithId = DefineSelectWithId();
        }

        internal abstract string DefineSelectAll();
        internal abstract string DefineSelectAllWithId();
        internal abstract string DefineSelectWithId();

        protected bool ExecuteQuery(string query)
        {
            using (var conn = connection.GetConnection())
            {
                using (var command = conn.CreateCommand())
                {
                    command.CommandText = query;
                    command.CommandType = CommandType.Text;

                    foreach (var parameter in parameters)
                    {
                        var key = parameter.Key;
                        var value = parameter.Value;
                        command.Parameters.AddWithValue(key, value);
                    }

                    try
                    {
                        var affectedRowsCount = command.ExecuteNonQuery();
                        if (affectedRowsCount <= 0)
                        {
                            return false;
                        }
                        return true;
                    }
                    catch (Exception ex)
                    {
                        return false;
                    }
                }
            }
        }
        protected DataTable ExecuteSelect(string query)
        {
            using (var conn = connection.GetConnection())
            {
                using (var command = conn.CreateCommand())
                {
                    command.CommandText = query;
                    command.CommandType = System.Data.CommandType.Text;

                    foreach (var parameter in parameters)
                    {
                        var key = parameter.Key;
                        var value = parameter.Value;
                        command.Parameters.AddWithValue(key, value);
                    }

                    try
                    {
                        var dataTable = new DataTable();
                        var adapter = new SqlDataAdapter();
                        adapter.Fill(dataTable);

                        return dataTable;
                    }
                    catch (Exception ex)
                    {
                        return null;
                    }
                }
            }
        }
    }
}
