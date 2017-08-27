using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace EnvironmentAssessment.Common.Inventory
{
    public class CSite : IDiscoveredObject
    {

        public List<String> Subnets = new List<String> { };

        public string Location { get; private set; }
        public string Path { get; private set; }
        public string Description { get; private set; }
        public string Name { get; private set; }

        public CSite(string name, string adspath, string location, string description)
        {
            Name = name;
            Path = adspath;
            Location = location;
            Description = description;
        }

        public override string ToString()
        {
            return this.Name;
        }

        public static CSite Resolve(IPAddress IPAddr, List<CSite> SiteList)
        {
            if ((IPAddr != null) && (SiteList != null))
            {
                for (int i = 0; i < SiteList.Count(); i++)
                {
                    for (int j = 0; j < SiteList[i].Subnets.Count; j++)
                    {
                        if (InSubnet(IPAddr, SiteList[i].Subnets[j]))
                        {
                            Log.Write("Server IP address: " + IPAddr.ToString() + " belongs in site: " + SiteList[i].Name, Log.Verbosity.Everything);
                            return SiteList[i];
                        }
                    }
                }
            }
            return null;
        }

        public static bool InSubnet(System.Net.IPAddress IPAddr, string Subnet)
        {

            bool result = false;

            int cidr = Int32.Parse(Subnet.Split('/')[1]);
            uint mask = cidr == 0 ? 0 : 0xffffffff << (32 - cidr);
            byte[] maskBytes = BitConverter.GetBytes(mask);
            Array.Reverse(maskBytes);

            byte[] addressBytes = IPAddr.GetAddressBytes();
            IPAddress subnet = IPAddress.Parse(Subnet.Split('/')[0]);
            byte[] maskedAddressBytes = new byte[addressBytes.Length];

            for (int i = 0; i < maskedAddressBytes.Length; i++)
            {
                maskedAddressBytes[i] = (byte)(IPAddr.GetAddressBytes()[i] & maskBytes[i]);
            }
            IPAddress maskedAddress = new IPAddress(maskedAddressBytes);

            result = (subnet.Equals(maskedAddress));
            return result;
        }

        public new void Dispose()
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
            Subnets.Clear();
            Subnets = null;
        }

        internal static string ResolvetoString(IPAddress iPAddress, List<CSite> sites)
        {
            CSite site = CSite.Resolve(iPAddress, sites);
            if (site == null) { return ""; }
            else { return site.Name; }
        }
    }
}
