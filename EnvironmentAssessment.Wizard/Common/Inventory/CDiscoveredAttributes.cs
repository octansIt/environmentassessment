using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnvironmentAssessment.Common.Inventory
{
    public class CAttributeType : IDisposable
    {
        private int _type;

        private static string[] Values = { "Operating System", "Cluster", "Datacenter", "Tools Version", "Hardware Version", "Details", "Path", "Mode", "Format", "Vendor", "Model", "Reference", "Version", "IP Address", "Thin", "Local", "Created", "Accessed", "Location", "Subnets", "Power State", "Config State", "Config Issues", "Connection State" };

        public const int OS = 0;
        public const int Cluster = 1;
        public const int Datacenter = 2;
        public const int ToolsVersion = 3;
        public const int HardwareVersion = 4;
        public const int Details = 5;
        public const int Path = 6;
        public const int Mode = 7;
        public const int Format = 8;
        public const int Vendor = 9;
        public const int Model = 10;
        public const int Reference = 11;
        public const int Version = 12;
        public const int IP = 13;
        public const int Thin = 14;
        public const int Local = 15;
        public const int Created = 16;
        public const int Accessed = 17;
        public const int Location = 18;
        public const int Subnets = 19;
        public const int PowerState = 20;
        public const int ConfigState = 21;
        public const int ConfigIssues = 22;
        public const int ConnectionState = 23;

        public CAttributeType(string s = "")
        {
            _type = Array.IndexOf(Values, s);
        }
        public CAttributeType(int t = -1)
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

        public static implicit operator int(CAttributeType x)
        {
            int i = x._type;
            return i;
        }
    }

    class CDiscoveredAttributes : IDisposable
    {
        private Dictionary<int, string> _attributes;
        public Dictionary<int, string> Attributes { get { return _attributes; } }

        internal const int SerializeAsFullJson = 0;
        internal const int SerializeAsShortJson = 1;

        public CDiscoveredAttributes()
        {
            _attributes = new Dictionary<int, string> { };
        }

        public CDiscoveredAttributes(int type, string value)
        {
            _attributes = new Dictionary<int, string> { };
            Set(type, value);
        }

        public int Count()
        {
            return _attributes.Count();
        }

        public void Set(int type, string value)
        {
            if (this.Contains(type))
            {
                _attributes[type] = value;
            }
            else
            {
                _attributes.Add(type, value);
            }
        }

        public bool Contains(int type)
        {
            bool result = false;
            result = _attributes.ContainsKey(type);
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
                foreach (int type in _attributes.Keys)
                {
                    string tstr = new CAttributeType(type).ToString().Replace(" ", "").ToLower();
                    result += "\"" + tstr + "\":\"" + CFunctions.EscapeJson(_attributes[type]) + "\", ";
                }
            }
            else if (mode == SerializeAsShortJson)
            {
                foreach (int type in _attributes.Keys)
                {
                    if (type != CAttributeType.Reference && type != CAttributeType.Created && type != CAttributeType.Accessed)
                    {
                        result += "\"" + type + "\":\"" + CFunctions.EscapeJson(_attributes[type]) + "\", ";
                    }
                }
            }
            return result;
        }

        public string Get(int type)
        {
            string result = "";
            _attributes.TryGetValue(type, out result);
            return result;
        }

        public void Dispose()
        {

        }

        internal void Merge(CDiscoveredAttributes attributesToMerge)
        {
            foreach(int k in attributesToMerge.Attributes.Keys)
            {
                _attributes[k] = attributesToMerge.Attributes[k];
            }
        }

        internal static CDiscoveredAttributes Deserialize(string str)
        {
            CDiscoveredAttributes result = new CDiscoveredAttributes();
            str = str.Replace("{", "");
            str = str.Replace("}", "");
            string[] arr = str.Split(',');
            foreach (string attr in arr)
            {
                string[] ad = attr.Replace("\"", "").Split(':');
                int index = Convert.ToInt32(ad[0]);
                if (index < 1000)
                {
                    string val = ad[1];
                    result.Set(index, val);
                }
            }
            return result;
        }
    }
}
