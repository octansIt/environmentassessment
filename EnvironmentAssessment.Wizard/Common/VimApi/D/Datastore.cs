using System.ServiceModel;
using VimApi_65;
namespace EnvironmentAssessment.Common.VimApi
{
	public class Datastore : ManagedEntity
	{
		protected DatastoreInfo _info;
		protected DatastoreSummary _summary;
		protected DatastoreHostMount[] _host;
		protected ManagedObjectReference[] _vm;
		protected ManagedObjectReference _browser;
		protected DatastoreCapability _capability;
		protected StorageIORMInfo _iormConfiguration;
		public DatastoreInfo Info
		{
			get
			{
				return this._info;
			}
		}
		public DatastoreSummary Summary
		{
			get
			{
				return this._summary;
			}
		}
		public DatastoreHostMount[] Host
		{
			get
			{
				return this._host;
			}
		}
		public ManagedObjectReference[] Vm
		{
			get
			{
				return this._vm;
			}
		}
		public ManagedObjectReference Browser
		{
			get
			{
				return this._browser;
			}
		}
		public DatastoreCapability Capability
		{
			get
			{
				return this._capability;
			}
		}
		public StorageIORMInfo IormConfiguration
		{
			get
			{
				return this._iormConfiguration;
			}
		}
		public new Datastore_LinkedView LinkedView
		{
			get
			{
				return (Datastore_LinkedView)this._linkedView;
			}
		}
		public Datastore(IVimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public void RefreshDatastore()
		{
			try
			{
				RefreshDatastoreRequestType refreshDatastoreRequestType = new RefreshDatastoreRequestType();
				refreshDatastoreRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				this.VimServiceProxy.RefreshDatastore(new RefreshDatastoreRequest(refreshDatastoreRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void RefreshDatastoreStorageInfo()
		{
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				RefreshDatastoreStorageInfoRequestType refreshDatastoreStorageInfoRequestType = new RefreshDatastoreStorageInfoRequestType();
				refreshDatastoreStorageInfoRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				this.VimServiceProxy.RefreshDatastoreStorageInfo(new RefreshDatastoreStorageInfoRequest(refreshDatastoreStorageInfoRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public ManagedObjectReference UpdateVirtualMachineFiles_Task(DatastoreMountPathDatastorePair[] mountPathDatastoreMapping)
		{
			ManagedObjectReference result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim41);
				UpdateVirtualMachineFilesRequestType updateVirtualMachineFilesRequestType = new UpdateVirtualMachineFilesRequestType();
				updateVirtualMachineFilesRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				updateVirtualMachineFilesRequestType.mountPathDatastoreMapping = (VimApi_65.DatastoreMountPathDatastorePair[])VIConvert.ToWsdlType(mountPathDatastoreMapping);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.UpdateVirtualMachineFiles_Task(new UpdateVirtualMachineFiles_TaskRequest(updateVirtualMachineFilesRequestType)).UpdateVirtualMachineFiles_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public UpdateVirtualMachineFilesResult UpdateVirtualMachineFiles(DatastoreMountPathDatastorePair[] mountPathDatastoreMapping)
		{
			UpdateVirtualMachineFilesResult result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim41);
				ManagedObjectReference taskReference = this.UpdateVirtualMachineFiles_Task(mountPathDatastoreMapping);
				result = (UpdateVirtualMachineFilesResult)this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void RenameDatastore(string newName)
		{
			try
			{
				RenameDatastoreRequestType renameDatastoreRequestType = new RenameDatastoreRequestType();
				renameDatastoreRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				renameDatastoreRequestType.newName = newName;
				this.VimServiceProxy.RenameDatastore(new RenameDatastoreRequest(renameDatastoreRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void DestroyDatastore()
		{
			try
			{
				DestroyDatastoreRequestType destroyDatastoreRequestType = new DestroyDatastoreRequestType();
				destroyDatastoreRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				this.VimServiceProxy.DestroyDatastore(new DestroyDatastoreRequest(destroyDatastoreRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public StoragePlacementResult DatastoreEnterMaintenanceMode()
		{
			StoragePlacementResult result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim50);
				DatastoreEnterMaintenanceModeRequestType datastoreEnterMaintenanceModeRequestType = new DatastoreEnterMaintenanceModeRequestType();
				datastoreEnterMaintenanceModeRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				result = (StoragePlacementResult)VIConvert.ToVim(this.VimServiceProxy.DatastoreEnterMaintenanceMode(new DatastoreEnterMaintenanceModeRequest(datastoreEnterMaintenanceModeRequestType)).DatastoreEnterMaintenanceModeResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference DatastoreExitMaintenanceMode_Task()
		{
			ManagedObjectReference result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim50);
				DatastoreExitMaintenanceModeRequestType datastoreExitMaintenanceModeRequestType = new DatastoreExitMaintenanceModeRequestType();
				datastoreExitMaintenanceModeRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.DatastoreExitMaintenanceMode_Task(new DatastoreExitMaintenanceMode_TaskRequest(datastoreExitMaintenanceModeRequestType)).DatastoreExitMaintenanceMode_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void DatastoreExitMaintenanceMode()
		{
			try
			{	
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim50);
				ManagedObjectReference taskReference = this.DatastoreExitMaintenanceMode_Task();
				this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public ManagedObjectReference UpdateVVolVirtualMachineFiles_Task(DatastoreVVolContainerFailoverPair[] failoverPair)
		{
			ManagedObjectReference result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim65);
				UpdateVVolVirtualMachineFilesRequestType updateVVolVirtualMachineFilesRequestType = new UpdateVVolVirtualMachineFilesRequestType();
				updateVVolVirtualMachineFilesRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				updateVVolVirtualMachineFilesRequestType.failoverPair = (VimApi_65.DatastoreVVolContainerFailoverPair[])VIConvert.ToWsdlType(failoverPair);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.UpdateVVolVirtualMachineFiles_Task(new UpdateVVolVirtualMachineFiles_TaskRequest(updateVVolVirtualMachineFilesRequestType)).UpdateVVolVirtualMachineFiles_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public VVolVmConfigFileUpdateResult UpdateVVolVirtualMachineFiles(DatastoreVVolContainerFailoverPair[] failoverPair)
		{
			VVolVmConfigFileUpdateResult result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim65);
				ManagedObjectReference taskReference = this.UpdateVVolVirtualMachineFiles_Task(failoverPair);
				result = (VVolVmConfigFileUpdateResult)this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
	}
}
