using EnvironmentAssessment.Common.Inventory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnvironmentAssessment.Collector
{
    class VbrSession : ISession
    {
        public VbrSession(ref CService _Server)
        {
            Server = _Server;
        }

        internal void Disconnect()
        {
            throw new NotImplementedException();
        }

        internal void Connect()
        {
            throw new NotImplementedException();
        }
    }
}
