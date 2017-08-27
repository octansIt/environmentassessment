using System.ServiceModel;
using VimApi_65;
namespace EnvironmentAssessment.Common.VimApi
{
	public class HostStorageSystem : ExtensibleManagedObject
	{
		protected HostStorageDeviceInfo _storageDeviceInfo;
		protected HostFileSystemVolumeInfo _fileSystemVolumeInfo;
		protected string[] _systemFile;
		protected HostMultipathStateInfo _multipathStateInfo;
		public HostStorageDeviceInfo StorageDeviceInfo
		{
			get
			{
				return this._storageDeviceInfo;
			}
		}
		public HostFileSystemVolumeInfo FileSystemVolumeInfo
		{
			get
			{
				return this._fileSystemVolumeInfo;
			}
		}
		public string[] SystemFile
		{
			get
			{
				return this._systemFile;
			}
		}
		public HostMultipathStateInfo MultipathStateInfo
		{
			get
			{
				return this._multipathStateInfo;
			}
		}
		public HostStorageSystem(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public HostDiskPartitionInfo[] RetrieveDiskPartitionInfo(string[] devicePath)
		{
			HostDiskPartitionInfo[] result;
			try
			{
				RetrieveDiskPartitionInfoRequestType retrieveDiskPartitionInfoRequestType = new RetrieveDiskPartitionInfoRequestType();
				retrieveDiskPartitionInfoRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				retrieveDiskPartitionInfoRequestType.devicePath = devicePath;
				result = (HostDiskPartitionInfo[])VIConvert.ToVim(this.VimServiceProxy.RetrieveDiskPartitionInfo(new RetrieveDiskPartitionInfoRequest(retrieveDiskPartitionInfoRequestType)).RetrieveDiskPartitionInfoResponse1);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public HostDiskPartitionInfo ComputeDiskPartitionInfo(string devicePath, HostDiskPartitionLayout layout, string partitionFormat)
		{
			HostDiskPartitionInfo result;
			try
			{
				ComputeDiskPartitionInfoRequestType computeDiskPartitionInfoRequestType = new ComputeDiskPartitionInfoRequestType();
				computeDiskPartitionInfoRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				computeDiskPartitionInfoRequestType.devicePath = devicePath;
				computeDiskPartitionInfoRequestType.layout = (VimApi_65.HostDiskPartitionLayout)VIConvert.ToWsdlType(layout);
				computeDiskPartitionInfoRequestType.partitionFormat = partitionFormat;
				result = (HostDiskPartitionInfo)VIConvert.ToVim(this.VimServiceProxy.ComputeDiskPartitionInfo(new ComputeDiskPartitionInfoRequest(computeDiskPartitionInfoRequestType)).ComputeDiskPartitionInfoResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public HostDiskPartitionInfo ComputeDiskPartitionInfoForResize(HostScsiDiskPartition partition, HostDiskPartitionBlockRange blockRange, string partitionFormat)
		{
			HostDiskPartitionInfo result;
			try
			{	
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				ComputeDiskPartitionInfoForResizeRequestType computeDiskPartitionInfoForResizeRequestType = new ComputeDiskPartitionInfoForResizeRequestType();
				computeDiskPartitionInfoForResizeRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				computeDiskPartitionInfoForResizeRequestType.partition = (VimApi_65.HostScsiDiskPartition)VIConvert.ToWsdlType(partition);
				computeDiskPartitionInfoForResizeRequestType.blockRange = (VimApi_65.HostDiskPartitionBlockRange)VIConvert.ToWsdlType(blockRange);
				computeDiskPartitionInfoForResizeRequestType.partitionFormat = partitionFormat;
				result = (HostDiskPartitionInfo)VIConvert.ToVim(this.VimServiceProxy.ComputeDiskPartitionInfoForResize(new ComputeDiskPartitionInfoForResizeRequest(computeDiskPartitionInfoForResizeRequestType)).ComputeDiskPartitionInfoForResizeResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void UpdateDiskPartitions(string devicePath, HostDiskPartitionSpec spec)
		{
			try
			{
				UpdateDiskPartitionsRequestType updateDiskPartitionsRequestType = new UpdateDiskPartitionsRequestType();
				updateDiskPartitionsRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				updateDiskPartitionsRequestType.devicePath = devicePath;
				updateDiskPartitionsRequestType.spec = (VimApi_65.HostDiskPartitionSpec)VIConvert.ToWsdlType(spec);
				this.VimServiceProxy.UpdateDiskPartitions(new UpdateDiskPartitionsRequest(updateDiskPartitionsRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public HostVmfsVolume FormatVmfs(HostVmfsSpec createSpec)
		{
			HostVmfsVolume result;
			try
			{
				FormatVmfsRequestType formatVmfsRequestType = new FormatVmfsRequestType();
				formatVmfsRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				formatVmfsRequestType.createSpec = (VimApi_65.HostVmfsSpec)VIConvert.ToWsdlType(createSpec);
				result = (HostVmfsVolume)VIConvert.ToVim(this.VimServiceProxy.FormatVmfs(new FormatVmfsRequest(formatVmfsRequestType)).FormatVmfsResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void MountVmfsVolume(string vmfsUuid)
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim50);
				MountVmfsVolumeRequestType mountVmfsVolumeRequestType = new MountVmfsVolumeRequestType();
				mountVmfsVolumeRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				mountVmfsVolumeRequestType.vmfsUuid = vmfsUuid;
				this.VimServiceProxy.MountVmfsVolume(new MountVmfsVolumeRequest(mountVmfsVolumeRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void UnmountVmfsVolume(string vmfsUuid)
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim50);
				UnmountVmfsVolumeRequestType unmountVmfsVolumeRequestType = new UnmountVmfsVolumeRequestType();
				unmountVmfsVolumeRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				unmountVmfsVolumeRequestType.vmfsUuid = vmfsUuid;
				this.VimServiceProxy.UnmountVmfsVolume(new UnmountVmfsVolumeRequest(unmountVmfsVolumeRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public ManagedObjectReference UnmountVmfsVolumeEx_Task(string[] vmfsUuid)
		{
			ManagedObjectReference result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim60);
				UnmountVmfsVolumeExRequestType unmountVmfsVolumeExRequestType = new UnmountVmfsVolumeExRequestType();
				unmountVmfsVolumeExRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				unmountVmfsVolumeExRequestType.vmfsUuid = vmfsUuid;
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.UnmountVmfsVolumeEx_Task(new UnmountVmfsVolumeEx_TaskRequest(unmountVmfsVolumeExRequestType)).UnmountVmfsVolumeEx_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public HostStorageSystemVmfsVolumeResult[] UnmountVmfsVolumeEx(string[] vmfsUuid)
		{
			HostStorageSystemVmfsVolumeResult[] result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim60);
				ManagedObjectReference taskReference = this.UnmountVmfsVolumeEx_Task(vmfsUuid);
				result = (HostStorageSystemVmfsVolumeResult[])this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference MountVmfsVolumeEx_Task(string[] vmfsUuid)
		{
			ManagedObjectReference result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim60);
				MountVmfsVolumeExRequestType mountVmfsVolumeExRequestType = new MountVmfsVolumeExRequestType();
				mountVmfsVolumeExRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				mountVmfsVolumeExRequestType.vmfsUuid = vmfsUuid;
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.MountVmfsVolumeEx_Task(new MountVmfsVolumeEx_TaskRequest(mountVmfsVolumeExRequestType)).MountVmfsVolumeEx_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public HostStorageSystemVmfsVolumeResult[] MountVmfsVolumeEx(string[] vmfsUuid)
		{
			HostStorageSystemVmfsVolumeResult[] result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim60);
				ManagedObjectReference taskReference = this.MountVmfsVolumeEx_Task(vmfsUuid);
				result = (HostStorageSystemVmfsVolumeResult[])this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference UnmapVmfsVolumeEx_Task(string[] vmfsUuid)
		{
			ManagedObjectReference result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim60);
				UnmapVmfsVolumeExRequestType unmapVmfsVolumeExRequestType = new UnmapVmfsVolumeExRequestType();
				unmapVmfsVolumeExRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				unmapVmfsVolumeExRequestType.vmfsUuid = vmfsUuid;
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.UnmapVmfsVolumeEx_Task(new UnmapVmfsVolumeEx_TaskRequest(unmapVmfsVolumeExRequestType)).UnmapVmfsVolumeEx_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public HostStorageSystemVmfsVolumeResult[] UnmapVmfsVolumeEx(string[] vmfsUuid)
		{
			HostStorageSystemVmfsVolumeResult[] result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim60);
				ManagedObjectReference taskReference = this.UnmapVmfsVolumeEx_Task(vmfsUuid);
				result = (HostStorageSystemVmfsVolumeResult[])this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void DeleteVmfsVolumeState(string vmfsUuid)
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim51);
				DeleteVmfsVolumeStateRequestType deleteVmfsVolumeStateRequestType = new DeleteVmfsVolumeStateRequestType();
				deleteVmfsVolumeStateRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				deleteVmfsVolumeStateRequestType.vmfsUuid = vmfsUuid;
				this.VimServiceProxy.DeleteVmfsVolumeState(new DeleteVmfsVolumeStateRequest(deleteVmfsVolumeStateRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void RescanVmfs()
		{
			try
			{
				RescanVmfsRequestType rescanVmfsRequestType = new RescanVmfsRequestType();
				rescanVmfsRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				this.VimServiceProxy.RescanVmfs(new RescanVmfsRequest(rescanVmfsRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void AttachVmfsExtent(string vmfsPath, HostScsiDiskPartition extent)
		{
			try
			{
				AttachVmfsExtentRequestType attachVmfsExtentRequestType = new AttachVmfsExtentRequestType();
				attachVmfsExtentRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				attachVmfsExtentRequestType.vmfsPath = vmfsPath;
				attachVmfsExtentRequestType.extent = (VimApi_65.HostScsiDiskPartition)VIConvert.ToWsdlType(extent);
				this.VimServiceProxy.AttachVmfsExtent(new AttachVmfsExtentRequest(attachVmfsExtentRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void ExpandVmfsExtent(string vmfsPath, HostScsiDiskPartition extent)
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				ExpandVmfsExtentRequestType expandVmfsExtentRequestType = new ExpandVmfsExtentRequestType();
				expandVmfsExtentRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				expandVmfsExtentRequestType.vmfsPath = vmfsPath;
				expandVmfsExtentRequestType.extent = (VimApi_65.HostScsiDiskPartition)VIConvert.ToWsdlType(extent);
				this.VimServiceProxy.ExpandVmfsExtent(new ExpandVmfsExtentRequest(expandVmfsExtentRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void UpgradeVmfs(string vmfsPath)
		{
			try
			{
				UpgradeVmfsRequestType upgradeVmfsRequestType = new UpgradeVmfsRequestType();
				upgradeVmfsRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				upgradeVmfsRequestType.vmfsPath = vmfsPath;
				this.VimServiceProxy.UpgradeVmfs(new UpgradeVmfsRequest(upgradeVmfsRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void UpgradeVmLayout()
		{
			try
			{
				UpgradeVmLayoutRequestType upgradeVmLayoutRequestType = new UpgradeVmLayoutRequestType();
				upgradeVmLayoutRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				this.VimServiceProxy.UpgradeVmLayout(new UpgradeVmLayoutRequest(upgradeVmLayoutRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public HostUnresolvedVmfsVolume[] QueryUnresolvedVmfsVolume()
		{
			HostUnresolvedVmfsVolume[] result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				QueryUnresolvedVmfsVolumeRequestType queryUnresolvedVmfsVolumeRequestType = new QueryUnresolvedVmfsVolumeRequestType();
				queryUnresolvedVmfsVolumeRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				result = (HostUnresolvedVmfsVolume[])VIConvert.ToVim(this.VimServiceProxy.QueryUnresolvedVmfsVolume(new QueryUnresolvedVmfsVolumeRequest(queryUnresolvedVmfsVolumeRequestType)).QueryUnresolvedVmfsVolumeResponse1);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public HostUnresolvedVmfsResolutionResult[] ResolveMultipleUnresolvedVmfsVolumes(HostUnresolvedVmfsResolutionSpec[] resolutionSpec)
		{
			HostUnresolvedVmfsResolutionResult[] result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				ResolveMultipleUnresolvedVmfsVolumesRequestType resolveMultipleUnresolvedVmfsVolumesRequestType = new ResolveMultipleUnresolvedVmfsVolumesRequestType();
				resolveMultipleUnresolvedVmfsVolumesRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				resolveMultipleUnresolvedVmfsVolumesRequestType.resolutionSpec = (VimApi_65.HostUnresolvedVmfsResolutionSpec[])VIConvert.ToWsdlType(resolutionSpec);
				result = (HostUnresolvedVmfsResolutionResult[])VIConvert.ToVim(this.VimServiceProxy.ResolveMultipleUnresolvedVmfsVolumes(new ResolveMultipleUnresolvedVmfsVolumesRequest(resolveMultipleUnresolvedVmfsVolumesRequestType)).ResolveMultipleUnresolvedVmfsVolumesResponse1);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference ResolveMultipleUnresolvedVmfsVolumesEx_Task(HostUnresolvedVmfsResolutionSpec[] resolutionSpec)
		{
			ManagedObjectReference result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim55);
				ResolveMultipleUnresolvedVmfsVolumesExRequestType resolveMultipleUnresolvedVmfsVolumesExRequestType = new ResolveMultipleUnresolvedVmfsVolumesExRequestType();
				resolveMultipleUnresolvedVmfsVolumesExRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				resolveMultipleUnresolvedVmfsVolumesExRequestType.resolutionSpec = (VimApi_65.HostUnresolvedVmfsResolutionSpec[])VIConvert.ToWsdlType(resolutionSpec);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.ResolveMultipleUnresolvedVmfsVolumesEx_Task(new ResolveMultipleUnresolvedVmfsVolumesEx_TaskRequest(resolveMultipleUnresolvedVmfsVolumesExRequestType)).ResolveMultipleUnresolvedVmfsVolumesEx_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public HostUnresolvedVmfsResolutionResult[] ResolveMultipleUnresolvedVmfsVolumesEx(HostUnresolvedVmfsResolutionSpec[] resolutionSpec)
		{
			HostUnresolvedVmfsResolutionResult[] result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim55);
				ManagedObjectReference taskReference = this.ResolveMultipleUnresolvedVmfsVolumesEx_Task(resolutionSpec);
				result = (HostUnresolvedVmfsResolutionResult[])this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void UnmountForceMountedVmfsVolume(string vmfsUuid)
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				UnmountForceMountedVmfsVolumeRequestType unmountForceMountedVmfsVolumeRequestType = new UnmountForceMountedVmfsVolumeRequestType();
				unmountForceMountedVmfsVolumeRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				unmountForceMountedVmfsVolumeRequestType.vmfsUuid = vmfsUuid;
				this.VimServiceProxy.UnmountForceMountedVmfsVolume(new UnmountForceMountedVmfsVolumeRequest(unmountForceMountedVmfsVolumeRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void RescanHba(string hbaDevice)
		{
			try
			{
				RescanHbaRequestType rescanHbaRequestType = new RescanHbaRequestType();
				rescanHbaRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				rescanHbaRequestType.hbaDevice = hbaDevice;
				this.VimServiceProxy.RescanHba(new RescanHbaRequest(rescanHbaRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void RescanAllHba()
		{
			try
			{
				RescanAllHbaRequestType rescanAllHbaRequestType = new RescanAllHbaRequestType();
				rescanAllHbaRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				this.VimServiceProxy.RescanAllHba(new RescanAllHbaRequest(rescanAllHbaRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void UpdateSoftwareInternetScsiEnabled(bool enabled)
		{
			try
			{
				UpdateSoftwareInternetScsiEnabledRequestType updateSoftwareInternetScsiEnabledRequestType = new UpdateSoftwareInternetScsiEnabledRequestType();
				updateSoftwareInternetScsiEnabledRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				updateSoftwareInternetScsiEnabledRequestType.enabled = enabled;
				this.VimServiceProxy.UpdateSoftwareInternetScsiEnabled(new UpdateSoftwareInternetScsiEnabledRequest(updateSoftwareInternetScsiEnabledRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void UpdateInternetScsiDiscoveryProperties(string iScsiHbaDevice, HostInternetScsiHbaDiscoveryProperties discoveryProperties)
		{
			try
			{
				UpdateInternetScsiDiscoveryPropertiesRequestType updateInternetScsiDiscoveryPropertiesRequestType = new UpdateInternetScsiDiscoveryPropertiesRequestType();
				updateInternetScsiDiscoveryPropertiesRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				updateInternetScsiDiscoveryPropertiesRequestType.iScsiHbaDevice = iScsiHbaDevice;
				updateInternetScsiDiscoveryPropertiesRequestType.discoveryProperties = (VimApi_65.HostInternetScsiHbaDiscoveryProperties)VIConvert.ToWsdlType(discoveryProperties);
				this.VimServiceProxy.UpdateInternetScsiDiscoveryProperties(new UpdateInternetScsiDiscoveryPropertiesRequest(updateInternetScsiDiscoveryPropertiesRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void UpdateInternetScsiAuthenticationProperties(string iScsiHbaDevice, HostInternetScsiHbaAuthenticationProperties authenticationProperties, HostInternetScsiHbaTargetSet targetSet)
		{
			try
			{
				UpdateInternetScsiAuthenticationPropertiesRequestType updateInternetScsiAuthenticationPropertiesRequestType = new UpdateInternetScsiAuthenticationPropertiesRequestType();
				updateInternetScsiAuthenticationPropertiesRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				updateInternetScsiAuthenticationPropertiesRequestType.iScsiHbaDevice = iScsiHbaDevice;
				updateInternetScsiAuthenticationPropertiesRequestType.authenticationProperties = (VimApi_65.HostInternetScsiHbaAuthenticationProperties)VIConvert.ToWsdlType(authenticationProperties);
				updateInternetScsiAuthenticationPropertiesRequestType.targetSet = (VimApi_65.HostInternetScsiHbaTargetSet)VIConvert.ToWsdlType(targetSet);
				this.VimServiceProxy.UpdateInternetScsiAuthenticationProperties(new UpdateInternetScsiAuthenticationPropertiesRequest(updateInternetScsiAuthenticationPropertiesRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void UpdateInternetScsiDigestProperties(string iScsiHbaDevice, HostInternetScsiHbaTargetSet targetSet, HostInternetScsiHbaDigestProperties digestProperties)
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				UpdateInternetScsiDigestPropertiesRequestType updateInternetScsiDigestPropertiesRequestType = new UpdateInternetScsiDigestPropertiesRequestType();
				updateInternetScsiDigestPropertiesRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				updateInternetScsiDigestPropertiesRequestType.iScsiHbaDevice = iScsiHbaDevice;
				updateInternetScsiDigestPropertiesRequestType.targetSet = (VimApi_65.HostInternetScsiHbaTargetSet)VIConvert.ToWsdlType(targetSet);
				updateInternetScsiDigestPropertiesRequestType.digestProperties = (VimApi_65.HostInternetScsiHbaDigestProperties)VIConvert.ToWsdlType(digestProperties);
				this.VimServiceProxy.UpdateInternetScsiDigestProperties(new UpdateInternetScsiDigestPropertiesRequest(updateInternetScsiDigestPropertiesRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void UpdateInternetScsiAdvancedOptions(string iScsiHbaDevice, HostInternetScsiHbaTargetSet targetSet, HostInternetScsiHbaParamValue[] options)
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				UpdateInternetScsiAdvancedOptionsRequestType updateInternetScsiAdvancedOptionsRequestType = new UpdateInternetScsiAdvancedOptionsRequestType();
				updateInternetScsiAdvancedOptionsRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				updateInternetScsiAdvancedOptionsRequestType.iScsiHbaDevice = iScsiHbaDevice;
				updateInternetScsiAdvancedOptionsRequestType.targetSet = (VimApi_65.HostInternetScsiHbaTargetSet)VIConvert.ToWsdlType(targetSet);
				updateInternetScsiAdvancedOptionsRequestType.options = (VimApi_65.HostInternetScsiHbaParamValue[])VIConvert.ToWsdlType(options);
				this.VimServiceProxy.UpdateInternetScsiAdvancedOptions(new UpdateInternetScsiAdvancedOptionsRequest(updateInternetScsiAdvancedOptionsRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void UpdateInternetScsiIPProperties(string iScsiHbaDevice, HostInternetScsiHbaIPProperties ipProperties)
		{
			try
			{
				UpdateInternetScsiIPPropertiesRequestType updateInternetScsiIPPropertiesRequestType = new UpdateInternetScsiIPPropertiesRequestType();
				updateInternetScsiIPPropertiesRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				updateInternetScsiIPPropertiesRequestType.iScsiHbaDevice = iScsiHbaDevice;
				updateInternetScsiIPPropertiesRequestType.ipProperties = (VimApi_65.HostInternetScsiHbaIPProperties)VIConvert.ToWsdlType(ipProperties);
				this.VimServiceProxy.UpdateInternetScsiIPProperties(new UpdateInternetScsiIPPropertiesRequest(updateInternetScsiIPPropertiesRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void UpdateInternetScsiName(string iScsiHbaDevice, string iScsiName)
		{
			try
			{
				UpdateInternetScsiNameRequestType updateInternetScsiNameRequestType = new UpdateInternetScsiNameRequestType();
				updateInternetScsiNameRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				updateInternetScsiNameRequestType.iScsiHbaDevice = iScsiHbaDevice;
				updateInternetScsiNameRequestType.iScsiName = iScsiName;
				this.VimServiceProxy.UpdateInternetScsiName(new UpdateInternetScsiNameRequest(updateInternetScsiNameRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void UpdateInternetScsiAlias(string iScsiHbaDevice, string iScsiAlias)
		{
			try
			{
				UpdateInternetScsiAliasRequestType updateInternetScsiAliasRequestType = new UpdateInternetScsiAliasRequestType();
				updateInternetScsiAliasRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				updateInternetScsiAliasRequestType.iScsiHbaDevice = iScsiHbaDevice;
				updateInternetScsiAliasRequestType.iScsiAlias = iScsiAlias;
				this.VimServiceProxy.UpdateInternetScsiAlias(new UpdateInternetScsiAliasRequest(updateInternetScsiAliasRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void AddInternetScsiSendTargets(string iScsiHbaDevice, HostInternetScsiHbaSendTarget[] targets)
		{
			try
			{
				AddInternetScsiSendTargetsRequestType addInternetScsiSendTargetsRequestType = new AddInternetScsiSendTargetsRequestType();
				addInternetScsiSendTargetsRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				addInternetScsiSendTargetsRequestType.iScsiHbaDevice = iScsiHbaDevice;
				addInternetScsiSendTargetsRequestType.targets = (VimApi_65.HostInternetScsiHbaSendTarget[])VIConvert.ToWsdlType(targets);
				this.VimServiceProxy.AddInternetScsiSendTargets(new AddInternetScsiSendTargetsRequest(addInternetScsiSendTargetsRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void RemoveInternetScsiSendTargets(string iScsiHbaDevice, HostInternetScsiHbaSendTarget[] targets)
		{
			try
			{
				RemoveInternetScsiSendTargetsRequestType removeInternetScsiSendTargetsRequestType = new RemoveInternetScsiSendTargetsRequestType();
				removeInternetScsiSendTargetsRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				removeInternetScsiSendTargetsRequestType.iScsiHbaDevice = iScsiHbaDevice;
				removeInternetScsiSendTargetsRequestType.targets = (VimApi_65.HostInternetScsiHbaSendTarget[])VIConvert.ToWsdlType(targets);
				this.VimServiceProxy.RemoveInternetScsiSendTargets(new RemoveInternetScsiSendTargetsRequest(removeInternetScsiSendTargetsRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void AddInternetScsiStaticTargets(string iScsiHbaDevice, HostInternetScsiHbaStaticTarget[] targets)
		{
			try
			{
				AddInternetScsiStaticTargetsRequestType addInternetScsiStaticTargetsRequestType = new AddInternetScsiStaticTargetsRequestType();
				addInternetScsiStaticTargetsRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				addInternetScsiStaticTargetsRequestType.iScsiHbaDevice = iScsiHbaDevice;
				addInternetScsiStaticTargetsRequestType.targets = (VimApi_65.HostInternetScsiHbaStaticTarget[])VIConvert.ToWsdlType(targets);
				this.VimServiceProxy.AddInternetScsiStaticTargets(new AddInternetScsiStaticTargetsRequest(addInternetScsiStaticTargetsRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void RemoveInternetScsiStaticTargets(string iScsiHbaDevice, HostInternetScsiHbaStaticTarget[] targets)
		{
			try
			{
				RemoveInternetScsiStaticTargetsRequestType removeInternetScsiStaticTargetsRequestType = new RemoveInternetScsiStaticTargetsRequestType();
				removeInternetScsiStaticTargetsRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				removeInternetScsiStaticTargetsRequestType.iScsiHbaDevice = iScsiHbaDevice;
				removeInternetScsiStaticTargetsRequestType.targets = (VimApi_65.HostInternetScsiHbaStaticTarget[])VIConvert.ToWsdlType(targets);
				this.VimServiceProxy.RemoveInternetScsiStaticTargets(new RemoveInternetScsiStaticTargetsRequest(removeInternetScsiStaticTargetsRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void EnableMultipathPath(string pathName)
		{
			try
			{
				EnableMultipathPathRequestType enableMultipathPathRequestType = new EnableMultipathPathRequestType();
				enableMultipathPathRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				enableMultipathPathRequestType.pathName = pathName;
				this.VimServiceProxy.EnableMultipathPath(new EnableMultipathPathRequest(enableMultipathPathRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void DisableMultipathPath(string pathName)
		{
			try
			{
				DisableMultipathPathRequestType disableMultipathPathRequestType = new DisableMultipathPathRequestType();
				disableMultipathPathRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				disableMultipathPathRequestType.pathName = pathName;
				this.VimServiceProxy.DisableMultipathPath(new DisableMultipathPathRequest(disableMultipathPathRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void SetMultipathLunPolicy(string lunId, HostMultipathInfoLogicalUnitPolicy policy)
		{
			try
			{
				SetMultipathLunPolicyRequestType setMultipathLunPolicyRequestType = new SetMultipathLunPolicyRequestType();
				setMultipathLunPolicyRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				setMultipathLunPolicyRequestType.lunId = lunId;
				setMultipathLunPolicyRequestType.policy = (VimApi_65.HostMultipathInfoLogicalUnitPolicy)VIConvert.ToWsdlType(policy);
				this.VimServiceProxy.SetMultipathLunPolicy(new SetMultipathLunPolicyRequest(setMultipathLunPolicyRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public HostPathSelectionPolicyOption[] QueryPathSelectionPolicyOptions()
		{
			HostPathSelectionPolicyOption[] result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				QueryPathSelectionPolicyOptionsRequestType queryPathSelectionPolicyOptionsRequestType = new QueryPathSelectionPolicyOptionsRequestType();
				queryPathSelectionPolicyOptionsRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				result = (HostPathSelectionPolicyOption[])VIConvert.ToVim(this.VimServiceProxy.QueryPathSelectionPolicyOptions(new QueryPathSelectionPolicyOptionsRequest(queryPathSelectionPolicyOptionsRequestType)).QueryPathSelectionPolicyOptionsResponse1);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public HostStorageArrayTypePolicyOption[] QueryStorageArrayTypePolicyOptions()
		{
			HostStorageArrayTypePolicyOption[] result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				QueryStorageArrayTypePolicyOptionsRequestType queryStorageArrayTypePolicyOptionsRequestType = new QueryStorageArrayTypePolicyOptionsRequestType();
				queryStorageArrayTypePolicyOptionsRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				result = (HostStorageArrayTypePolicyOption[])VIConvert.ToVim(this.VimServiceProxy.QueryStorageArrayTypePolicyOptions(new QueryStorageArrayTypePolicyOptionsRequest(queryStorageArrayTypePolicyOptionsRequestType)).QueryStorageArrayTypePolicyOptionsResponse1);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void UpdateScsiLunDisplayName(string lunUuid, string displayName)
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				UpdateScsiLunDisplayNameRequestType updateScsiLunDisplayNameRequestType = new UpdateScsiLunDisplayNameRequestType();
				updateScsiLunDisplayNameRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				updateScsiLunDisplayNameRequestType.lunUuid = lunUuid;
				updateScsiLunDisplayNameRequestType.displayName = displayName;
				this.VimServiceProxy.UpdateScsiLunDisplayName(new UpdateScsiLunDisplayNameRequest(updateScsiLunDisplayNameRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void DetachScsiLun(string lunUuid)
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim50);
				DetachScsiLunRequestType detachScsiLunRequestType = new DetachScsiLunRequestType();
				detachScsiLunRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				detachScsiLunRequestType.lunUuid = lunUuid;
				this.VimServiceProxy.DetachScsiLun(new DetachScsiLunRequest(detachScsiLunRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public ManagedObjectReference DetachScsiLunEx_Task(string[] lunUuid)
		{
			ManagedObjectReference result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim60);
				DetachScsiLunExRequestType detachScsiLunExRequestType = new DetachScsiLunExRequestType();
				detachScsiLunExRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				detachScsiLunExRequestType.lunUuid = lunUuid;
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.DetachScsiLunEx_Task(new DetachScsiLunEx_TaskRequest(detachScsiLunExRequestType)).DetachScsiLunEx_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public HostStorageSystemScsiLunResult[] DetachScsiLunEx(string[] lunUuid)
		{
			HostStorageSystemScsiLunResult[] result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim60);
				ManagedObjectReference taskReference = this.DetachScsiLunEx_Task(lunUuid);
				result = (HostStorageSystemScsiLunResult[])this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void DeleteScsiLunState(string lunCanonicalName)
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim51);
				DeleteScsiLunStateRequestType deleteScsiLunStateRequestType = new DeleteScsiLunStateRequestType();
				deleteScsiLunStateRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				deleteScsiLunStateRequestType.lunCanonicalName = lunCanonicalName;
				this.VimServiceProxy.DeleteScsiLunState(new DeleteScsiLunStateRequest(deleteScsiLunStateRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void AttachScsiLun(string lunUuid)
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim50);
				AttachScsiLunRequestType attachScsiLunRequestType = new AttachScsiLunRequestType();
				attachScsiLunRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				attachScsiLunRequestType.lunUuid = lunUuid;
				this.VimServiceProxy.AttachScsiLun(new AttachScsiLunRequest(attachScsiLunRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public ManagedObjectReference AttachScsiLunEx_Task(string[] lunUuid)
		{
			ManagedObjectReference result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim60);
				AttachScsiLunExRequestType attachScsiLunExRequestType = new AttachScsiLunExRequestType();
				attachScsiLunExRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				attachScsiLunExRequestType.lunUuid = lunUuid;
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.AttachScsiLunEx_Task(new AttachScsiLunEx_TaskRequest(attachScsiLunExRequestType)).AttachScsiLunEx_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public HostStorageSystemScsiLunResult[] AttachScsiLunEx(string[] lunUuid)
		{
			HostStorageSystemScsiLunResult[] result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim60);
				ManagedObjectReference taskReference = this.AttachScsiLunEx_Task(lunUuid);
				result = (HostStorageSystemScsiLunResult[])this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void RefreshStorageSystem()
		{
			try
			{
				RefreshStorageSystemRequestType refreshStorageSystemRequestType = new RefreshStorageSystemRequestType();
				refreshStorageSystemRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				this.VimServiceProxy.RefreshStorageSystem(new RefreshStorageSystemRequest(refreshStorageSystemRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void DiscoverFcoeHbas(FcoeConfigFcoeSpecification fcoeSpec)
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim50);
				DiscoverFcoeHbasRequestType discoverFcoeHbasRequestType = new DiscoverFcoeHbasRequestType();
				discoverFcoeHbasRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				discoverFcoeHbasRequestType.fcoeSpec = (VimApi_65.FcoeConfigFcoeSpecification)VIConvert.ToWsdlType(fcoeSpec);
				this.VimServiceProxy.DiscoverFcoeHbas(new DiscoverFcoeHbasRequest(discoverFcoeHbasRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void MarkForRemoval(string hbaName, bool remove)
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim50);
				MarkForRemovalRequestType markForRemovalRequestType = new MarkForRemovalRequestType();
				markForRemovalRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				markForRemovalRequestType.hbaName = hbaName;
				markForRemovalRequestType.remove = remove;
				this.VimServiceProxy.MarkForRemoval(new MarkForRemovalRequest(markForRemovalRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public HostVffsVolume FormatVffs(HostVffsSpec createSpec)
		{
			HostVffsVolume result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim55);
				FormatVffsRequestType formatVffsRequestType = new FormatVffsRequestType();
				formatVffsRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				formatVffsRequestType.createSpec = (VimApi_65.HostVffsSpec)VIConvert.ToWsdlType(createSpec);
				result = (HostVffsVolume)VIConvert.ToVim(this.VimServiceProxy.FormatVffs(new FormatVffsRequest(formatVffsRequestType)).FormatVffsResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void ExtendVffs(string vffsPath, string devicePath, HostDiskPartitionSpec spec)
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim55);
				ExtendVffsRequestType extendVffsRequestType = new ExtendVffsRequestType();
				extendVffsRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				extendVffsRequestType.vffsPath = vffsPath;
				extendVffsRequestType.devicePath = devicePath;
				extendVffsRequestType.spec = (VimApi_65.HostDiskPartitionSpec)VIConvert.ToWsdlType(spec);
				this.VimServiceProxy.ExtendVffs(new ExtendVffsRequest(extendVffsRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void DestroyVffs(string vffsPath)
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim55);
				DestroyVffsRequestType destroyVffsRequestType = new DestroyVffsRequestType();
				destroyVffsRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				destroyVffsRequestType.vffsPath = vffsPath;
				this.VimServiceProxy.DestroyVffs(new DestroyVffsRequest(destroyVffsRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void MountVffsVolume(string vffsUuid)
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim55);
				MountVffsVolumeRequestType mountVffsVolumeRequestType = new MountVffsVolumeRequestType();
				mountVffsVolumeRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				mountVffsVolumeRequestType.vffsUuid = vffsUuid;
				this.VimServiceProxy.MountVffsVolume(new MountVffsVolumeRequest(mountVffsVolumeRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void UnmountVffsVolume(string vffsUuid)
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim55);
				UnmountVffsVolumeRequestType unmountVffsVolumeRequestType = new UnmountVffsVolumeRequestType();
				unmountVffsVolumeRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				unmountVffsVolumeRequestType.vffsUuid = vffsUuid;
				this.VimServiceProxy.UnmountVffsVolume(new UnmountVffsVolumeRequest(unmountVffsVolumeRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void DeleteVffsVolumeState(string vffsUuid)
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim55);
				DeleteVffsVolumeStateRequestType deleteVffsVolumeStateRequestType = new DeleteVffsVolumeStateRequestType();
				deleteVffsVolumeStateRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				deleteVffsVolumeStateRequestType.vffsUuid = vffsUuid;
				this.VimServiceProxy.DeleteVffsVolumeState(new DeleteVffsVolumeStateRequest(deleteVffsVolumeStateRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void RescanVffs()
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim55);
				RescanVffsRequestType rescanVffsRequestType = new RescanVffsRequestType();
				rescanVffsRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				this.VimServiceProxy.RescanVffs(new RescanVffsRequest(rescanVffsRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public HostScsiDisk[] QueryAvailableSsds(string vffsPath)
		{
			HostScsiDisk[] result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim55);
				QueryAvailableSsdsRequestType queryAvailableSsdsRequestType = new QueryAvailableSsdsRequestType();
				queryAvailableSsdsRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				queryAvailableSsdsRequestType.vffsPath = vffsPath;
				result = (HostScsiDisk[])VIConvert.ToVim(this.VimServiceProxy.QueryAvailableSsds(new QueryAvailableSsdsRequest(queryAvailableSsdsRequestType)).QueryAvailableSsdsResponse1);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void SetNFSUser(string user, string password)
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim60);
				SetNFSUserRequestType setNFSUserRequestType = new SetNFSUserRequestType();
				setNFSUserRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				setNFSUserRequestType.user = user;
				setNFSUserRequestType.password = password;
				this.VimServiceProxy.SetNFSUser(new SetNFSUserRequest(setNFSUserRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void ChangeNFSUserPassword(string password)
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim60);
				ChangeNFSUserPasswordRequestType changeNFSUserPasswordRequestType = new ChangeNFSUserPasswordRequestType();
				changeNFSUserPasswordRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				changeNFSUserPasswordRequestType.password = password;
				this.VimServiceProxy.ChangeNFSUserPassword(new ChangeNFSUserPasswordRequest(changeNFSUserPasswordRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public HostNasVolumeUserInfo QueryNFSUser()
		{
			HostNasVolumeUserInfo result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim60);
				QueryNFSUserRequestType queryNFSUserRequestType = new QueryNFSUserRequestType();
				queryNFSUserRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				result = (HostNasVolumeUserInfo)VIConvert.ToVim(this.VimServiceProxy.QueryNFSUser(new QueryNFSUserRequest(queryNFSUserRequestType)).QueryNFSUserResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void ClearNFSUser()
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim60);
				ClearNFSUserRequestType clearNFSUserRequestType = new ClearNFSUserRequestType();
				clearNFSUserRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				this.VimServiceProxy.ClearNFSUser(new ClearNFSUserRequest(clearNFSUserRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public ManagedObjectReference TurnDiskLocatorLedOn_Task(string[] scsiDiskUuids)
		{
			ManagedObjectReference result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim60);
				TurnDiskLocatorLedOnRequestType turnDiskLocatorLedOnRequestType = new TurnDiskLocatorLedOnRequestType();
				turnDiskLocatorLedOnRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				turnDiskLocatorLedOnRequestType.scsiDiskUuids = scsiDiskUuids;
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.TurnDiskLocatorLedOn_Task(new TurnDiskLocatorLedOn_TaskRequest(turnDiskLocatorLedOnRequestType)).TurnDiskLocatorLedOn_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public HostStorageSystemDiskLocatorLedResult[] TurnDiskLocatorLedOn(string[] scsiDiskUuids)
		{
			HostStorageSystemDiskLocatorLedResult[] result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim60);
				ManagedObjectReference taskReference = this.TurnDiskLocatorLedOn_Task(scsiDiskUuids);
				result = (HostStorageSystemDiskLocatorLedResult[])this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference TurnDiskLocatorLedOff_Task(string[] scsiDiskUuids)
		{
			ManagedObjectReference result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim60);
				TurnDiskLocatorLedOffRequestType turnDiskLocatorLedOffRequestType = new TurnDiskLocatorLedOffRequestType();
				turnDiskLocatorLedOffRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				turnDiskLocatorLedOffRequestType.scsiDiskUuids = scsiDiskUuids;
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.TurnDiskLocatorLedOff_Task(new TurnDiskLocatorLedOff_TaskRequest(turnDiskLocatorLedOffRequestType)).TurnDiskLocatorLedOff_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public HostStorageSystemDiskLocatorLedResult[] TurnDiskLocatorLedOff(string[] scsiDiskUuids)
		{
			HostStorageSystemDiskLocatorLedResult[] result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim60);
				ManagedObjectReference taskReference = this.TurnDiskLocatorLedOff_Task(scsiDiskUuids);
				result = (HostStorageSystemDiskLocatorLedResult[])this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference MarkAsSsd_Task(string scsiDiskUuid)
		{
			ManagedObjectReference result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim60);
				MarkAsSsdRequestType markAsSsdRequestType = new MarkAsSsdRequestType();
				markAsSsdRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				markAsSsdRequestType.scsiDiskUuid = scsiDiskUuid;
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.MarkAsSsd_Task(new MarkAsSsd_TaskRequest(markAsSsdRequestType)).MarkAsSsd_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void MarkAsSsd(string scsiDiskUuid)
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim60);
				ManagedObjectReference taskReference = this.MarkAsSsd_Task(scsiDiskUuid);
				this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public ManagedObjectReference MarkAsNonSsd_Task(string scsiDiskUuid)
		{
			ManagedObjectReference result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim60);
				MarkAsNonSsdRequestType markAsNonSsdRequestType = new MarkAsNonSsdRequestType();
				markAsNonSsdRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				markAsNonSsdRequestType.scsiDiskUuid = scsiDiskUuid;
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.MarkAsNonSsd_Task(new MarkAsNonSsd_TaskRequest(markAsNonSsdRequestType)).MarkAsNonSsd_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void MarkAsNonSsd(string scsiDiskUuid)
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim60);
				ManagedObjectReference taskReference = this.MarkAsNonSsd_Task(scsiDiskUuid);
				this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public ManagedObjectReference MarkAsLocal_Task(string scsiDiskUuid)
		{
			ManagedObjectReference result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim60);
				MarkAsLocalRequestType markAsLocalRequestType = new MarkAsLocalRequestType();
				markAsLocalRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				markAsLocalRequestType.scsiDiskUuid = scsiDiskUuid;
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.MarkAsLocal_Task(new MarkAsLocal_TaskRequest(markAsLocalRequestType)).MarkAsLocal_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void MarkAsLocal(string scsiDiskUuid)
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim60);
				ManagedObjectReference taskReference = this.MarkAsLocal_Task(scsiDiskUuid);
				this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public ManagedObjectReference MarkAsNonLocal_Task(string scsiDiskUuid)
		{
			ManagedObjectReference result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim60);
				MarkAsNonLocalRequestType markAsNonLocalRequestType = new MarkAsNonLocalRequestType();
				markAsNonLocalRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				markAsNonLocalRequestType.scsiDiskUuid = scsiDiskUuid;
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.MarkAsNonLocal_Task(new MarkAsNonLocal_TaskRequest(markAsNonLocalRequestType)).MarkAsNonLocal_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void MarkAsNonLocal(string scsiDiskUuid)
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim60);
				ManagedObjectReference taskReference = this.MarkAsNonLocal_Task(scsiDiskUuid);
				this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void UpdateVmfsUnmapPriority(string vmfsUuid, string unmapPriority)
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim65);
				UpdateVmfsUnmapPriorityRequestType updateVmfsUnmapPriorityRequestType = new UpdateVmfsUnmapPriorityRequestType();
				updateVmfsUnmapPriorityRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				updateVmfsUnmapPriorityRequestType.vmfsUuid = vmfsUuid;
				updateVmfsUnmapPriorityRequestType.unmapPriority = unmapPriority;
				this.VimServiceProxy.UpdateVmfsUnmapPriority(new UpdateVmfsUnmapPriorityRequest(updateVmfsUnmapPriorityRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public VmfsConfigOption[] QueryVmfsConfigOption()
		{
			VmfsConfigOption[] result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim65);
				QueryVmfsConfigOptionRequestType queryVmfsConfigOptionRequestType = new QueryVmfsConfigOptionRequestType();
				queryVmfsConfigOptionRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				result = (VmfsConfigOption[])VIConvert.ToVim(this.VimServiceProxy.QueryVmfsConfigOption(new QueryVmfsConfigOptionRequest(queryVmfsConfigOptionRequestType)).QueryVmfsConfigOptionResponse1);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
	}
}