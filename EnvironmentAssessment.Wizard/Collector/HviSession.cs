using EnvironmentAssessment.Common.Inventory;
using EnvironmentAssessment.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using EnvironmentAssessment.Common.HVAPI;

namespace EnvironmentAssessment.Collector
{
    internal class HviSession : ISession
    {
        internal string SessionID;

        HviClient HVClient = null;
        object HVSession = null;

        public HviSession(ref CService _Server)
        {
            Server = _Server;
        }

        internal List<CServiceConfig> GetHVHosts(int queryid)
        {
            return null;
        }

        internal List<CStorageConfig> GetHVDatastores(int queryid)
        {
            return null;
        }
        private List<CStorageConfig> GetHVVMDisks()
        {
            return null;
        }
        internal List<CServiceConfig> GetHVVMs(int queryid)
        {
            List<CServiceConfig> VMsFound = new List<CServiceConfig> { };
            ManagementObjectCollection vms = null;

            // dont continue if not logged in
            //if (HVSession == null) { return VMsFound; }

            try
            {
                Log.Write("[WMI] Querying virtual machines associated with " + Server.Name.ToUpper());
                vms = HVClient.FindManagedObjects("SELECT * FROM Msvm_ComputerSystem");
            }
            catch (Exception ex) { Log.Write("Cannot query virtual machine information. Error: " + ex.TargetSite + ex.Message); }
            if (vms != null)
            {
                foreach (ManagementObject vm in vms)
                {
                    string properties = "";
                    foreach (PropertyData p in vm.Properties)
                    {
                        properties += p.Name + ",";
                    }
                    Log.Write(vm["ElementName"] + properties);
                }
            }

            return VMsFound;
        }

        internal void Disconnect()
        {
            throw new NotImplementedException();
        }

        internal int Connect()
        {

            int result = 0;

            // make session ID equal to latest query id added, mostly for progress tracking purposes
            SessionID = Queries[Queries.Count - 1].ID;

            if (this.Error.Length > 0) // don't run if we experienced errors before
            { Completed = true; result = -1; return result; }

            if (!Connected)
            {
                Error = ""; // clear session error details
                // try seeing if port is accessible
                Error = CNetwork.CheckPortStatus(Server.IP, HviClient.DefaultPort);

                if (Error.Length == 0)
                {
                    HVClient = new HviClient();
                    if (Server.UserName == Environment.UserDomainName + "\\" + Environment.UserName) { HVSession = HVClient.LoginWithCurrentCredentials(this); }
                    else { HVSession = HVClient.Login(this); } // otherwise use username and password
                }
            }
            return result;
        }
    }
}
