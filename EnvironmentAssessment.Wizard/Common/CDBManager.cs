/* using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;

namespace EnvironmentAssessment.Common
{
    class CDBManager
    {
        SQLiteConnection _Conn;

        internal void Initialize()
        {
            CFunctions.CreateFolderIfNotExist(Core.DatabasePath);
            string strDBFile = Core.DatabasePath + "\\" + Core._StartTime + ".sqlite";
            SQLiteConnection.CreateFile(strDBFile);
            _Conn = new SQLiteConnection("Data Source=" + strDBFile + ";Version=3;");
            _Conn.Open();
            ExecuteNonQuery("CREATE TABLE ea_objects (uid varchar(36), name varchar(255), type int, parent varchar(36), created int, accessed int, attributes text)");
            ExecuteNonQuery("CREATE TABLE ea_object_history (uid varchar(36), object_id varchar(255), time int, attributes text)");
            ExecuteNonQuery("CREATE TABLE ea_events (uid varchar(36), type int, parent varchar(255), occurred int, attributes text)");
            ExecuteNonQuery("CREATE TABLE ea_event_text (uid varchar(36), type int, text text)");
        }

        private void ExecuteNonQuery(string sql)
        {
            using (SQLiteCommand cmd = new SQLiteCommand(sql, _Conn))
            { 
                cmd.ExecuteNonQuery();
            }
        }
    }
} */