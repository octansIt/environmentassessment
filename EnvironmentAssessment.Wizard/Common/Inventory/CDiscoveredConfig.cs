using EnvironmentAssessment.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace EnvironmentAssessment.Common.Inventory
{
    public class CDiscoveredConfig : IDisposable
    {
        internal int Type;
        internal CSite Site;

        internal const int SerializeAsFullJson = 0;
        internal const int SerializeAsShortJson = 1;

        internal string Id;
        internal string Name;

        internal CDiscoveredMetrics Metrics;
        internal CDiscoveredAttributes Attributes;

        public List<string> ChildInfo;
        internal List<CDiscoveredConfig> ChildObjects;
        public List<string> Owner;

        public CDiscoveredConfig()
        {
            if (Id == null) { Id = CFunctions.GenerateUID(); }
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public string Serialize(int mode)
        {
            string result = "";
            if (mode == SerializeAsFullJson)
            {
                if (Name != null) { result += "\"" + CFunctions.EscapeJson(Name) + "\": { "; }
                if (Type > -1) { result += "\"type\":\"" + CDiscoveredTypes.Values[Type].Replace(" ", "-").ToLower() + "\", "; }
                if (Metrics != null) { result += Metrics.Serialize(SerializeAsFullJson); }
                if (Attributes != null) { result += Attributes.Serialize(SerializeAsFullJson); }
            }
            else if (mode == SerializeAsShortJson)
            {
                result += "{";
                if (Metrics != null) { result += Metrics.Serialize(SerializeAsShortJson); }
                if (Attributes != null) { result += Attributes.Serialize(SerializeAsShortJson); }
            }
            result = result.TrimEnd(new char[] { ',', ' ' });
            result += "}";
            return result;
        }

        public override string ToString()
        {
            string result = "" + this.Serialize(SerializeAsFullJson);
            return result;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing) //free managed resources if any
            {
                if (Site != null) { Site.Dispose(); }
                if (Metrics != null) { Metrics.Dispose(); }
                if (Attributes != null) { Attributes.Dispose(); }
            }
            // free native resources if there are any.  
            if (ChildObjects != null) { ChildObjects.Clear(); }
            ChildObjects = null;
        }

        internal static CDiscoveredConfig Deserialize(string str)
        {
            CDiscoveredConfig result = new CDiscoveredConfig();
            if (str.Length > 0 && str != "{}")
            {
                result.Attributes = CDiscoveredAttributes.Deserialize(str);
                result.Metrics = CDiscoveredMetrics.Deserialize(str);
            }
            return result;
        }

        internal void Merge (CDiscoveredConfig newconfig)
        {
            this.Attributes.Merge(newconfig.Attributes);
            this.Metrics.Merge(newconfig.Metrics);
        }
    }
}
