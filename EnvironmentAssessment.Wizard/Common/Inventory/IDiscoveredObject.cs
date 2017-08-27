using System;

namespace EnvironmentAssessment.Common.Inventory
{
    public class IDiscoveredObject : IDisposable
    {
        public new void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {

        }
    }   
}
