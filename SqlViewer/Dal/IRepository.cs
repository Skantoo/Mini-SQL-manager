using SqlViewer.Models;
using System.Collections.Generic;
using System.Data;

namespace SqlViewer.Dal
{
    interface IRepository
    {
        DataSet CreateDataset(DBEntity entity);
        IEnumerable<Column> GetColumns(DBEntity dBEntity);
        IEnumerable<Database> GetDatabases();
        IEnumerable<DBEntity> GetDBEntities(Database database, DBEntityType entityType);
        IEnumerable<Procedure> GetProcedures(Database database);
        void LogIn(string server, string username, string password);
        DataSet ExecuteSQLCommand(string command, string selectedDatabase);
        int ExecuteNonQueryCommand(string command);
        
    }
}