using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnvironmentAssessment.Common.Inventory
{
    internal class CDiscoveredTypes : IDisposable
    {
        private int _type;

        internal static string[] Values = { "Object", "Event", "Setting", "Site",
            "VMware vCenter", "VMware ESX", "Microsoft HyperV", "KVM", "Microsoft SCVMM", "Microsoft SCOM",
            "Azure Account", "AWS Account", "GCE Account",
            "Physical Server", "Physical Workstation", "Domain Controller",
            "VMware Datacenter", "VMware Cluster", "VMware Host", "VMware Datastore", "VMware Virtual Machine", "VMware Folder", "VMware Resource Pool", "VMware Virtual Switch","VMware Virtual Disk",
            "HyperV Cloud", "HyperV Cluster", "HyperV Host", "HyperV Datastore", "HyperV Virtual Machine", "HyperV Folder", "HyperV Resource Pool", "HyperV Virtual Switch","HyperV Virtual Disk",
            "Veeam Backup Server", "Veeam Enterprise Manager", "Veeam ONE",
            "Veeam Backup Proxy", "Veeam Tape Proxy", "Veeam Guest Interaction Proxy", "Veeam CDP Proxy", "Veeam File Proxy",
            "Veeam Backup Repository", "Veeam WAN Accelerator", "Veeam Mount Server", "Veeam Backup Repository Gateway Server", "Veeam Cloud Gateway",
            "Veeam Backup Job", "Veeam Backup Copy Job", "Veeam Backup To Tape Job", "Veeam File To Tape Job", "Veeam Replication Job","Veeam VM Copy Job", "Veeam File Copy Job",
            };

        public const int Object = 0;
        public const int Event = 1;
        public const int Setting = 2;
        public const int Site = 3;
        public const int VCenterServer = 4;
        public const int ESXServer = 5;
        public const int HYVServer = 6;
        public const int KVMServer = 7;
        public const int SCVMMServer = 8;
        public const int SCOMServer = 9;
        public const int AzureAccount = 10;
        public const int AWSAccount = 11;
        public const int GCEAccount = 12;
        public const int PhysicalServer = 13;
        public const int PhysicalWorkstation = 14;
        public const int DomainServer = 15;
        public const int VIDatacenter = 16;
        public const int VICluster = 17;
        public const int VIHost = 18;
        public const int VIDatastore = 19;
        public const int VIVM = 20;
        public const int VIFolder = 21;
        public const int VIResourcePool = 22;
        public const int VISwitch = 23;
        public const int VIDisk = 24;
        public const int HVDatacenter = 25;
        public const int HVCluster = 26;
        public const int HVHost = 27;
        public const int HVDatastore = 28;
        public const int HVVM = 29;
        public const int HVFolder = 30;
        public const int HVResourcePool = 31;
        public const int HVSwitch = 32;
        public const int HVDisk = 33;
        public const int VBRBackupServer = 34;
        public const int VBRBackupEnterpriseManager = 35;
        public const int VONEServer = 36;
        public const int VBRBackupProxy = 37;
        public const int VBRTapeProxy = 38;
        public const int VBRGuestInteractionProxy = 39;
        public const int VBRCDPProxy = 40;
        public const int VBRFileProxy = 41;
        public const int VBRBackupRepository = 42;
        public const int VBRWANAccelerator = 43;
        public const int VBRMountServer = 44;
        public const int VBRRepositoryGateway = 45;
        public const int VBRCloudGateway = 46;
        public const int VBRBackupJob = 47;
        public const int VBRBackupCopyJob = 48;
        public const int VBRBackupToTapeJob = 49;
        public const int VBRFileToTapeJob = 50;
        public const int VBRReplicationJob = 51;
        public const int VBRVMCopyJob = 52;
        public const int VBRFileCopyJob = 53;

        public CDiscoveredTypes(int t = -1)
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

        public static implicit operator int(CDiscoveredTypes x)
        {
            int i = x._type;
            return i;
        }
    }
}
