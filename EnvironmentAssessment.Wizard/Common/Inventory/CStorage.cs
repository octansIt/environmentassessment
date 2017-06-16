using System;
using System.Collections.Generic;

namespace EnvironmentAssessment.Common.Inventory
{
    internal class CStorageConfig : IDiscoveredObject
    {
        /* public bool IsChanged = false;
        public DateTime CurrentQueryTime;
        public string CurrentObjectHash;
        public DateTime LastQueryTime;
        public string LastObjectHash; */
        public int ID;
        public string UID;

        internal string Name;
        internal string Details;
        internal string FullPath;
        internal string _DSRef;
        internal List<string> Owner;

        internal bool Thin;
        internal bool Local;
        internal string Mode;
        internal string Type;
        internal long Used;
        internal long Allocated;
        internal string Vendor;
        internal string Model;
        internal CSite Site;
        internal List<string> Children = new List<string> { };

        public new void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposing) //free managed resources if any
            {
                if (Site != null) { Site.Dispose(); }
            }
            // free native resources if there are any.  
            Children.Clear();
            Children = null;
        }

        public string Cluster;
        public string Datacenter;

        public CDiscoveredState State { get; internal set; }
    }
}
