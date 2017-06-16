using System;

namespace EnvironmentAssessment.Common.Inventory
{
    public class IDiscoveredObject : IDisposable
    {
        /* public bool IsChanged = false;
        public DateTime CurrentQueryTime;
        public string CurrentObjectHash;
        public DateTime LastQueryTime;
        public string LastObjectHash; */

        public new void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            //CurrentObjectHash = null;
            //LastObjectHash = null;
        }
    }   
}
