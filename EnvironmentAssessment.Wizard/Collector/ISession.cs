using EnvironmentAssessment.Common.Inventory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnvironmentAssessment.Collector
{
    public class ISession : IDisposable
    {
        internal CService Server;

        internal bool Completed = false;
        internal bool Started = false;
        internal bool Connected = false;
        internal string Error = "";

        internal List<CSite> SiteInfo = new List<CSite> { }; 
        internal List<CQuery> Queries = new List<CQuery> { };

        public void Dispose()
        {
        }

    }
}
