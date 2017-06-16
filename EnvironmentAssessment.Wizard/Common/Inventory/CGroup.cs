using System;
using System.Collections.Generic;

namespace EnvironmentAssessment.Common.Inventory
{
    public class CGroup : IDiscoveredObject
    {
        public bool IsChanged = false;
        //public DateTime CurrentQueryTime;
        //public string CurrentObjectHash;
        //public DateTime LastQueryTime;
        //public string LastObjectHash;

        public string Name;
        public string Path;
        public string Location;
        public string Description;
        public int ID;
        public string UID;
        public CGroupConfig Details = new CGroupConfig();

        public new void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected new virtual void Dispose(bool disposing)
        {
            if (disposing) //free managed resources if any
            {
                if (Details != null) { Details.Dispose(); }
            }
            // free native resources if there are any.  
            Name = null;
            Path = null;
            Location = null;
            Description = null;
        }
    }
    public class CGroupConfig : IDisposable
    {
        internal int Hosts = 0;
        internal List<string> HostOperatingSystems = new List<string> { };
        internal int HostSockets = 0;
        internal int Datastores = 0;
        internal long[] DatastoreUsage = new long[] { 0, 0 };
        internal List<string> DatastoreTypes = new List<string> { };
        internal int VMs = 0;
        internal long[] VMUsageReported = new long[] { 0, 0 };
        internal long[] VMUsageActual = new long[] { 0, 0 };
        internal List<string> GuestOperatingSystems = new List<string> { };
        internal long[] VMThinUsage = new long[] { 0, 0 };
        internal long[] VMThickUsage = new long[] { 0, 0 };
        //internal List<string> VMDiskModes = new List<string> { };

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposing) //free managed resources if any
            {

            }
            // free native resources if there are any.  
            HostOperatingSystems = null;
            DatastoreUsage = null;
            DatastoreTypes = null;
            VMUsageReported = null;
            VMUsageActual = null;
            GuestOperatingSystems = null;
            VMThinUsage = null;
            VMThickUsage = null;
        }
    }
}
