using EnvironmentAssessment.Collector;
using System;
using System.Collections.Generic;
using System.Net;
using EnvironmentAssessment.Common.VimApi;

namespace EnvironmentAssessment.Common.Inventory
{
    public class CServiceType : IDisposable
    {
        private int _type;

        private static string[] Values = { "VMware vCenter", "VMware ESX", "Microsoft Hyper-V", "KVM", "Microsoft SCVMM", "Microsoft SCOM", "Veeam Backup & Replication", "Veeam ONE", "Azure Account", "AWS Account", "GCE Account", "Physical Server", "Physical Workstation", "Domain Controller" };

        public const int VCenterServer = 0;
        public const int ESXServer = 1;
        public const int HYVServer = 2;
        public const int KVMServer = 3;
        public const int SCVMMServer = 4;
        public const int SCOMServer = 5;
        public const int VBRServer = 6;
        public const int VONEServer = 7;
        public const int AzureAccount = 8;
        public const int AWSAccount = 9;
        public const int GCEAccount = 10;
        public const int PhysicalServer = 11;
        public const int PhysicalWorkstation = 12;
        public const int DomainServer = 13;

        public CServiceType(string s = "")
        {
            _type = Array.IndexOf(Values, s);
        }
        public CServiceType(int t = -1)
        {
            _type = t;
        }

        public void Dispose()
        {
            Values = null;
        }

        public override string ToString()
        {
            return Values[_type];
        }

        public static implicit operator int(CServiceType x)
        {
            int i = x._type;
            return i;
        }
    }

    public class CService : IDiscoveredObject
      {
            public IPAddress IP { get; set; }
            //private IPAddress[] ServerIPs; // zzz - for future in case that ip address listed is not the one we should try

            internal string _name = "";
            public string Name {
                get {
                    return _name;
                }
                set {
                    IPHostEntry hostInfo = null;
                    try
                    {
                        if (value.Length != 0)
                        {
                            hostInfo = Dns.Resolve(value.Trim()); // zzz - using this on purpose. don't want IPv6 support right now, as it would mess up site discovery logic
                            _name = hostInfo.HostName.ToString();
                            IP = hostInfo.AddressList[0];
                        }
                    }
                    catch { /* do nothing - should end up with old name and IP address */ }
                }
            }

            public string UserName { get; set; }
            public string UserPassword;
            //public static string Parent;
            public CServiceType Type { get; set; }
            public string Version { get; internal set; }

            public CSession Session = null;
            public string Id;
            
            public CService(string name, int type, string user = "", string password = "")
            {
                CServiceType t = new CServiceType(type);
                _CServer(name, t, user, password);
            }

            private void _CServer(string name, CServiceType type, string user = "", string password = "")
            {
                // initialize values
                Name = name; // ip resolution handled by get set function
                Id = CFunctions.GenerateUID();
                if (user == "") { UserName = Environment.UserDomainName + "\\" + Environment.UserName; }
                else { UserName = user; }

                Type = type;
                UserPassword = password;
            }

            public void Initialize()
            {
                if (Session != null) { Session.Dispose(); }
                Session = new CSession(this);
            }

        public new void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected new virtual void Dispose(bool disposing)
        {
            if (disposing) //free managed resources if any
            {
                if (Session != null) { Session.Dispose(); }
            }
            // free native resources if there are any.  
            IP = null;
            Name = null;
        }

    }

    
    }
