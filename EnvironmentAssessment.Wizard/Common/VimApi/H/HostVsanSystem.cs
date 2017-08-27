using System;
using System.ServiceModel;
using VimApi_65;
namespace EnvironmentAssessment.Common.VimApi
{
	public class HostVsanSystem : ViewBase
	{
		protected VsanHostConfigInfo _config;
		public VsanHostConfigInfo Config
		{
			get
			{
				return this._config;
			}
		}
		public HostVsanSystem(IVimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public VsanHostDiskResult[] QueryDisksForVsan(string[] canonicalName)
		{
			VsanHostDiskResult[] result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim55);
				QueryDisksForVsanRequestType queryDisksForVsanRequestType = new QueryDisksForVsanRequestType();
				queryDisksForVsanRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				queryDisksForVsanRequestType.canonicalName = canonicalName;
				result = (VsanHostDiskResult[])VIConvert.ToVim(this.VimServiceProxy.QueryDisksForVsan(new QueryDisksForVsanRequest(queryDisksForVsanRequestType)).QueryDisksForVsanResponse1);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference AddDisks_Task(HostScsiDisk[] disk)
		{
			ManagedObjectReference result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim55);
				AddDisksRequestType addDisksRequestType = new AddDisksRequestType();
				addDisksRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				addDisksRequestType.disk = (VimApi_65.HostScsiDisk[])VIConvert.ToWsdlType(disk);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.AddDisks_Task(new AddDisks_TaskRequest(addDisksRequestType)).AddDisks_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public VsanHostDiskMapResult[] AddDisks(HostScsiDisk[] disk)
		{
			VsanHostDiskMapResult[] result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim55);
				ManagedObjectReference taskReference = this.AddDisks_Task(disk);
				result = (VsanHostDiskMapResult[])this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference InitializeDisks_Task(VsanHostDiskMapping[] mapping)
		{
			ManagedObjectReference result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim55);
				InitializeDisksRequestType initializeDisksRequestType = new InitializeDisksRequestType();
				initializeDisksRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				initializeDisksRequestType.mapping = (VimApi_65.VsanHostDiskMapping[])VIConvert.ToWsdlType(mapping);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.InitializeDisks_Task(new InitializeDisks_TaskRequest(initializeDisksRequestType)).InitializeDisks_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public VsanHostDiskMapResult[] InitializeDisks(VsanHostDiskMapping[] mapping)
		{
			VsanHostDiskMapResult[] result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim55);
				ManagedObjectReference taskReference = this.InitializeDisks_Task(mapping);
				result = (VsanHostDiskMapResult[])this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference RemoveDisk_Task(HostScsiDisk[] disk, HostMaintenanceSpec maintenanceSpec, int? timeout)
		{
			ManagedObjectReference result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim55);
				RemoveDiskRequestType removeDiskRequestType = new RemoveDiskRequestType();
				removeDiskRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				removeDiskRequestType.disk = (VimApi_65.HostScsiDisk[])VIConvert.ToWsdlType(disk);
				removeDiskRequestType.maintenanceSpec = (VimApi_65.HostMaintenanceSpec)VIConvert.ToWsdlType(maintenanceSpec);
				removeDiskRequestType.timeout = timeout.GetValueOrDefault();
				removeDiskRequestType.timeoutSpecified = timeout.HasValue;
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.RemoveDisk_Task(new RemoveDisk_TaskRequest(removeDiskRequestType)).RemoveDisk_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		[Obsolete("The method RemoveDisk in HostVsanSystem is deprecated in version 5.5.")]
		public VsanHostDiskResult[] RemoveDisk(HostScsiDisk[] disk)
		{
			return this.RemoveDisk(disk, null, null);
		}
		[Obsolete("The method RemoveDisk_Task in HostVsanSystem is deprecated in version 5.5.")]
		public ManagedObjectReference RemoveDisk_Task(HostScsiDisk[] disk)
		{
			return this.RemoveDisk_Task(disk, null, null);
		}
		public VsanHostDiskResult[] RemoveDisk(HostScsiDisk[] disk, HostMaintenanceSpec maintenanceSpec, int? timeout)
		{
			VsanHostDiskResult[] result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim55);
				ManagedObjectReference taskReference = this.RemoveDisk_Task(disk, maintenanceSpec, timeout);
				result = (VsanHostDiskResult[])this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference RemoveDiskMapping_Task(VsanHostDiskMapping[] mapping, HostMaintenanceSpec maintenanceSpec, int? timeout)
		{
			ManagedObjectReference result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim55);
				RemoveDiskMappingRequestType removeDiskMappingRequestType = new RemoveDiskMappingRequestType();
				removeDiskMappingRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				removeDiskMappingRequestType.mapping = (VimApi_65.VsanHostDiskMapping[])VIConvert.ToWsdlType(mapping);
				removeDiskMappingRequestType.maintenanceSpec = (VimApi_65.HostMaintenanceSpec)VIConvert.ToWsdlType(maintenanceSpec);
				removeDiskMappingRequestType.timeout = timeout.GetValueOrDefault();
				removeDiskMappingRequestType.timeoutSpecified = timeout.HasValue;
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.RemoveDiskMapping_Task(new RemoveDiskMapping_TaskRequest(removeDiskMappingRequestType)).RemoveDiskMapping_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		[Obsolete("The method RemoveDiskMapping in HostVsanSystem is deprecated in version 5.5.")]
		public VsanHostDiskMapResult[] RemoveDiskMapping(VsanHostDiskMapping[] mapping)
		{
			return this.RemoveDiskMapping(mapping, null, null);
		}
		[Obsolete("The method RemoveDiskMapping_Task in HostVsanSystem is deprecated in version 5.5.")]
		public ManagedObjectReference RemoveDiskMapping_Task(VsanHostDiskMapping[] mapping)
		{
			return this.RemoveDiskMapping_Task(mapping, null, null);
		}
		public VsanHostDiskMapResult[] RemoveDiskMapping(VsanHostDiskMapping[] mapping, HostMaintenanceSpec maintenanceSpec, int? timeout)
		{
			VsanHostDiskMapResult[] result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim55);
				ManagedObjectReference taskReference = this.RemoveDiskMapping_Task(mapping, maintenanceSpec, timeout);
				result = (VsanHostDiskMapResult[])this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference UnmountDiskMapping_Task(VsanHostDiskMapping[] mapping)
		{
			ManagedObjectReference result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim55);
				UnmountDiskMappingRequestType unmountDiskMappingRequestType = new UnmountDiskMappingRequestType();
				unmountDiskMappingRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				unmountDiskMappingRequestType.mapping = (VimApi_65.VsanHostDiskMapping[])VIConvert.ToWsdlType(mapping);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.UnmountDiskMapping_Task(new UnmountDiskMapping_TaskRequest(unmountDiskMappingRequestType)).UnmountDiskMapping_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public VsanHostDiskMapResult[] UnmountDiskMapping(VsanHostDiskMapping[] mapping)
		{
			VsanHostDiskMapResult[] result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim55);
				ManagedObjectReference taskReference = this.UnmountDiskMapping_Task(mapping);
				result = (VsanHostDiskMapResult[])this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference UpdateVsan_Task(VsanHostConfigInfo config)
		{
			ManagedObjectReference result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim55);
				UpdateVsanRequestType updateVsanRequestType = new UpdateVsanRequestType();
				updateVsanRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				updateVsanRequestType.config = (VimApi_65.VsanHostConfigInfo)VIConvert.ToWsdlType(config);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.UpdateVsan_Task(new UpdateVsan_TaskRequest(updateVsanRequestType)).UpdateVsan_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void UpdateVsan(VsanHostConfigInfo config)
		{
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim55);
				ManagedObjectReference taskReference = this.UpdateVsan_Task(config);
				this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public VsanHostClusterStatus QueryHostStatus()
		{
			VsanHostClusterStatus result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim55);
				QueryHostStatusRequestType queryHostStatusRequestType = new QueryHostStatusRequestType();
				queryHostStatusRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				result = (VsanHostClusterStatus)VIConvert.ToVim(this.VimServiceProxy.QueryHostStatus(new QueryHostStatusRequest(queryHostStatusRequestType)).QueryHostStatusResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference EvacuateVsanNode_Task(HostMaintenanceSpec maintenanceSpec, int timeout)
		{
			ManagedObjectReference result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim60);
				EvacuateVsanNodeRequestType evacuateVsanNodeRequestType = new EvacuateVsanNodeRequestType();
				evacuateVsanNodeRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				evacuateVsanNodeRequestType.maintenanceSpec = (VimApi_65.HostMaintenanceSpec)VIConvert.ToWsdlType(maintenanceSpec);
				evacuateVsanNodeRequestType.timeout = timeout;
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.EvacuateVsanNode_Task(new EvacuateVsanNode_TaskRequest(evacuateVsanNodeRequestType)).EvacuateVsanNode_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void EvacuateVsanNode(HostMaintenanceSpec maintenanceSpec, int timeout)
		{
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim60);
				ManagedObjectReference taskReference = this.EvacuateVsanNode_Task(maintenanceSpec, timeout);
				this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public ManagedObjectReference RecommissionVsanNode_Task()
		{
			ManagedObjectReference result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim60);
				RecommissionVsanNodeRequestType recommissionVsanNodeRequestType = new RecommissionVsanNodeRequestType();
				recommissionVsanNodeRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.RecommissionVsanNode_Task(new RecommissionVsanNode_TaskRequest(recommissionVsanNodeRequestType)).RecommissionVsanNode_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void RecommissionVsanNode()
		{
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim60);
				ManagedObjectReference taskReference = this.RecommissionVsanNode_Task();
				this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
	}
}
