using System;
using System.Net;
using System.Net.Sockets;

namespace EnvironmentAssessment.Common.Inventory
{
    class CNetwork : IDiscoveredObject
    {
        public class Protocols : IDisposable
        { 
        private int _protocol;

        private static string[] ProtocolTypes = { "HTTP", "VMRDP", "RPC" };

        public const int HTTP = 0;
        public const int VMRDP = 1;
        public const int RPC = 2;

        public Protocols(string s = "")
        {
                _protocol = Array.IndexOf(ProtocolTypes, s);
        }
        public Protocols(int t = -1)
        {
                _protocol = t;
        }

        public void Dispose()
        {
            ProtocolTypes = null;
        }

        public override string ToString()
        {
            return ProtocolTypes[_protocol];
        }

        public static implicit operator int(Protocols x)
        {
            int i = x._protocol;
            return i;
        }
        }

        public bool IsChanged = false;
        //public DateTime CurrentQueryTime;
        //public string CurrentObjectHash;
        //public DateTime LastQueryTime;
        //public string LastObjectHash;
        public int ID;
        public string UID;

        public new void Dispose()
        {

        }

        internal static string IPToStringNz(System.Net.IPAddress ip)
        {
            if (ip != null)
            {
                return ip.ToString();
            }
            return "";
        }

        internal static string ProtocolToStringNz(Protocols protocol)
        {
            if (protocol != null)
            {
                return protocol.ToString();
            }
            return "";
        }

        static internal string CheckPortStatus(IPAddress ip, ushort port)
        {
            string error = "";
            string strLocalIPs = "";
            bool skip = false;

            // check if ip address is local if so skip this step
            IPAddress[] localIPs = Dns.GetHostAddresses(Dns.GetHostName());

            foreach (IPAddress localIP in localIPs)
            {
                strLocalIPs += localIP.ToString() + ",";
                if (localIP.Equals(ip))
                {
                    skip = true;
                }
            }

            if (!skip)
            {
                Log.Write(CFunctions.StringReplace("Checking port connectivity before logon. Connecting to remote machine ({0}) from local machine with addresses ({1}).", ip.ToString(), strLocalIPs), Log.Verbosity.Debug);
                using (TcpClient client = new TcpClient())
                {
                    var result = client.BeginConnect(ip, port, null, null);
                    var success = result.AsyncWaitHandle.WaitOne(TimeSpan.FromMilliseconds(COptions.Connection_Timeout));
                    if (!success)
                    {
                        error = CFunctions.StringReplace("A connection timeout occurred, make sure {0}:{1} is available.", ip.ToString(), port.ToString());
                    }
                }
            }
            return error;
        }
    }
}
