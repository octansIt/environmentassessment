using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using EnvironmentAssessment.Common;
using EnvironmentAssessment.Common.Inventory;

namespace EnvironmentAssessment.Database
{
    public class CDatabaseConnection : IDisposable
    {
        private SQLiteConnection _DBConn;

        public string FileName
        {
            get { return _DBConn.FileName; }
        }
        
        public CDatabaseConnection(string file)
        {
            SQLiteConnection.CreateFile(file);
            _DBConn = new SQLiteConnection("Data Source=" + file + ";Version=3;");
            _DBConn.Open();
        }

        public void Close()
        {
            if (_DBConn != null) { _DBConn.Close(); }
        }

        public bool _DBTryInitialize()
        {
            if (!Core._DatabaseInitialized)
            {
                //Log.Write("[SQLite] CREATE TABLE: ea_objects; ea_object_history; ea_events; ea_event_text; ea_options");
                ExecuteNonQuery("CREATE TABLE ea_objects (uid varchar(36), name varchar(255), ref varchar(36), type int, parent text, created int, accessed int, attributes text)");
                ExecuteNonQuery("CREATE TABLE ea_object_history (uid varchar(36), ref varchar(36), object_id varchar(255), time int, attributes text)");
                ExecuteNonQuery("CREATE TABLE ea_events (uid varchar(36), ref varchar(36), type int, parent text, occurred int, attributes text)");
                ExecuteNonQuery("CREATE TABLE ea_event_text (uid varchar(36), ref varchar(36), type int, text text)");
                ExecuteNonQuery("CREATE TABLE ea_options (uid varchar(36), name varchar(255), type int, value text)");
                Core._DatabaseInitialized = true;
            }
            return Core._DatabaseInitialized;
        }

        internal void AddEntry(CDatabaseEntry entry)
        {
            if (_DBTryInitialize())
            {
                // check if an entry already exists
                ExecuteParameterizedNonQuery("INSERT INTO ea_objects (uid, name, ref, type, parent, created, accessed, attributes) VALUES (@0, @1, @2, @3, @4, @5, @6, @7)", entry.Id, entry.Name, entry.Reference, entry.Type, entry.Parent, entry.Created, entry.Accessed, entry.Attributes);
                // - or -
                // add ea_event and ea_event_text if not already available for event type
            }
        }

        internal void UpdateEntry(CDatabaseEntry entry)
        {
            SQLiteDataReader reader = ExecuteParameterizedReader("SELECT * FROM ea_objects WHERE uid=@0", entry.Id);
            CDiscoveredConfig existingprops = new CDiscoveredConfig();
            while (reader.Read()) // read existing attributes
            {
                if (entry.Reference.ToStringNz() == "") { entry.Reference = reader["ref"].ToStringNz(); }
                if (entry.Created.ToStringNz() == "") { entry.Created= reader["created"].ToStringNz(); }
                if (entry.Accessed.ToStringNz() == "") { entry.Accessed = reader["accessed"].ToStringNz(); }
                if (entry.Type.ToStringNz() == "") { entry.Type = reader["type"].ToStringNz(); }
                existingprops = CDiscoveredConfig.Deserialize(reader["attributes"].ToStringNz());
            }
            if (existingprops.Attributes != null && existingprops.Attributes.Count() > 0)
            {
                CDiscoveredConfig newprops = CDiscoveredConfig.Deserialize(entry.Attributes);
                existingprops.Merge(newprops);
                entry.Attributes = existingprops.Serialize(CDiscoveredAttributes.SerializeAsShortJson);
                ExecuteParameterizedNonQuery("UPDATE ea_objects SET name=@1, ref=@2, type=@3, parent=@4, created=@5, accessed=@6, attributes=@7 WHERE uid=@0", entry.Id, entry.Name, entry.Reference, entry.Type, entry.Parent, entry.Created, entry.Accessed, entry.Attributes);
            }
        }

        public void ExecuteNonQuery(string sql)
        {
            using (SQLiteCommand cmd = new SQLiteCommand(sql, _DBConn))
            {
                cmd.ExecuteNonQuery();
            }
        }

        public SQLiteDataReader ExecuteReader(string sql)
        {
            using (SQLiteCommand cmd = new SQLiteCommand(sql, _DBConn))
            {
                return cmd.ExecuteReader();
            }
        }

        public void ExecuteParameterizedNonQuery(params string[] list)
        {
            string sql = list[0];

            using (SQLiteCommand cmd = new SQLiteCommand(sql, _DBConn))
            {
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = sql;

                for (int i = 1; i < list.Count(); i++)
                {
                    cmd.Parameters.Add(new SQLiteParameter("@" + (i - 1), list[i]));
                }

                cmd.ExecuteNonQuery();
            }
        }

        public SQLiteDataReader ExecuteParameterizedReader(params string[] list)
        {
            string sql = list[0];

            using (SQLiteCommand cmd = new SQLiteCommand(sql, _DBConn))
            {
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = sql;

                for (int i = 1; i < list.Count(); i++)
                {
                    cmd.Parameters.Add(new SQLiteParameter("@" + (i - 1), list[i]));
                }

                return cmd.ExecuteReader();
            }
        }

        internal void UpdateEntry(string uid ="", string refid = "", string name = "", CDiscoveredTypes type = null, string parent = "", int created = 0, int accessed = 0, Dictionary<string, object> attributes = null)
        {
            // if changes occurred to the object save these in ea_object_history
            // including parent, name and attributes and update accessed record
        }

        internal void DeleteEntry(string uid="", CDiscoveredTypes type = null)
        {
            // delete ea_object and ea_object_history
            // - or -
            // delete ea_event and ea_event_text if no one else is using it anymore
        }

        public void Dispose()
        { 
            _DBConn.Dispose();
        }
    }
}
