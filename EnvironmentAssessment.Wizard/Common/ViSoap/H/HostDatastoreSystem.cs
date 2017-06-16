using System;
using System.Web.Services.Protocols;
using VimApi_60;
namespace EnvironmentAssessment.Common.VISoap
{
	public class HostDatastoreSystem : ViewBase
	{
		protected ManagedObjectReference[] _datastore;
		protected HostDatastoreSystemCapabilities _capabilities;
		protected HostDatastoreSystem_LinkedView _linkedView;
		public ManagedObjectReference[] Datastore
		{
			get
			{
				return this._datastore;
			}
		}
		public HostDatastoreSystemCapabilities Capabilities
		{
			get
			{
				return this._capabilities;
			}
		}
		public HostDatastoreSystem_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
		public HostDatastoreSystem(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public void UpdateLocalSwapDatastore(ManagedObjectReference datastore)
		{
			try
			{
				((VimService)this.Client.VimService).UpdateLocalSwapDatastore((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(datastore));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public HostScsiDisk[] QueryAvailableDisksForVmfs(ManagedObjectReference datastore)
		{
			HostScsiDisk[] result;
			try
			{
				result = (HostScsiDisk[])VIConvert.ToVim(((VimService)this.Client.VimService).QueryAvailableDisksForVmfs((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(datastore)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public VmfsDatastoreOption[] QueryVmfsDatastoreCreateOptions(string devicePath, int? vmfsMajorVersion)
		{
			VmfsDatastoreOption[] result;
			try
			{
				result = (VmfsDatastoreOption[])VIConvert.ToVim(((VimService)this.Client.VimService).QueryVmfsDatastoreCreateOptions((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), devicePath, vmfsMajorVersion.GetValueOrDefault(), vmfsMajorVersion.HasValue));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public ManagedObjectReference CreateVmfsDatastore(VmfsDatastoreCreateSpec spec)
		{
			ManagedObjectReference result;
			try
			{
				result = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).CreateVmfsDatastore((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.VmfsDatastoreCreateSpec)VIConvert.ToWsdlType(spec)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public VmfsDatastoreOption[] QueryVmfsDatastoreExtendOptions(ManagedObjectReference datastore, string devicePath, bool? suppressExpandCandidates)
		{
			VmfsDatastoreOption[] result;
			try
			{
				result = (VmfsDatastoreOption[])VIConvert.ToVim(((VimService)this.Client.VimService).QueryVmfsDatastoreExtendOptions((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(datastore), devicePath, suppressExpandCandidates.GetValueOrDefault(), suppressExpandCandidates.HasValue));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public VmfsDatastoreOption[] QueryVmfsDatastoreExpandOptions(ManagedObjectReference datastore)
		{
			VmfsDatastoreOption[] result;
			try
			{
				if (this.Client.Version == VimVersion.Vim25)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				result = (VmfsDatastoreOption[])VIConvert.ToVim(((VimService)this.Client.VimService).QueryVmfsDatastoreExpandOptions((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(datastore)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public ManagedObjectReference ExtendVmfsDatastore(ManagedObjectReference datastore, VmfsDatastoreExtendSpec spec)
		{
			ManagedObjectReference result;
			try
			{
				result = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).ExtendVmfsDatastore((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(datastore), (VimApi_60.VmfsDatastoreExtendSpec)VIConvert.ToWsdlType(spec)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public ManagedObjectReference ExpandVmfsDatastore(ManagedObjectReference datastore, VmfsDatastoreExpandSpec spec)
		{
			ManagedObjectReference result;
			try
			{
				if (this.Client.Version == VimVersion.Vim25)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				result = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).ExpandVmfsDatastore((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(datastore), (VimApi_60.VmfsDatastoreExpandSpec)VIConvert.ToWsdlType(spec)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public ManagedObjectReference CreateNasDatastore(HostNasVolumeSpec spec)
		{
			ManagedObjectReference result;
			try
			{
				result = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).CreateNasDatastore((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.HostNasVolumeSpec)VIConvert.ToWsdlType(spec)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public ManagedObjectReference CreateLocalDatastore(string name, string path)
		{
			ManagedObjectReference result;
			try
			{
				result = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).CreateLocalDatastore((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), name, path));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public void RemoveDatastore(ManagedObjectReference datastore)
		{
			try
			{
				((VimService)this.Client.VimService).RemoveDatastore((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(datastore));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public void ConfigureDatastorePrincipal(string userName, string password)
		{
			try
			{
				((VimService)this.Client.VimService).ConfigureDatastorePrincipal((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), userName, password);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public HostUnresolvedVmfsVolume[] QueryUnresolvedVmfsVolumes()
		{
			HostUnresolvedVmfsVolume[] result;
			try
			{
				if (this.Client.Version == VimVersion.Vim25)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				result = (HostUnresolvedVmfsVolume[])VIConvert.ToVim(((VimService)this.Client.VimService).QueryUnresolvedVmfsVolumes((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public ManagedObjectReference ResignatureUnresolvedVmfsVolume_Task(HostUnresolvedVmfsResignatureSpec resolutionSpec)
		{
			ManagedObjectReference result;
			try
			{
				if (this.Client.Version == VimVersion.Vim25)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				result = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).ResignatureUnresolvedVmfsVolume_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.HostUnresolvedVmfsResignatureSpec)VIConvert.ToWsdlType(resolutionSpec)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public HostResignatureRescanResult ResignatureUnresolvedVmfsVolume(HostUnresolvedVmfsResignatureSpec resolutionSpec)
		{
			HostResignatureRescanResult result;
			try
			{
				if (this.Client.Version == VimVersion.Vim25)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				ManagedObjectReference taskReference = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).ResignatureUnresolvedVmfsVolume_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.HostUnresolvedVmfsResignatureSpec)VIConvert.ToWsdlType(resolutionSpec)));
				result = (HostResignatureRescanResult)this.Client.WaitForTask(taskReference);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
	}
}
