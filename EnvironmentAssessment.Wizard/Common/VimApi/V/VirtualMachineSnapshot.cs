using System;
using System.ServiceModel;
using VimApi_65;
namespace EnvironmentAssessment.Common.VimApi
{
	public class VirtualMachineSnapshot : ExtensibleManagedObject
	{
		protected VirtualMachineConfigInfo _config;
		protected ManagedObjectReference[] _childSnapshot;
		protected ManagedObjectReference _vm;
		protected VirtualMachineSnapshot_LinkedView _linkedView;
		public VirtualMachineConfigInfo Config
		{
			get
			{
				return this._config;
			}
		}
		public ManagedObjectReference[] ChildSnapshot
		{
			get
			{
				return this._childSnapshot;
			}
		}
		public ManagedObjectReference Vm
		{
			get
			{
				return this._vm;
			}
		}
		public VirtualMachineSnapshot_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
		public VirtualMachineSnapshot(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public ManagedObjectReference RevertToSnapshot_Task(ManagedObjectReference host, bool? suppressPowerOn)
		{
			ManagedObjectReference result;
			try
			{
				RevertToSnapshotRequestType revertToSnapshotRequestType = new RevertToSnapshotRequestType();
				revertToSnapshotRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				revertToSnapshotRequestType.host = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(host);
				revertToSnapshotRequestType.suppressPowerOn = suppressPowerOn.GetValueOrDefault();
				revertToSnapshotRequestType.suppressPowerOnSpecified = suppressPowerOn.HasValue;
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.RevertToSnapshot_Task(new RevertToSnapshot_TaskRequest(revertToSnapshotRequestType)).RevertToSnapshot_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void RevertToSnapshot(ManagedObjectReference host, bool? suppressPowerOn)
		{
			try
			{
				ManagedObjectReference taskReference = this.RevertToSnapshot_Task(host, suppressPowerOn);
				this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public ManagedObjectReference RemoveSnapshot_Task(bool removeChildren, bool? consolidate)
		{
			ManagedObjectReference result;
			try
			{
				RemoveSnapshotRequestType removeSnapshotRequestType = new RemoveSnapshotRequestType();
				removeSnapshotRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				removeSnapshotRequestType.removeChildren = removeChildren;
				removeSnapshotRequestType.consolidate = consolidate.GetValueOrDefault();
				removeSnapshotRequestType.consolidateSpecified = consolidate.HasValue;
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.RemoveSnapshot_Task(new RemoveSnapshot_TaskRequest(removeSnapshotRequestType)).RemoveSnapshot_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void RemoveSnapshot(bool removeChildren, bool? consolidate)
		{
			try
			{
				ManagedObjectReference taskReference = this.RemoveSnapshot_Task(removeChildren, consolidate);
				this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void RenameSnapshot(string name, string description)
		{
			try
			{
				RenameSnapshotRequestType renameSnapshotRequestType = new RenameSnapshotRequestType();
				renameSnapshotRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				renameSnapshotRequestType.name = name;
				renameSnapshotRequestType.description = description;
				this.VimServiceProxy.RenameSnapshot(new RenameSnapshotRequest(renameSnapshotRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public ManagedObjectReference ExportSnapshot()
		{
			ManagedObjectReference result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim55);
				ExportSnapshotRequestType exportSnapshotRequestType = new ExportSnapshotRequestType();
				exportSnapshotRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.ExportSnapshot(new ExportSnapshotRequest(exportSnapshotRequestType)).ExportSnapshotResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
	}
}
