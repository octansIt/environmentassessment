using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnvironmentAssessment.Common.Inventory
{
    public class CMetricType : IDisposable
    {
        private int _type;

        public static string[] Values = { "Virtual Machine Disk", "Virtual Machine Memory", "Virtual Machine CPU", "Virtual Machines", "Host Disk", "Host Memory", "Host CPU", "Hosts", "Datastore Disk", "Datastores", "Clusters", "Datacenters" };

        public const int VmDisk = 0;
        public const int VmMem = 1;
        public const int VmCpu = 2;
        public const int VmCount = 3;
        public const int HostDisk = 4;
        public const int HostMem = 5;
        public const int HostCpu = 6;
        public const int HostCount = 7;
        public const int DsDisk = 8;
        public const int DsCount = 9;
        public const int ClCount = 10;
        public const int DcCount = 11;

        public CMetricType(string s = "")
        {
            _type = Array.IndexOf(Values, s);
        }
        public CMetricType(int t = -1)
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

        public static implicit operator int(CMetricType x)
        {
            int i = x._type;
            return i;
        }
    }

    public class CMetricSubtype : IDisposable
    {
        private int _type;

        public static string[] Values = { "", "Used", "Allocated", "Cores", "Sockets", "Unshared", "Thin" };

        public const int None = 0;
        public const int Used = 1;
        public const int Allocated = 2;
        public const int Cores = 3;
        public const int Sockets = 4;
        public const int Unshared = 5;
        public const int Thin = 6;

        public CMetricSubtype(int t = -1)
        {
            _type = t;
        }
        public CMetricSubtype(string s = "")
        {
            _type = Array.IndexOf(Values, s);
        }

        public void Dispose()
        {
            Values = null;
        }

        public override string ToString()
        {
            return Values[_type];
        }

        public static implicit operator int(CMetricSubtype x)
        {
            int i = x._type;
            return i;
        }
    }

    class CDiscoveredMetrics : IDisposable
    {
        private Dictionary<int, long> _metrics;

        public Dictionary<int, long> Metrics { get { return _metrics; } }

        internal const int SerializeAsFullJson = 0;
        internal const int SerializeAsShortJson = 1;

        public CDiscoveredMetrics()
        {
            _metrics = new Dictionary<int, long> { };
        }

        public CDiscoveredMetrics(int type, int subtype, int value)
        {
            _metrics = new Dictionary<int, long> { };
            Set(type, subtype, value);
        }

        public void Set(int type, int subtype, long value)
        {
            _metrics[(type + 1) * 1000 + subtype] = value;
        }

        public bool Contains(int type)
        {
            bool result = false;
            result = _metrics.ContainsKey(type);
            return result;
        }

        public bool Contains(int type, int subtype)
        {
            bool result = false;
            if (_metrics.ContainsKey((type + 1) * 1000 + subtype))
            {
                result = true;
            }
            return result;
        }

        public override string ToString()
        {
            return Serialize(SerializeAsFullJson);
        }

        public string Serialize(int mode)
        {
            string result = "";
            if (mode == SerializeAsFullJson)
            {
                foreach (int index in _metrics.Keys)
                {
                    int remainder;
                    int quotient = Math.DivRem(index, 1000, out remainder) - 1;
                    string tstr = new CMetricType(quotient).ToString().Replace(" ", "").ToLower();
                    string sstr = new CMetricSubtype(remainder).ToString();
                    if (sstr.Length > 0)
                    {
                        sstr = sstr.Replace(" ", "").ToLower();
                        result += "\"" + tstr + "-" + sstr + "\":\"" + _metrics[index] + "\", ";
                    }
                    else
                    {
                        result += "\"" + tstr + "\":\"" + _metrics[index] + "\", ";
                    }
                }
            }
            else if (mode == SerializeAsShortJson)
            {
                foreach (int index in _metrics.Keys)
                {
                    result += "\"" + index + "\":\"" + _metrics[index] + "\", ";
                }
            }
            return result;
        }
        
        public long Get(int type, int subtype)
        {
            long result = 0;
            _metrics.TryGetValue((type + 1) * 1000 + subtype, out result);
            return result;
        }

        public void Increment(int type, int subtype, long aval)
        {
            long oval = this.Get(type, subtype);
            this.Set(type, subtype, oval + aval);
        }

        public void Increment(int type, int subtype, CDiscoveredConfig oc)
        {
            Increment(type, subtype, oc.Metrics.Get(type, subtype));
        }

        internal void Increment(int type, long aval)
        {
            long oval = this.Get(type, CMetricSubtype.None);
            this.Set(type, CMetricSubtype.None, oval + aval);
        }

        public void Dispose()
        {

        }

        internal void Merge(CDiscoveredMetrics attributesToMerge)
        {
            foreach (int k in attributesToMerge.Metrics.Keys)
            {
                _metrics[k] = attributesToMerge.Metrics[k];
            }
        }

        internal static CDiscoveredMetrics Deserialize(string str)
        {
            CDiscoveredMetrics result = new CDiscoveredMetrics();
            str = str.Replace("{", "");
            str = str.Replace("}", "");
            string[] arr = str.Split(',');
            foreach (string attr in arr)
            {
                string[] ad = attr.Replace("\"", "").Split(':');
                int index = Convert.ToInt32(ad[0]);
                if (index >= 1000)
                {
                    long val = Convert.ToInt64(ad[1]);

                    int subtype;
                    int type = Math.DivRem(index, 1000, out subtype) - 1;
                    
                    result.Set(type, subtype, val);
                }
            }
            return result;
        }
    }
}
