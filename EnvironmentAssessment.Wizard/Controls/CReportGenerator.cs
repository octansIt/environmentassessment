using EnvironmentAssessment.Collector;
using EnvironmentAssessment.Common.Inventory;
using System.Linq;

namespace EnvironmentAssessment.Reporter
{
    public class CReportGenerator
    {
        internal void RollupTotals(CQuery.Types querytype, CSite site, object obj)
        {
            if (obj.GetType().FullName.Contains("CServiceConfig"))
            {
                if (querytype == CQuery.Types.VMs)
                {
                    CServiceConfig sc = (CServiceConfig)obj;
                    if (sc.Disks != null)
                    {
                        foreach (CStorageConfig st in sc.Disks)
                        {
                            if (st.Thin)
                            {
                                site.Details.VMThinUsage[0] += st.Allocated;
                                site.Details.VMThinUsage[1] += st.Used;
                            }
                            else
                            {
                                site.Details.VMThickUsage[0] += st.Allocated;
                                site.Details.VMThickUsage[1] += st.Used;
                            }
                        }
                    }
                    site.Details.VMs++;
                    if (!site.Details.GuestOperatingSystems.Contains(sc.OS)) { site.Details.GuestOperatingSystems.Add(sc.OS); }
                    site.Details.VMUsageReported[0] += sc.DiskUsageReported[0]; // usage reported
                    site.Details.VMUsageReported[1] += sc.DiskUsageReported[1];
                    site.Details.VMUsageActual[0] += sc.DiskUsageActual[0]; // actual disk usage
                    site.Details.VMUsageActual[1] += sc.DiskUsageActual[1];
                }
                else if (querytype == CQuery.Types.Hosts)
                {
                    CServiceConfig sc = (CServiceConfig)obj;
                    if (!site.Details.HostOperatingSystems.Contains(sc.OS)) { site.Details.HostOperatingSystems.Add(sc.OS); }
                    site.Details.Hosts++; site.Details.HostSockets += sc.CPUSockets;
                }
            }
            else if (obj.GetType().FullName.Contains("CStorageConfig"))
            {
                CStorageConfig st = (CStorageConfig)obj;
                bool skip = false;

                if ((st.Name.Contains("VeeamBackup_") || st.Name.Contains("Veeam_")) && (st.Type == "NFS")) { skip = true; }

                if (!skip)
                {
                    site.Details.Datastores++; site.Details.DatastoreUsage[0] += st.Allocated; site.Details.DatastoreUsage[1] += st.Used;
                }
            }
        }

    }
}
