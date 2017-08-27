using System.ServiceModel;
using VimApi_65;namespace EnvironmentAssessment.Common.VimApi
{
	public class HostVStorageObjectManager : VStorageObjectManagerBase
	{
		public HostVStorageObjectManager(IVimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public ManagedObjectReference HostCreateDisk_Task(VslmCreateSpec spec)
		{
			ManagedObjectReference result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim65);
				HostCreateDiskRequestType hostCreateDiskRequestType = new HostCreateDiskRequestType();
				hostCreateDiskRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				hostCreateDiskRequestType.spec = (VimApi_65.VslmCreateSpec)VIConvert.ToWsdlType(spec);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.HostCreateDisk_Task(new HostCreateDisk_TaskRequest(hostCreateDiskRequestType)).HostCreateDisk_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public VStorageObject HostCreateDisk(VslmCreateSpec spec)
		{
			VStorageObject result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim65);
				ManagedObjectReference taskReference = this.HostCreateDisk_Task(spec);
				result = (VStorageObject)this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public VStorageObject HostRegisterDisk(string path, string name)
		{
			VStorageObject result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim65);
				HostRegisterDiskRequestType hostRegisterDiskRequestType = new HostRegisterDiskRequestType();
				hostRegisterDiskRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				hostRegisterDiskRequestType.path = path;
				hostRegisterDiskRequestType.name = name;
				result = (VStorageObject)VIConvert.ToVim(this.VimServiceProxy.HostRegisterDisk(new HostRegisterDiskRequest(hostRegisterDiskRequestType)).HostRegisterDiskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference HostExtendDisk_Task(ID id, ManagedObjectReference datastore, long newCapacityInMB)
		{
			ManagedObjectReference result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim65);
				HostExtendDiskRequestType hostExtendDiskRequestType = new HostExtendDiskRequestType();
				hostExtendDiskRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				hostExtendDiskRequestType.id = (VimApi_65.ID)VIConvert.ToWsdlType(id);
				hostExtendDiskRequestType.datastore = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(datastore);
				hostExtendDiskRequestType.newCapacityInMB = newCapacityInMB;
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.HostExtendDisk_Task(new HostExtendDisk_TaskRequest(hostExtendDiskRequestType)).HostExtendDisk_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void HostExtendDisk(ID id, ManagedObjectReference datastore, long newCapacityInMB)
		{
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim65);
				ManagedObjectReference taskReference = this.HostExtendDisk_Task(id, datastore, newCapacityInMB);
				this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public ManagedObjectReference HostInflateDisk_Task(ID id, ManagedObjectReference datastore)
		{
			ManagedObjectReference result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim65);
				HostInflateDiskRequestType hostInflateDiskRequestType = new HostInflateDiskRequestType();
				hostInflateDiskRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				hostInflateDiskRequestType.id = (VimApi_65.ID)VIConvert.ToWsdlType(id);
				hostInflateDiskRequestType.datastore = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(datastore);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.HostInflateDisk_Task(new HostInflateDisk_TaskRequest(hostInflateDiskRequestType)).HostInflateDisk_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void HostInflateDisk(ID id, ManagedObjectReference datastore)
		{
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim65);
				ManagedObjectReference taskReference = this.HostInflateDisk_Task(id, datastore);
				this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void HostRenameVStorageObject(ID id, ManagedObjectReference datastore, string name)
		{
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim65);
				HostRenameVStorageObjectRequestType hostRenameVStorageObjectRequestType = new HostRenameVStorageObjectRequestType();
				hostRenameVStorageObjectRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				hostRenameVStorageObjectRequestType.id = (VimApi_65.ID)VIConvert.ToWsdlType(id);
				hostRenameVStorageObjectRequestType.datastore = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(datastore);
				hostRenameVStorageObjectRequestType.name = name;
				this.VimServiceProxy.HostRenameVStorageObject(new HostRenameVStorageObjectRequest(hostRenameVStorageObjectRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public ManagedObjectReference HostDeleteVStorageObject_Task(ID id, ManagedObjectReference datastore)
		{
			ManagedObjectReference result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim65);
				HostDeleteVStorageObjectRequestType hostDeleteVStorageObjectRequestType = new HostDeleteVStorageObjectRequestType();
				hostDeleteVStorageObjectRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				hostDeleteVStorageObjectRequestType.id = (VimApi_65.ID)VIConvert.ToWsdlType(id);
				hostDeleteVStorageObjectRequestType.datastore = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(datastore);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.HostDeleteVStorageObject_Task(new HostDeleteVStorageObject_TaskRequest(hostDeleteVStorageObjectRequestType)).HostDeleteVStorageObject_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void HostDeleteVStorageObject(ID id, ManagedObjectReference datastore)
		{
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim65);
				ManagedObjectReference taskReference = this.HostDeleteVStorageObject_Task(id, datastore);
				this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public VStorageObject HostRetrieveVStorageObject(ID id, ManagedObjectReference datastore)
		{
			VStorageObject result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim65);
				HostRetrieveVStorageObjectRequestType hostRetrieveVStorageObjectRequestType = new HostRetrieveVStorageObjectRequestType();
				hostRetrieveVStorageObjectRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				hostRetrieveVStorageObjectRequestType.id = (VimApi_65.ID)VIConvert.ToWsdlType(id);
				hostRetrieveVStorageObjectRequestType.datastore = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(datastore);
				result = (VStorageObject)VIConvert.ToVim(this.VimServiceProxy.HostRetrieveVStorageObject(new HostRetrieveVStorageObjectRequest(hostRetrieveVStorageObjectRequestType)).HostRetrieveVStorageObjectResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public VStorageObjectStateInfo HostRetrieveVStorageObjectState(ID id, ManagedObjectReference datastore)
		{
			VStorageObjectStateInfo result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim65);
				HostRetrieveVStorageObjectStateRequestType hostRetrieveVStorageObjectStateRequestType = new HostRetrieveVStorageObjectStateRequestType();
				hostRetrieveVStorageObjectStateRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				hostRetrieveVStorageObjectStateRequestType.id = (VimApi_65.ID)VIConvert.ToWsdlType(id);
				hostRetrieveVStorageObjectStateRequestType.datastore = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(datastore);
				result = (VStorageObjectStateInfo)VIConvert.ToVim(this.VimServiceProxy.HostRetrieveVStorageObjectState(new HostRetrieveVStorageObjectStateRequest(hostRetrieveVStorageObjectStateRequestType)).HostRetrieveVStorageObjectStateResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ID[] HostListVStorageObject(ManagedObjectReference datastore)
		{
			ID[] result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim65);
				HostListVStorageObjectRequestType hostListVStorageObjectRequestType = new HostListVStorageObjectRequestType();
				hostListVStorageObjectRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				hostListVStorageObjectRequestType.datastore = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(datastore);
				result = (ID[])VIConvert.ToVim(this.VimServiceProxy.HostListVStorageObject(new HostListVStorageObjectRequest(hostListVStorageObjectRequestType)).HostListVStorageObjectResponse1);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference HostCloneVStorageObject_Task(ID id, ManagedObjectReference datastore, VslmCloneSpec spec)
		{
			ManagedObjectReference result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim65);
				HostCloneVStorageObjectRequestType hostCloneVStorageObjectRequestType = new HostCloneVStorageObjectRequestType();
				hostCloneVStorageObjectRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				hostCloneVStorageObjectRequestType.id = (VimApi_65.ID)VIConvert.ToWsdlType(id);
				hostCloneVStorageObjectRequestType.datastore = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(datastore);
				hostCloneVStorageObjectRequestType.spec = (VimApi_65.VslmCloneSpec)VIConvert.ToWsdlType(spec);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.HostCloneVStorageObject_Task(new HostCloneVStorageObject_TaskRequest(hostCloneVStorageObjectRequestType)).HostCloneVStorageObject_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public VStorageObject HostCloneVStorageObject(ID id, ManagedObjectReference datastore, VslmCloneSpec spec)
		{
			VStorageObject result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim65);
				ManagedObjectReference taskReference = this.HostCloneVStorageObject_Task(id, datastore, spec);
				result = (VStorageObject)this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference HostRelocateVStorageObject_Task(ID id, ManagedObjectReference datastore, VslmRelocateSpec spec)
		{
			ManagedObjectReference result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim65);
				HostRelocateVStorageObjectRequestType hostRelocateVStorageObjectRequestType = new HostRelocateVStorageObjectRequestType();
				hostRelocateVStorageObjectRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				hostRelocateVStorageObjectRequestType.id = (VimApi_65.ID)VIConvert.ToWsdlType(id);
				hostRelocateVStorageObjectRequestType.datastore = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(datastore);
				hostRelocateVStorageObjectRequestType.spec = (VimApi_65.VslmRelocateSpec)VIConvert.ToWsdlType(spec);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.HostRelocateVStorageObject_Task(new HostRelocateVStorageObject_TaskRequest(hostRelocateVStorageObjectRequestType)).HostRelocateVStorageObject_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public VStorageObject HostRelocateVStorageObject(ID id, ManagedObjectReference datastore, VslmRelocateSpec spec)
		{
			VStorageObject result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim65);
				ManagedObjectReference taskReference = this.HostRelocateVStorageObject_Task(id, datastore, spec);
				result = (VStorageObject)this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference HostReconcileDatastoreInventory_Task(ManagedObjectReference datastore)
		{
			ManagedObjectReference result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim65);
				HostReconcileDatastoreInventoryRequestType hostReconcileDatastoreInventoryRequestType = new HostReconcileDatastoreInventoryRequestType();
				hostReconcileDatastoreInventoryRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				hostReconcileDatastoreInventoryRequestType.datastore = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(datastore);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.HostReconcileDatastoreInventory_Task(new HostReconcileDatastoreInventory_TaskRequest(hostReconcileDatastoreInventoryRequestType)).HostReconcileDatastoreInventory_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void HostReconcileDatastoreInventory(ManagedObjectReference datastore)
		{
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim65);
				ManagedObjectReference taskReference = this.HostReconcileDatastoreInventory_Task(datastore);
				this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void HostScheduleReconcileDatastoreInventory(ManagedObjectReference datastore)
		{
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim65);
				HostScheduleReconcileDatastoreInventoryRequestType hostScheduleReconcileDatastoreInventoryRequestType = new HostScheduleReconcileDatastoreInventoryRequestType();
				hostScheduleReconcileDatastoreInventoryRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				hostScheduleReconcileDatastoreInventoryRequestType.datastore = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(datastore);
				this.VimServiceProxy.HostScheduleReconcileDatastoreInventory(new HostScheduleReconcileDatastoreInventoryRequest(hostScheduleReconcileDatastoreInventoryRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
	}
}
