using System;
using System.ServiceModel;
using VimApi_65;
namespace EnvironmentAssessment.Common.VimApi
{
	public class FileManager : ViewBase
	{
		public FileManager(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public ManagedObjectReference MoveDatastoreFile_Task(string sourceName, ManagedObjectReference sourceDatacenter, string destinationName, ManagedObjectReference destinationDatacenter, bool? force)
		{
			ManagedObjectReference result;
			try
			{
				MoveDatastoreFileRequestType moveDatastoreFileRequestType = new MoveDatastoreFileRequestType();
				moveDatastoreFileRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				moveDatastoreFileRequestType.sourceName = sourceName;
				moveDatastoreFileRequestType.sourceDatacenter = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(sourceDatacenter);
				moveDatastoreFileRequestType.destinationName = destinationName;
				moveDatastoreFileRequestType.destinationDatacenter = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(destinationDatacenter);
				moveDatastoreFileRequestType.force = force.GetValueOrDefault();
				moveDatastoreFileRequestType.forceSpecified = force.HasValue;
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.MoveDatastoreFile_Task(new MoveDatastoreFile_TaskRequest(moveDatastoreFileRequestType)).MoveDatastoreFile_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void MoveDatastoreFile(string sourceName, ManagedObjectReference sourceDatacenter, string destinationName, ManagedObjectReference destinationDatacenter, bool? force)
		{
			try
			{
				ManagedObjectReference taskReference = this.MoveDatastoreFile_Task(sourceName, sourceDatacenter, destinationName, destinationDatacenter, force);
				this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public ManagedObjectReference CopyDatastoreFile_Task(string sourceName, ManagedObjectReference sourceDatacenter, string destinationName, ManagedObjectReference destinationDatacenter, bool? force)
		{
			ManagedObjectReference result;
			try
			{
				CopyDatastoreFileRequestType copyDatastoreFileRequestType = new CopyDatastoreFileRequestType();
				copyDatastoreFileRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				copyDatastoreFileRequestType.sourceName = sourceName;
				copyDatastoreFileRequestType.sourceDatacenter = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(sourceDatacenter);
				copyDatastoreFileRequestType.destinationName = destinationName;
				copyDatastoreFileRequestType.destinationDatacenter = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(destinationDatacenter);
				copyDatastoreFileRequestType.force = force.GetValueOrDefault();
				copyDatastoreFileRequestType.forceSpecified = force.HasValue;
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.CopyDatastoreFile_Task(new CopyDatastoreFile_TaskRequest(copyDatastoreFileRequestType)).CopyDatastoreFile_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void CopyDatastoreFile(string sourceName, ManagedObjectReference sourceDatacenter, string destinationName, ManagedObjectReference destinationDatacenter, bool? force)
		{
			try
			{
				ManagedObjectReference taskReference = this.CopyDatastoreFile_Task(sourceName, sourceDatacenter, destinationName, destinationDatacenter, force);
				this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public ManagedObjectReference DeleteDatastoreFile_Task(string name, ManagedObjectReference datacenter)
		{
			ManagedObjectReference result;
			try
			{
				DeleteDatastoreFileRequestType deleteDatastoreFileRequestType = new DeleteDatastoreFileRequestType();
				deleteDatastoreFileRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				deleteDatastoreFileRequestType.name = name;
				deleteDatastoreFileRequestType.datacenter = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(datacenter);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.DeleteDatastoreFile_Task(new DeleteDatastoreFile_TaskRequest(deleteDatastoreFileRequestType)).DeleteDatastoreFile_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void DeleteDatastoreFile(string name, ManagedObjectReference datacenter)
		{
			try
			{
				ManagedObjectReference taskReference = this.DeleteDatastoreFile_Task(name, datacenter);
				this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void MakeDirectory(string name, ManagedObjectReference datacenter, bool? createParentDirectories)
		{
			try
			{
				MakeDirectoryRequestType makeDirectoryRequestType = new MakeDirectoryRequestType();
				makeDirectoryRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				makeDirectoryRequestType.name = name;
				makeDirectoryRequestType.datacenter = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(datacenter);
				makeDirectoryRequestType.createParentDirectories = createParentDirectories.GetValueOrDefault();
				makeDirectoryRequestType.createParentDirectoriesSpecified = createParentDirectories.HasValue;
				this.VimServiceProxy.MakeDirectory(new MakeDirectoryRequest(makeDirectoryRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void ChangeOwner(string name, ManagedObjectReference datacenter, string owner)
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				ChangeOwnerRequestType changeOwnerRequestType = new ChangeOwnerRequestType();
				changeOwnerRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				changeOwnerRequestType.name = name;
				changeOwnerRequestType.datacenter = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(datacenter);
				changeOwnerRequestType.owner = owner;
				this.VimServiceProxy.ChangeOwner(new ChangeOwnerRequest(changeOwnerRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
	}
}
