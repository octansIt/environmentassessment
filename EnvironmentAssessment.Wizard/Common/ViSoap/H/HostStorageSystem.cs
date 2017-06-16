using System;
using System.Web.Services.Protocols;
using VimApi_60;
namespace EnvironmentAssessment.Common.VISoap
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
				result = (HostDiskPartitionInfo[])VIConvert.ToVim(((VimService)this.Client.VimService).RetrieveDiskPartitionInfo((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), devicePath));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public HostDiskPartitionInfo ComputeDiskPartitionInfo(string devicePath, HostDiskPartitionLayout layout, string partitionFormat)
		{
			HostDiskPartitionInfo result;
			try
			{
				result = (HostDiskPartitionInfo)VIConvert.ToVim(((VimService)this.Client.VimService).ComputeDiskPartitionInfo((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), devicePath, (VimApi_60.HostDiskPartitionLayout)VIConvert.ToWsdlType(layout), partitionFormat));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public HostDiskPartitionInfo ComputeDiskPartitionInfoForResize(HostScsiDiskPartition partition, HostDiskPartitionBlockRange blockRange, string partitionFormat)
		{
			HostDiskPartitionInfo result;
			try
			{
				if (this.Client.Version == VimVersion.Vim25)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				result = (HostDiskPartitionInfo)VIConvert.ToVim(((VimService)this.Client.VimService).ComputeDiskPartitionInfoForResize((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.HostScsiDiskPartition)VIConvert.ToWsdlType(partition), (VimApi_60.HostDiskPartitionBlockRange)VIConvert.ToWsdlType(blockRange), partitionFormat));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public void UpdateDiskPartitions(string devicePath, HostDiskPartitionSpec spec)
		{
			try
			{
				((VimService)this.Client.VimService).UpdateDiskPartitions((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), devicePath, (VimApi_60.HostDiskPartitionSpec)VIConvert.ToWsdlType(spec));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public HostVmfsVolume FormatVmfs(HostVmfsSpec createSpec)
		{
			HostVmfsVolume result;
			try
			{
				result = (HostVmfsVolume)VIConvert.ToVim(((VimService)this.Client.VimService).FormatVmfs((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.HostVmfsSpec)VIConvert.ToWsdlType(createSpec)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public void MountVmfsVolume(string vmfsUuid)
		{
			try
			{
				if (this.Client.Version == VimVersion.Vim25)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				if (this.Client.Version == VimVersion.Vim4)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				if (this.Client.Version == VimVersion.Vim41)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				((VimService)this.Client.VimService).MountVmfsVolume((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), vmfsUuid);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public void UnmountVmfsVolume(string vmfsUuid)
		{
			try
			{
				if (this.Client.Version == VimVersion.Vim25)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				if (this.Client.Version == VimVersion.Vim4)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				if (this.Client.Version == VimVersion.Vim41)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				((VimService)this.Client.VimService).UnmountVmfsVolume((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), vmfsUuid);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public void DeleteVmfsVolumeState(string vmfsUuid)
		{
			try
			{
				if (this.Client.Version == VimVersion.Vim25)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				if (this.Client.Version == VimVersion.Vim4)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				if (this.Client.Version == VimVersion.Vim41)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				if (this.Client.Version == VimVersion.Vim50)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				((VimService)this.Client.VimService).DeleteVmfsVolumeState((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), vmfsUuid);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public void RescanVmfs()
		{
			try
			{
				((VimService)this.Client.VimService).RescanVmfs((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public void AttachVmfsExtent(string vmfsPath, HostScsiDiskPartition extent)
		{
			try
			{
				((VimService)this.Client.VimService).AttachVmfsExtent((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), vmfsPath, (VimApi_60.HostScsiDiskPartition)VIConvert.ToWsdlType(extent));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public void ExpandVmfsExtent(string vmfsPath, HostScsiDiskPartition extent)
		{
			try
			{
				if (this.Client.Version == VimVersion.Vim25)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				((VimService)this.Client.VimService).ExpandVmfsExtent((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), vmfsPath, (VimApi_60.HostScsiDiskPartition)VIConvert.ToWsdlType(extent));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public void UpgradeVmfs(string vmfsPath)
		{
			try
			{
				((VimService)this.Client.VimService).UpgradeVmfs((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), vmfsPath);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public void UpgradeVmLayout()
		{
			try
			{
				((VimService)this.Client.VimService).UpgradeVmLayout((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public HostUnresolvedVmfsVolume[] QueryUnresolvedVmfsVolume()
		{
			HostUnresolvedVmfsVolume[] result;
			try
			{
				if (this.Client.Version == VimVersion.Vim25)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				result = (HostUnresolvedVmfsVolume[])VIConvert.ToVim(((VimService)this.Client.VimService).QueryUnresolvedVmfsVolume((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public HostUnresolvedVmfsResolutionResult[] ResolveMultipleUnresolvedVmfsVolumes(HostUnresolvedVmfsResolutionSpec[] resolutionSpec)
		{
			HostUnresolvedVmfsResolutionResult[] result;
			try
			{
				if (this.Client.Version == VimVersion.Vim25)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				result = (HostUnresolvedVmfsResolutionResult[])VIConvert.ToVim(((VimService)this.Client.VimService).ResolveMultipleUnresolvedVmfsVolumes((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.HostUnresolvedVmfsResolutionSpec[])VIConvert.ToWsdlType(resolutionSpec)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public ManagedObjectReference ResolveMultipleUnresolvedVmfsVolumesEx_Task(HostUnresolvedVmfsResolutionSpec[] resolutionSpec)
		{
			ManagedObjectReference result;
			try
			{
				if (this.Client.Version == VimVersion.Vim25)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				if (this.Client.Version == VimVersion.Vim4)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				if (this.Client.Version == VimVersion.Vim41)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				if (this.Client.Version == VimVersion.Vim50)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				if (this.Client.Version == VimVersion.Vim51)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				result = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).ResolveMultipleUnresolvedVmfsVolumesEx_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.HostUnresolvedVmfsResolutionSpec[])VIConvert.ToWsdlType(resolutionSpec)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public HostUnresolvedVmfsResolutionResult[] ResolveMultipleUnresolvedVmfsVolumesEx(HostUnresolvedVmfsResolutionSpec[] resolutionSpec)
		{
			HostUnresolvedVmfsResolutionResult[] result;
			try
			{
				if (this.Client.Version == VimVersion.Vim25)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				if (this.Client.Version == VimVersion.Vim4)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				if (this.Client.Version == VimVersion.Vim41)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				if (this.Client.Version == VimVersion.Vim50)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				if (this.Client.Version == VimVersion.Vim51)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				ManagedObjectReference taskReference = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).ResolveMultipleUnresolvedVmfsVolumesEx_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.HostUnresolvedVmfsResolutionSpec[])VIConvert.ToWsdlType(resolutionSpec)));
				result = (HostUnresolvedVmfsResolutionResult[])this.Client.WaitForTask(taskReference);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public void UnmountForceMountedVmfsVolume(string vmfsUuid)
		{
			try
			{
				if (this.Client.Version == VimVersion.Vim25)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				((VimService)this.Client.VimService).UnmountForceMountedVmfsVolume((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), vmfsUuid);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public void RescanHba(string hbaDevice)
		{
			try
			{
				((VimService)this.Client.VimService).RescanHba((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), hbaDevice);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public void RescanAllHba()
		{
			try
			{
				((VimService)this.Client.VimService).RescanAllHba((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public void UpdateSoftwareInternetScsiEnabled(bool enabled)
		{
			try
			{
				((VimService)this.Client.VimService).UpdateSoftwareInternetScsiEnabled((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), enabled);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public void UpdateInternetScsiDiscoveryProperties(string iScsiHbaDevice, HostInternetScsiHbaDiscoveryProperties discoveryProperties)
		{
			try
			{
				((VimService)this.Client.VimService).UpdateInternetScsiDiscoveryProperties((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), iScsiHbaDevice, (VimApi_60.HostInternetScsiHbaDiscoveryProperties)VIConvert.ToWsdlType(discoveryProperties));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public void UpdateInternetScsiAuthenticationProperties(string iScsiHbaDevice, HostInternetScsiHbaAuthenticationProperties authenticationProperties, HostInternetScsiHbaTargetSet targetSet)
		{
			try
			{
				((VimService)this.Client.VimService).UpdateInternetScsiAuthenticationProperties((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), iScsiHbaDevice, (VimApi_60.HostInternetScsiHbaAuthenticationProperties)VIConvert.ToWsdlType(authenticationProperties), (VimApi_60.HostInternetScsiHbaTargetSet)VIConvert.ToWsdlType(targetSet));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public void UpdateInternetScsiDigestProperties(string iScsiHbaDevice, HostInternetScsiHbaTargetSet targetSet, HostInternetScsiHbaDigestProperties digestProperties)
		{
			try
			{
				if (this.Client.Version == VimVersion.Vim25)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				((VimService)this.Client.VimService).UpdateInternetScsiDigestProperties((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), iScsiHbaDevice, (VimApi_60.HostInternetScsiHbaTargetSet)VIConvert.ToWsdlType(targetSet), (VimApi_60.HostInternetScsiHbaDigestProperties)VIConvert.ToWsdlType(digestProperties));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public void UpdateInternetScsiAdvancedOptions(string iScsiHbaDevice, HostInternetScsiHbaTargetSet targetSet, HostInternetScsiHbaParamValue[] options)
		{
			try
			{
				if (this.Client.Version == VimVersion.Vim25)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				((VimService)this.Client.VimService).UpdateInternetScsiAdvancedOptions((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), iScsiHbaDevice, (VimApi_60.HostInternetScsiHbaTargetSet)VIConvert.ToWsdlType(targetSet), (VimApi_60.HostInternetScsiHbaParamValue[])VIConvert.ToWsdlType(options));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public void UpdateInternetScsiIPProperties(string iScsiHbaDevice, HostInternetScsiHbaIPProperties ipProperties)
		{
			try
			{
				((VimService)this.Client.VimService).UpdateInternetScsiIPProperties((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), iScsiHbaDevice, (VimApi_60.HostInternetScsiHbaIPProperties)VIConvert.ToWsdlType(ipProperties));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public void UpdateInternetScsiName(string iScsiHbaDevice, string iScsiName)
		{
			try
			{
				((VimService)this.Client.VimService).UpdateInternetScsiName((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), iScsiHbaDevice, iScsiName);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public void UpdateInternetScsiAlias(string iScsiHbaDevice, string iScsiAlias)
		{
			try
			{
				((VimService)this.Client.VimService).UpdateInternetScsiAlias((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), iScsiHbaDevice, iScsiAlias);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public void AddInternetScsiSendTargets(string iScsiHbaDevice, HostInternetScsiHbaSendTarget[] targets)
		{
			try
			{
				((VimService)this.Client.VimService).AddInternetScsiSendTargets((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), iScsiHbaDevice, (VimApi_60.HostInternetScsiHbaSendTarget[])VIConvert.ToWsdlType(targets));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public void RemoveInternetScsiSendTargets(string iScsiHbaDevice, HostInternetScsiHbaSendTarget[] targets)
		{
			try
			{
				((VimService)this.Client.VimService).RemoveInternetScsiSendTargets((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), iScsiHbaDevice, (VimApi_60.HostInternetScsiHbaSendTarget[])VIConvert.ToWsdlType(targets));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public void AddInternetScsiStaticTargets(string iScsiHbaDevice, HostInternetScsiHbaStaticTarget[] targets)
		{
			try
			{
				((VimService)this.Client.VimService).AddInternetScsiStaticTargets((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), iScsiHbaDevice, (VimApi_60.HostInternetScsiHbaStaticTarget[])VIConvert.ToWsdlType(targets));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public void RemoveInternetScsiStaticTargets(string iScsiHbaDevice, HostInternetScsiHbaStaticTarget[] targets)
		{
			try
			{
				((VimService)this.Client.VimService).RemoveInternetScsiStaticTargets((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), iScsiHbaDevice, (VimApi_60.HostInternetScsiHbaStaticTarget[])VIConvert.ToWsdlType(targets));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public void EnableMultipathPath(string pathName)
		{
			try
			{
				((VimService)this.Client.VimService).EnableMultipathPath((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), pathName);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public void DisableMultipathPath(string pathName)
		{
			try
			{
				((VimService)this.Client.VimService).DisableMultipathPath((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), pathName);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public void SetMultipathLunPolicy(string lunId, HostMultipathInfoLogicalUnitPolicy policy)
		{
			try
			{
				((VimService)this.Client.VimService).SetMultipathLunPolicy((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), lunId, (VimApi_60.HostMultipathInfoLogicalUnitPolicy)VIConvert.ToWsdlType(policy));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public HostPathSelectionPolicyOption[] QueryPathSelectionPolicyOptions()
		{
			HostPathSelectionPolicyOption[] result;
			try
			{
				if (this.Client.Version == VimVersion.Vim25)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				result = (HostPathSelectionPolicyOption[])VIConvert.ToVim(((VimService)this.Client.VimService).QueryPathSelectionPolicyOptions((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public HostStorageArrayTypePolicyOption[] QueryStorageArrayTypePolicyOptions()
		{
			HostStorageArrayTypePolicyOption[] result;
			try
			{
				if (this.Client.Version == VimVersion.Vim25)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				result = (HostStorageArrayTypePolicyOption[])VIConvert.ToVim(((VimService)this.Client.VimService).QueryStorageArrayTypePolicyOptions((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public void UpdateScsiLunDisplayName(string lunUuid, string displayName)
		{
			try
			{
				if (this.Client.Version == VimVersion.Vim25)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				((VimService)this.Client.VimService).UpdateScsiLunDisplayName((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), lunUuid, displayName);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public void DetachScsiLun(string lunUuid)
		{
			try
			{
				if (this.Client.Version == VimVersion.Vim25)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				if (this.Client.Version == VimVersion.Vim4)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				if (this.Client.Version == VimVersion.Vim41)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				((VimService)this.Client.VimService).DetachScsiLun((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), lunUuid);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public void DeleteScsiLunState(string lunCanonicalName)
		{
			try
			{
				if (this.Client.Version == VimVersion.Vim25)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				if (this.Client.Version == VimVersion.Vim4)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				if (this.Client.Version == VimVersion.Vim41)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				if (this.Client.Version == VimVersion.Vim50)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				((VimService)this.Client.VimService).DeleteScsiLunState((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), lunCanonicalName);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public void AttachScsiLun(string lunUuid)
		{
			try
			{
				if (this.Client.Version == VimVersion.Vim25)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				if (this.Client.Version == VimVersion.Vim4)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				if (this.Client.Version == VimVersion.Vim41)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				((VimService)this.Client.VimService).AttachScsiLun((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), lunUuid);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public void RefreshStorageSystem()
		{
			try
			{
				((VimService)this.Client.VimService).RefreshStorageSystem((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public void DiscoverFcoeHbas(FcoeConfigFcoeSpecification fcoeSpec)
		{
			try
			{
				if (this.Client.Version == VimVersion.Vim25)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				if (this.Client.Version == VimVersion.Vim4)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				if (this.Client.Version == VimVersion.Vim41)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				((VimService)this.Client.VimService).DiscoverFcoeHbas((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.FcoeConfigFcoeSpecification)VIConvert.ToWsdlType(fcoeSpec));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public void MarkForRemoval(string hbaName, bool remove)
		{
			try
			{
				if (this.Client.Version == VimVersion.Vim25)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				if (this.Client.Version == VimVersion.Vim4)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				if (this.Client.Version == VimVersion.Vim41)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				((VimService)this.Client.VimService).MarkForRemoval((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), hbaName, remove);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public HostVffsVolume FormatVffs(HostVffsSpec createSpec)
		{
			HostVffsVolume result;
			try
			{
				if (this.Client.Version == VimVersion.Vim25)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				if (this.Client.Version == VimVersion.Vim4)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				if (this.Client.Version == VimVersion.Vim41)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				if (this.Client.Version == VimVersion.Vim50)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				if (this.Client.Version == VimVersion.Vim51)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				result = (HostVffsVolume)VIConvert.ToVim(((VimService)this.Client.VimService).FormatVffs((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.HostVffsSpec)VIConvert.ToWsdlType(createSpec)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public void ExtendVffs(string vffsPath, string devicePath, HostDiskPartitionSpec spec)
		{
			try
			{
				if (this.Client.Version == VimVersion.Vim25)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				if (this.Client.Version == VimVersion.Vim4)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				if (this.Client.Version == VimVersion.Vim41)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				if (this.Client.Version == VimVersion.Vim50)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				if (this.Client.Version == VimVersion.Vim51)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				((VimService)this.Client.VimService).ExtendVffs((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), vffsPath, devicePath, (VimApi_60.HostDiskPartitionSpec)VIConvert.ToWsdlType(spec));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public void DestroyVffs(string vffsPath)
		{
			try
			{
				if (this.Client.Version == VimVersion.Vim25)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				if (this.Client.Version == VimVersion.Vim4)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				if (this.Client.Version == VimVersion.Vim41)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				if (this.Client.Version == VimVersion.Vim50)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				if (this.Client.Version == VimVersion.Vim51)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				((VimService)this.Client.VimService).DestroyVffs((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), vffsPath);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public void MountVffsVolume(string vffsUuid)
		{
			try
			{
				if (this.Client.Version == VimVersion.Vim25)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				if (this.Client.Version == VimVersion.Vim4)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				if (this.Client.Version == VimVersion.Vim41)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				if (this.Client.Version == VimVersion.Vim50)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				if (this.Client.Version == VimVersion.Vim51)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				((VimService)this.Client.VimService).MountVffsVolume((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), vffsUuid);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public void UnmountVffsVolume(string vffsUuid)
		{
			try
			{
				if (this.Client.Version == VimVersion.Vim25)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				if (this.Client.Version == VimVersion.Vim4)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				if (this.Client.Version == VimVersion.Vim41)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				if (this.Client.Version == VimVersion.Vim50)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				if (this.Client.Version == VimVersion.Vim51)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				((VimService)this.Client.VimService).UnmountVffsVolume((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), vffsUuid);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public void DeleteVffsVolumeState(string vffsUuid)
		{
			try
			{
				if (this.Client.Version == VimVersion.Vim25)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				if (this.Client.Version == VimVersion.Vim4)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				if (this.Client.Version == VimVersion.Vim41)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				if (this.Client.Version == VimVersion.Vim50)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				if (this.Client.Version == VimVersion.Vim51)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				((VimService)this.Client.VimService).DeleteVffsVolumeState((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), vffsUuid);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public void RescanVffs()
		{
			try
			{
				if (this.Client.Version == VimVersion.Vim25)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				if (this.Client.Version == VimVersion.Vim4)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				if (this.Client.Version == VimVersion.Vim41)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				if (this.Client.Version == VimVersion.Vim50)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				if (this.Client.Version == VimVersion.Vim51)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				((VimService)this.Client.VimService).RescanVffs((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public HostScsiDisk[] QueryAvailableSsds(string vffsPath)
		{
			HostScsiDisk[] result;
			try
			{
				if (this.Client.Version == VimVersion.Vim25)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				if (this.Client.Version == VimVersion.Vim4)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				if (this.Client.Version == VimVersion.Vim41)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				if (this.Client.Version == VimVersion.Vim50)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				if (this.Client.Version == VimVersion.Vim51)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				result = (HostScsiDisk[])VIConvert.ToVim(((VimService)this.Client.VimService).QueryAvailableSsds((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), vffsPath));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
	}
}
