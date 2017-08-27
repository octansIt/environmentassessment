using System.ServiceModel;
using VimApi_65;
namespace EnvironmentAssessment.Common.VimApi
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
				UpdateLocalSwapDatastoreRequestType updateLocalSwapDatastoreRequestType = new UpdateLocalSwapDatastoreRequestType();
				updateLocalSwapDatastoreRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				updateLocalSwapDatastoreRequestType.datastore = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(datastore);
				this.VimServiceProxy.UpdateLocalSwapDatastore(new UpdateLocalSwapDatastoreRequest(updateLocalSwapDatastoreRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public HostScsiDisk[] QueryAvailableDisksForVmfs(ManagedObjectReference datastore)
		{
			HostScsiDisk[] result;
			try
			{
				QueryAvailableDisksForVmfsRequestType queryAvailableDisksForVmfsRequestType = new QueryAvailableDisksForVmfsRequestType();
				queryAvailableDisksForVmfsRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				queryAvailableDisksForVmfsRequestType.datastore = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(datastore);
				result = (HostScsiDisk[])VIConvert.ToVim(this.VimServiceProxy.QueryAvailableDisksForVmfs(new QueryAvailableDisksForVmfsRequest(queryAvailableDisksForVmfsRequestType)).QueryAvailableDisksForVmfsResponse1);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public VmfsDatastoreOption[] QueryVmfsDatastoreCreateOptions(string devicePath, int? vmfsMajorVersion)
		{
			VmfsDatastoreOption[] result;
			try
			{
				QueryVmfsDatastoreCreateOptionsRequestType queryVmfsDatastoreCreateOptionsRequestType = new QueryVmfsDatastoreCreateOptionsRequestType();
				queryVmfsDatastoreCreateOptionsRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				queryVmfsDatastoreCreateOptionsRequestType.devicePath = devicePath;
				queryVmfsDatastoreCreateOptionsRequestType.vmfsMajorVersion = vmfsMajorVersion.GetValueOrDefault();
				queryVmfsDatastoreCreateOptionsRequestType.vmfsMajorVersionSpecified = vmfsMajorVersion.HasValue;
				result = (VmfsDatastoreOption[])VIConvert.ToVim(this.VimServiceProxy.QueryVmfsDatastoreCreateOptions(new QueryVmfsDatastoreCreateOptionsRequest(queryVmfsDatastoreCreateOptionsRequestType)).QueryVmfsDatastoreCreateOptionsResponse1);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference CreateVmfsDatastore(VmfsDatastoreCreateSpec spec)
		{
			ManagedObjectReference result;
			try
			{
				CreateVmfsDatastoreRequestType createVmfsDatastoreRequestType = new CreateVmfsDatastoreRequestType();
				createVmfsDatastoreRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				createVmfsDatastoreRequestType.spec = (VimApi_65.VmfsDatastoreCreateSpec)VIConvert.ToWsdlType(spec);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.CreateVmfsDatastore(new CreateVmfsDatastoreRequest(createVmfsDatastoreRequestType)).CreateVmfsDatastoreResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public VmfsDatastoreOption[] QueryVmfsDatastoreExtendOptions(ManagedObjectReference datastore, string devicePath, bool? suppressExpandCandidates)
		{
			VmfsDatastoreOption[] result;
			try
			{
				QueryVmfsDatastoreExtendOptionsRequestType queryVmfsDatastoreExtendOptionsRequestType = new QueryVmfsDatastoreExtendOptionsRequestType();
				queryVmfsDatastoreExtendOptionsRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				queryVmfsDatastoreExtendOptionsRequestType.datastore = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(datastore);
				queryVmfsDatastoreExtendOptionsRequestType.devicePath = devicePath;
				queryVmfsDatastoreExtendOptionsRequestType.suppressExpandCandidates = suppressExpandCandidates.GetValueOrDefault();
				queryVmfsDatastoreExtendOptionsRequestType.suppressExpandCandidatesSpecified = suppressExpandCandidates.HasValue;
				result = (VmfsDatastoreOption[])VIConvert.ToVim(this.VimServiceProxy.QueryVmfsDatastoreExtendOptions(new QueryVmfsDatastoreExtendOptionsRequest(queryVmfsDatastoreExtendOptionsRequestType)).QueryVmfsDatastoreExtendOptionsResponse1);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public VmfsDatastoreOption[] QueryVmfsDatastoreExpandOptions(ManagedObjectReference datastore)
		{
			VmfsDatastoreOption[] result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				QueryVmfsDatastoreExpandOptionsRequestType queryVmfsDatastoreExpandOptionsRequestType = new QueryVmfsDatastoreExpandOptionsRequestType();
				queryVmfsDatastoreExpandOptionsRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				queryVmfsDatastoreExpandOptionsRequestType.datastore = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(datastore);
				result = (VmfsDatastoreOption[])VIConvert.ToVim(this.VimServiceProxy.QueryVmfsDatastoreExpandOptions(new QueryVmfsDatastoreExpandOptionsRequest(queryVmfsDatastoreExpandOptionsRequestType)).QueryVmfsDatastoreExpandOptionsResponse1);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference ExtendVmfsDatastore(ManagedObjectReference datastore, VmfsDatastoreExtendSpec spec)
		{
			ManagedObjectReference result;
			try
			{
				ExtendVmfsDatastoreRequestType extendVmfsDatastoreRequestType = new ExtendVmfsDatastoreRequestType();
				extendVmfsDatastoreRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				extendVmfsDatastoreRequestType.datastore = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(datastore);
				extendVmfsDatastoreRequestType.spec = (VimApi_65.VmfsDatastoreExtendSpec)VIConvert.ToWsdlType(spec);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.ExtendVmfsDatastore(new ExtendVmfsDatastoreRequest(extendVmfsDatastoreRequestType)).ExtendVmfsDatastoreResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference ExpandVmfsDatastore(ManagedObjectReference datastore, VmfsDatastoreExpandSpec spec)
		{
			ManagedObjectReference result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				ExpandVmfsDatastoreRequestType expandVmfsDatastoreRequestType = new ExpandVmfsDatastoreRequestType();
				expandVmfsDatastoreRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				expandVmfsDatastoreRequestType.datastore = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(datastore);
				expandVmfsDatastoreRequestType.spec = (VimApi_65.VmfsDatastoreExpandSpec)VIConvert.ToWsdlType(spec);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.ExpandVmfsDatastore(new ExpandVmfsDatastoreRequest(expandVmfsDatastoreRequestType)).ExpandVmfsDatastoreResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference CreateNasDatastore(HostNasVolumeSpec spec)
		{
			ManagedObjectReference result;
			try
			{
				CreateNasDatastoreRequestType createNasDatastoreRequestType = new CreateNasDatastoreRequestType();
				createNasDatastoreRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				createNasDatastoreRequestType.spec = (VimApi_65.HostNasVolumeSpec)VIConvert.ToWsdlType(spec);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.CreateNasDatastore(new CreateNasDatastoreRequest(createNasDatastoreRequestType)).CreateNasDatastoreResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference CreateLocalDatastore(string name, string path)
		{
			ManagedObjectReference result;
			try
			{
				CreateLocalDatastoreRequestType createLocalDatastoreRequestType = new CreateLocalDatastoreRequestType();
				createLocalDatastoreRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				createLocalDatastoreRequestType.name = name;
				createLocalDatastoreRequestType.path = path;
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.CreateLocalDatastore(new CreateLocalDatastoreRequest(createLocalDatastoreRequestType)).CreateLocalDatastoreResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference CreateVvolDatastore(HostDatastoreSystemVvolDatastoreSpec spec)
		{
			ManagedObjectReference result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim60);
				CreateVvolDatastoreRequestType createVvolDatastoreRequestType = new CreateVvolDatastoreRequestType();
				createVvolDatastoreRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				createVvolDatastoreRequestType.spec = (VimApi_65.HostDatastoreSystemVvolDatastoreSpec)VIConvert.ToWsdlType(spec);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.CreateVvolDatastore(new CreateVvolDatastoreRequest(createVvolDatastoreRequestType)).CreateVvolDatastoreResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void RemoveDatastore(ManagedObjectReference datastore)
		{
			try
			{
				RemoveDatastoreRequestType removeDatastoreRequestType = new RemoveDatastoreRequestType();
				removeDatastoreRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				removeDatastoreRequestType.datastore = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(datastore);
				this.VimServiceProxy.RemoveDatastore(new RemoveDatastoreRequest(removeDatastoreRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public ManagedObjectReference RemoveDatastoreEx_Task(ManagedObjectReference[] datastore)
		{
			ManagedObjectReference result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim60);
				RemoveDatastoreExRequestType removeDatastoreExRequestType = new RemoveDatastoreExRequestType();
				removeDatastoreExRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				removeDatastoreExRequestType.datastore = (VimApi_65.ManagedObjectReference[])VIConvert.ToWsdlType(datastore);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.RemoveDatastoreEx_Task(new RemoveDatastoreEx_TaskRequest(removeDatastoreExRequestType)).RemoveDatastoreEx_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public HostDatastoreSystemDatastoreResult[] RemoveDatastoreEx(ManagedObjectReference[] datastore)
		{
			HostDatastoreSystemDatastoreResult[] result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim60);
				ManagedObjectReference taskReference = this.RemoveDatastoreEx_Task(datastore);
				result = (HostDatastoreSystemDatastoreResult[])this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void ConfigureDatastorePrincipal(string userName, string password)
		{
			try
			{
				ConfigureDatastorePrincipalRequestType configureDatastorePrincipalRequestType = new ConfigureDatastorePrincipalRequestType();
				configureDatastorePrincipalRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				configureDatastorePrincipalRequestType.userName = userName;
				configureDatastorePrincipalRequestType.password = password;
				this.VimServiceProxy.ConfigureDatastorePrincipal(new ConfigureDatastorePrincipalRequest(configureDatastorePrincipalRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public HostUnresolvedVmfsVolume[] QueryUnresolvedVmfsVolumes()
		{
			HostUnresolvedVmfsVolume[] result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				QueryUnresolvedVmfsVolumesRequestType queryUnresolvedVmfsVolumesRequestType = new QueryUnresolvedVmfsVolumesRequestType();
				queryUnresolvedVmfsVolumesRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				result = (HostUnresolvedVmfsVolume[])VIConvert.ToVim(this.VimServiceProxy.QueryUnresolvedVmfsVolumes(new QueryUnresolvedVmfsVolumesRequest(queryUnresolvedVmfsVolumesRequestType)).QueryUnresolvedVmfsVolumesResponse1);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference ResignatureUnresolvedVmfsVolume_Task(HostUnresolvedVmfsResignatureSpec resolutionSpec)
		{
			ManagedObjectReference result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				ResignatureUnresolvedVmfsVolumeRequestType resignatureUnresolvedVmfsVolumeRequestType = new ResignatureUnresolvedVmfsVolumeRequestType();
				resignatureUnresolvedVmfsVolumeRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				resignatureUnresolvedVmfsVolumeRequestType.resolutionSpec = (VimApi_65.HostUnresolvedVmfsResignatureSpec)VIConvert.ToWsdlType(resolutionSpec);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.ResignatureUnresolvedVmfsVolume_Task(new ResignatureUnresolvedVmfsVolume_TaskRequest(resignatureUnresolvedVmfsVolumeRequestType)).ResignatureUnresolvedVmfsVolume_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public HostResignatureRescanResult ResignatureUnresolvedVmfsVolume(HostUnresolvedVmfsResignatureSpec resolutionSpec)
		{
			HostResignatureRescanResult result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				ManagedObjectReference taskReference = this.ResignatureUnresolvedVmfsVolume_Task(resolutionSpec);
				result = (HostResignatureRescanResult)this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
	}
}
