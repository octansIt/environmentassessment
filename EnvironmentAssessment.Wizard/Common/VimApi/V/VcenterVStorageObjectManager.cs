using System;
using System.ServiceModel;
using VimApi_65;
namespace EnvironmentAssessment.Common.VimApi
{
	public class VcenterVStorageObjectManager : VStorageObjectManagerBase
	{
		public VcenterVStorageObjectManager(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public ManagedObjectReference CreateDisk_Task(VslmCreateSpec spec)
		{
			ManagedObjectReference result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim65);
				CreateDiskRequestType createDiskRequestType = new CreateDiskRequestType();
				createDiskRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				createDiskRequestType.spec = (VimApi_65.VslmCreateSpec)VIConvert.ToWsdlType(spec);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.CreateDisk_Task(new CreateDisk_TaskRequest(createDiskRequestType)).CreateDisk_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public VStorageObject CreateDisk(VslmCreateSpec spec)
		{
			VStorageObject result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim65);
				ManagedObjectReference taskReference = this.CreateDisk_Task(spec);
				result = (VStorageObject)this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public VStorageObject RegisterDisk(string path, string name)
		{
			VStorageObject result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim65);
				RegisterDiskRequestType registerDiskRequestType = new RegisterDiskRequestType();
				registerDiskRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				registerDiskRequestType.path = path;
				registerDiskRequestType.name = name;
				result = (VStorageObject)VIConvert.ToVim(this.VimServiceProxy.RegisterDisk(new RegisterDiskRequest(registerDiskRequestType)).RegisterDiskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference ExtendDisk_Task(ID id, ManagedObjectReference datastore, long newCapacityInMB)
		{
			ManagedObjectReference result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim65);
				ExtendDiskRequestType extendDiskRequestType = new ExtendDiskRequestType();
				extendDiskRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				extendDiskRequestType.id = (VimApi_65.ID)VIConvert.ToWsdlType(id);
				extendDiskRequestType.datastore = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(datastore);
				extendDiskRequestType.newCapacityInMB = newCapacityInMB;
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.ExtendDisk_Task(new ExtendDisk_TaskRequest(extendDiskRequestType)).ExtendDisk_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void ExtendDisk(ID id, ManagedObjectReference datastore, long newCapacityInMB)
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim65);
				ManagedObjectReference taskReference = this.ExtendDisk_Task(id, datastore, newCapacityInMB);
				this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public ManagedObjectReference InflateDisk_Task(ID id, ManagedObjectReference datastore)
		{
			ManagedObjectReference result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim65);
				InflateDiskRequestType inflateDiskRequestType = new InflateDiskRequestType();
				inflateDiskRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				inflateDiskRequestType.id = (VimApi_65.ID)VIConvert.ToWsdlType(id);
				inflateDiskRequestType.datastore = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(datastore);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.InflateDisk_Task(new InflateDisk_TaskRequest(inflateDiskRequestType)).InflateDisk_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void InflateDisk(ID id, ManagedObjectReference datastore)
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim65);
				ManagedObjectReference taskReference = this.InflateDisk_Task(id, datastore);
				this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void RenameVStorageObject(ID id, ManagedObjectReference datastore, string name)
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim65);
				RenameVStorageObjectRequestType renameVStorageObjectRequestType = new RenameVStorageObjectRequestType();
				renameVStorageObjectRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				renameVStorageObjectRequestType.id = (VimApi_65.ID)VIConvert.ToWsdlType(id);
				renameVStorageObjectRequestType.datastore = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(datastore);
				renameVStorageObjectRequestType.name = name;
				this.VimServiceProxy.RenameVStorageObject(new RenameVStorageObjectRequest(renameVStorageObjectRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public ManagedObjectReference DeleteVStorageObject_Task(ID id, ManagedObjectReference datastore)
		{
			ManagedObjectReference result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim65);
				DeleteVStorageObjectRequestType deleteVStorageObjectRequestType = new DeleteVStorageObjectRequestType();
				deleteVStorageObjectRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				deleteVStorageObjectRequestType.id = (VimApi_65.ID)VIConvert.ToWsdlType(id);
				deleteVStorageObjectRequestType.datastore = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(datastore);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.DeleteVStorageObject_Task(new DeleteVStorageObject_TaskRequest(deleteVStorageObjectRequestType)).DeleteVStorageObject_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void DeleteVStorageObject(ID id, ManagedObjectReference datastore)
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim65);
				ManagedObjectReference taskReference = this.DeleteVStorageObject_Task(id, datastore);
				this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public VStorageObject RetrieveVStorageObject(ID id, ManagedObjectReference datastore)
		{
			VStorageObject result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim65);
				RetrieveVStorageObjectRequestType retrieveVStorageObjectRequestType = new RetrieveVStorageObjectRequestType();
				retrieveVStorageObjectRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				retrieveVStorageObjectRequestType.id = (VimApi_65.ID)VIConvert.ToWsdlType(id);
				retrieveVStorageObjectRequestType.datastore = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(datastore);
				result = (VStorageObject)VIConvert.ToVim(this.VimServiceProxy.RetrieveVStorageObject(new RetrieveVStorageObjectRequest(retrieveVStorageObjectRequestType)).RetrieveVStorageObjectResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public VStorageObjectStateInfo RetrieveVStorageObjectState(ID id, ManagedObjectReference datastore)
		{
			VStorageObjectStateInfo result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim65);
				RetrieveVStorageObjectStateRequestType retrieveVStorageObjectStateRequestType = new RetrieveVStorageObjectStateRequestType();
				retrieveVStorageObjectStateRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				retrieveVStorageObjectStateRequestType.id = (VimApi_65.ID)VIConvert.ToWsdlType(id);
				retrieveVStorageObjectStateRequestType.datastore = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(datastore);
				result = (VStorageObjectStateInfo)VIConvert.ToVim(this.VimServiceProxy.RetrieveVStorageObjectState(new RetrieveVStorageObjectStateRequest(retrieveVStorageObjectStateRequestType)).RetrieveVStorageObjectStateResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ID[] ListVStorageObject(ManagedObjectReference datastore)
		{
			ID[] result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim65);
				ListVStorageObjectRequestType listVStorageObjectRequestType = new ListVStorageObjectRequestType();
				listVStorageObjectRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				listVStorageObjectRequestType.datastore = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(datastore);
				result = (ID[])VIConvert.ToVim(this.VimServiceProxy.ListVStorageObject(new ListVStorageObjectRequest(listVStorageObjectRequestType)).ListVStorageObjectResponse1);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference CloneVStorageObject_Task(ID id, ManagedObjectReference datastore, VslmCloneSpec spec)
		{
			ManagedObjectReference result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim65);
				CloneVStorageObjectRequestType cloneVStorageObjectRequestType = new CloneVStorageObjectRequestType();
				cloneVStorageObjectRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				cloneVStorageObjectRequestType.id = (VimApi_65.ID)VIConvert.ToWsdlType(id);
				cloneVStorageObjectRequestType.datastore = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(datastore);
				cloneVStorageObjectRequestType.spec = (VimApi_65.VslmCloneSpec)VIConvert.ToWsdlType(spec);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.CloneVStorageObject_Task(new CloneVStorageObject_TaskRequest(cloneVStorageObjectRequestType)).CloneVStorageObject_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public VStorageObject CloneVStorageObject(ID id, ManagedObjectReference datastore, VslmCloneSpec spec)
		{
			VStorageObject result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim65);
				ManagedObjectReference taskReference = this.CloneVStorageObject_Task(id, datastore, spec);
				result = (VStorageObject)this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference RelocateVStorageObject_Task(ID id, ManagedObjectReference datastore, VslmRelocateSpec spec)
		{
			ManagedObjectReference result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim65);
				RelocateVStorageObjectRequestType relocateVStorageObjectRequestType = new RelocateVStorageObjectRequestType();
				relocateVStorageObjectRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				relocateVStorageObjectRequestType.id = (VimApi_65.ID)VIConvert.ToWsdlType(id);
				relocateVStorageObjectRequestType.datastore = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(datastore);
				relocateVStorageObjectRequestType.spec = (VimApi_65.VslmRelocateSpec)VIConvert.ToWsdlType(spec);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.RelocateVStorageObject_Task(new RelocateVStorageObject_TaskRequest(relocateVStorageObjectRequestType)).RelocateVStorageObject_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public VStorageObject RelocateVStorageObject(ID id, ManagedObjectReference datastore, VslmRelocateSpec spec)
		{
			VStorageObject result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim65);
				ManagedObjectReference taskReference = this.RelocateVStorageObject_Task(id, datastore, spec);
				result = (VStorageObject)this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void AttachTagToVStorageObject(ID id, string category, string tag)
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim65);
				AttachTagToVStorageObjectRequestType attachTagToVStorageObjectRequestType = new AttachTagToVStorageObjectRequestType();
				attachTagToVStorageObjectRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				attachTagToVStorageObjectRequestType.id = (VimApi_65.ID)VIConvert.ToWsdlType(id);
				attachTagToVStorageObjectRequestType.category = category;
				attachTagToVStorageObjectRequestType.tag = tag;
				this.VimServiceProxy.AttachTagToVStorageObject(new AttachTagToVStorageObjectRequest(attachTagToVStorageObjectRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void DetachTagFromVStorageObject(ID id, string category, string tag)
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim65);
				DetachTagFromVStorageObjectRequestType detachTagFromVStorageObjectRequestType = new DetachTagFromVStorageObjectRequestType();
				detachTagFromVStorageObjectRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				detachTagFromVStorageObjectRequestType.id = (VimApi_65.ID)VIConvert.ToWsdlType(id);
				detachTagFromVStorageObjectRequestType.category = category;
				detachTagFromVStorageObjectRequestType.tag = tag;
				this.VimServiceProxy.DetachTagFromVStorageObject(new DetachTagFromVStorageObjectRequest(detachTagFromVStorageObjectRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public ID[] ListVStorageObjectsAttachedToTag(string category, string tag)
		{
			ID[] result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim65);
				ListVStorageObjectsAttachedToTagRequestType listVStorageObjectsAttachedToTagRequestType = new ListVStorageObjectsAttachedToTagRequestType();
				listVStorageObjectsAttachedToTagRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				listVStorageObjectsAttachedToTagRequestType.category = category;
				listVStorageObjectsAttachedToTagRequestType.tag = tag;
				result = (ID[])VIConvert.ToVim(this.VimServiceProxy.ListVStorageObjectsAttachedToTag(new ListVStorageObjectsAttachedToTagRequest(listVStorageObjectsAttachedToTagRequestType)).ListVStorageObjectsAttachedToTagResponse1);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public VslmTagEntry[] ListTagsAttachedToVStorageObject(ID id)
		{
			VslmTagEntry[] result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim65);
				ListTagsAttachedToVStorageObjectRequestType listTagsAttachedToVStorageObjectRequestType = new ListTagsAttachedToVStorageObjectRequestType();
				listTagsAttachedToVStorageObjectRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				listTagsAttachedToVStorageObjectRequestType.id = (VimApi_65.ID)VIConvert.ToWsdlType(id);
				result = (VslmTagEntry[])VIConvert.ToVim(this.VimServiceProxy.ListTagsAttachedToVStorageObject(new ListTagsAttachedToVStorageObjectRequest(listTagsAttachedToVStorageObjectRequestType)).ListTagsAttachedToVStorageObjectResponse1);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference ReconcileDatastoreInventory_Task(ManagedObjectReference datastore)
		{
			ManagedObjectReference result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim65);
				ReconcileDatastoreInventoryRequestType reconcileDatastoreInventoryRequestType = new ReconcileDatastoreInventoryRequestType();
				reconcileDatastoreInventoryRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				reconcileDatastoreInventoryRequestType.datastore = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(datastore);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.ReconcileDatastoreInventory_Task(new ReconcileDatastoreInventory_TaskRequest(reconcileDatastoreInventoryRequestType)).ReconcileDatastoreInventory_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void ReconcileDatastoreInventory(ManagedObjectReference datastore)
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim65);
				ManagedObjectReference taskReference = this.ReconcileDatastoreInventory_Task(datastore);
				this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void ScheduleReconcileDatastoreInventory(ManagedObjectReference datastore)
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim65);
				ScheduleReconcileDatastoreInventoryRequestType scheduleReconcileDatastoreInventoryRequestType = new ScheduleReconcileDatastoreInventoryRequestType();
				scheduleReconcileDatastoreInventoryRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				scheduleReconcileDatastoreInventoryRequestType.datastore = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(datastore);
				this.VimServiceProxy.ScheduleReconcileDatastoreInventory(new ScheduleReconcileDatastoreInventoryRequest(scheduleReconcileDatastoreInventoryRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
	}
}
