using System;
using System.ServiceModel;
using VimApi_65;
namespace EnvironmentAssessment.Common.VimApi
{
	public class VirtualDiskManager : ViewBase
	{
		public VirtualDiskManager(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public ManagedObjectReference CreateVirtualDisk_Task(string name, ManagedObjectReference datacenter, VirtualDiskSpec spec)
		{
			ManagedObjectReference result;
			try
			{
				CreateVirtualDiskRequestType createVirtualDiskRequestType = new CreateVirtualDiskRequestType();
				createVirtualDiskRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				createVirtualDiskRequestType.name = name;
				createVirtualDiskRequestType.datacenter = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(datacenter);
				createVirtualDiskRequestType.spec = (VimApi_65.VirtualDiskSpec)VIConvert.ToWsdlType(spec);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.CreateVirtualDisk_Task(new CreateVirtualDisk_TaskRequest(createVirtualDiskRequestType)).CreateVirtualDisk_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public string CreateVirtualDisk(string name, ManagedObjectReference datacenter, VirtualDiskSpec spec)
		{
			string result;
			try
			{
				ManagedObjectReference taskReference = this.CreateVirtualDisk_Task(name, datacenter, spec);
				result = (string)this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference DeleteVirtualDisk_Task(string name, ManagedObjectReference datacenter)
		{
			ManagedObjectReference result;
			try
			{
				DeleteVirtualDiskRequestType deleteVirtualDiskRequestType = new DeleteVirtualDiskRequestType();
				deleteVirtualDiskRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				deleteVirtualDiskRequestType.name = name;
				deleteVirtualDiskRequestType.datacenter = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(datacenter);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.DeleteVirtualDisk_Task(new DeleteVirtualDisk_TaskRequest(deleteVirtualDiskRequestType)).DeleteVirtualDisk_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void DeleteVirtualDisk(string name, ManagedObjectReference datacenter)
		{
			try
			{
				ManagedObjectReference taskReference = this.DeleteVirtualDisk_Task(name, datacenter);
				this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		
		[Obsolete("The method MoveVirtualDisk in VirtualDiskManager is deprecated in version 5.1.")]
		public string MoveVirtualDisk(string sourceName, ManagedObjectReference sourceDatacenter, string destName, ManagedObjectReference destDatacenter, bool? force)
		{
			return this.MoveVirtualDisk(sourceName, sourceDatacenter, destName, destDatacenter, force, null);
		}
		[Obsolete("The method MoveVirtualDisk_Task in VirtualDiskManager is deprecated in version 5.1.")]
		public ManagedObjectReference MoveVirtualDisk_Task(string sourceName, ManagedObjectReference sourceDatacenter, string destName, ManagedObjectReference destDatacenter, bool? force)
		{
			return this.MoveVirtualDisk_Task(sourceName, sourceDatacenter, destName, destDatacenter, force, null);
		}
		
		public ManagedObjectReference MoveVirtualDisk_Task(string sourceName, ManagedObjectReference sourceDatacenter, string destName, ManagedObjectReference destDatacenter, bool? force, VirtualMachineProfileSpec[] profile)
		{
			ManagedObjectReference result;
			try
			{
				MoveVirtualDiskRequestType moveVirtualDiskRequestType = new MoveVirtualDiskRequestType();
				moveVirtualDiskRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				moveVirtualDiskRequestType.sourceName = sourceName;
				moveVirtualDiskRequestType.sourceDatacenter = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(sourceDatacenter);
				moveVirtualDiskRequestType.destName = destName;
				moveVirtualDiskRequestType.destDatacenter = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(destDatacenter);
				moveVirtualDiskRequestType.force = force.GetValueOrDefault();
				moveVirtualDiskRequestType.forceSpecified = force.HasValue;
				moveVirtualDiskRequestType.profile = (VimApi_65.VirtualMachineProfileSpec[])VIConvert.ToWsdlType(profile);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.MoveVirtualDisk_Task(new MoveVirtualDisk_TaskRequest(moveVirtualDiskRequestType)).MoveVirtualDisk_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public string MoveVirtualDisk(string sourceName, ManagedObjectReference sourceDatacenter, string destName, ManagedObjectReference destDatacenter, bool? force, VirtualMachineProfileSpec[] profile)
		{
			string result;
			try
			{
				ManagedObjectReference taskReference = this.MoveVirtualDisk_Task(sourceName, sourceDatacenter, destName, destDatacenter, force, profile);
				result = (string)this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference CopyVirtualDisk_Task(string sourceName, ManagedObjectReference sourceDatacenter, string destName, ManagedObjectReference destDatacenter, VirtualDiskSpec destSpec, bool? force)
		{
			ManagedObjectReference result;
			try
			{
				CopyVirtualDiskRequestType copyVirtualDiskRequestType = new CopyVirtualDiskRequestType();
				copyVirtualDiskRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				copyVirtualDiskRequestType.sourceName = sourceName;
				copyVirtualDiskRequestType.sourceDatacenter = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(sourceDatacenter);
				copyVirtualDiskRequestType.destName = destName;
				copyVirtualDiskRequestType.destDatacenter = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(destDatacenter);
				copyVirtualDiskRequestType.destSpec = (VimApi_65.VirtualDiskSpec)VIConvert.ToWsdlType(destSpec);
				copyVirtualDiskRequestType.force = force.GetValueOrDefault();
				copyVirtualDiskRequestType.forceSpecified = force.HasValue;
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.CopyVirtualDisk_Task(new CopyVirtualDisk_TaskRequest(copyVirtualDiskRequestType)).CopyVirtualDisk_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public string CopyVirtualDisk(string sourceName, ManagedObjectReference sourceDatacenter, string destName, ManagedObjectReference destDatacenter, VirtualDiskSpec destSpec, bool? force)
		{
			string result;
			try
			{
				ManagedObjectReference taskReference = this.CopyVirtualDisk_Task(sourceName, sourceDatacenter, destName, destDatacenter, destSpec, force);
				result = (string)this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference ExtendVirtualDisk_Task(string name, ManagedObjectReference datacenter, long newCapacityKb, bool? eagerZero)
		{
			ManagedObjectReference result;
			try
			{
				ExtendVirtualDiskRequestType extendVirtualDiskRequestType = new ExtendVirtualDiskRequestType();
				extendVirtualDiskRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				extendVirtualDiskRequestType.name = name;
				extendVirtualDiskRequestType.datacenter = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(datacenter);
				extendVirtualDiskRequestType.newCapacityKb = newCapacityKb;
				extendVirtualDiskRequestType.eagerZero = eagerZero.GetValueOrDefault();
				extendVirtualDiskRequestType.eagerZeroSpecified = eagerZero.HasValue;
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.ExtendVirtualDisk_Task(new ExtendVirtualDisk_TaskRequest(extendVirtualDiskRequestType)).ExtendVirtualDisk_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void ExtendVirtualDisk(string name, ManagedObjectReference datacenter, long newCapacityKb, bool? eagerZero)
		{
			try
			{
				ManagedObjectReference taskReference = this.ExtendVirtualDisk_Task(name, datacenter, newCapacityKb, eagerZero);
				this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public int QueryVirtualDiskFragmentation(string name, ManagedObjectReference datacenter)
		{
			int returnval;
			try
			{
				QueryVirtualDiskFragmentationRequestType queryVirtualDiskFragmentationRequestType = new QueryVirtualDiskFragmentationRequestType();
				queryVirtualDiskFragmentationRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				queryVirtualDiskFragmentationRequestType.name = name;
				queryVirtualDiskFragmentationRequestType.datacenter = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(datacenter);
				returnval = this.VimServiceProxy.QueryVirtualDiskFragmentation(new QueryVirtualDiskFragmentationRequest(queryVirtualDiskFragmentationRequestType)).QueryVirtualDiskFragmentationResponse.returnval;
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return returnval;
		}
		public ManagedObjectReference DefragmentVirtualDisk_Task(string name, ManagedObjectReference datacenter)
		{
			ManagedObjectReference result;
			try
			{
				DefragmentVirtualDiskRequestType defragmentVirtualDiskRequestType = new DefragmentVirtualDiskRequestType();
				defragmentVirtualDiskRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				defragmentVirtualDiskRequestType.name = name;
				defragmentVirtualDiskRequestType.datacenter = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(datacenter);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.DefragmentVirtualDisk_Task(new DefragmentVirtualDisk_TaskRequest(defragmentVirtualDiskRequestType)).DefragmentVirtualDisk_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void DefragmentVirtualDisk(string name, ManagedObjectReference datacenter)
		{
			try
			{
				ManagedObjectReference taskReference = this.DefragmentVirtualDisk_Task(name, datacenter);
				this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public ManagedObjectReference ShrinkVirtualDisk_Task(string name, ManagedObjectReference datacenter, bool? copy)
		{
			ManagedObjectReference result;
			try
			{
				ShrinkVirtualDiskRequestType shrinkVirtualDiskRequestType = new ShrinkVirtualDiskRequestType();
				shrinkVirtualDiskRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				shrinkVirtualDiskRequestType.name = name;
				shrinkVirtualDiskRequestType.datacenter = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(datacenter);
				shrinkVirtualDiskRequestType.copy = copy.GetValueOrDefault();
				shrinkVirtualDiskRequestType.copySpecified = copy.HasValue;
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.ShrinkVirtualDisk_Task(new ShrinkVirtualDisk_TaskRequest(shrinkVirtualDiskRequestType)).ShrinkVirtualDisk_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void ShrinkVirtualDisk(string name, ManagedObjectReference datacenter, bool? copy)
		{
			try
			{
				ManagedObjectReference taskReference = this.ShrinkVirtualDisk_Task(name, datacenter, copy);
				this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public ManagedObjectReference InflateVirtualDisk_Task(string name, ManagedObjectReference datacenter)
		{
			ManagedObjectReference result;
			try
			{
				InflateVirtualDiskRequestType inflateVirtualDiskRequestType = new InflateVirtualDiskRequestType();
				inflateVirtualDiskRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				inflateVirtualDiskRequestType.name = name;
				inflateVirtualDiskRequestType.datacenter = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(datacenter);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.InflateVirtualDisk_Task(new InflateVirtualDisk_TaskRequest(inflateVirtualDiskRequestType)).InflateVirtualDisk_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void InflateVirtualDisk(string name, ManagedObjectReference datacenter)
		{
			try
			{
				ManagedObjectReference taskReference = this.InflateVirtualDisk_Task(name, datacenter);
				this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public ManagedObjectReference EagerZeroVirtualDisk_Task(string name, ManagedObjectReference datacenter)
		{
			ManagedObjectReference result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				EagerZeroVirtualDiskRequestType eagerZeroVirtualDiskRequestType = new EagerZeroVirtualDiskRequestType();
				eagerZeroVirtualDiskRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				eagerZeroVirtualDiskRequestType.name = name;
				eagerZeroVirtualDiskRequestType.datacenter = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(datacenter);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.EagerZeroVirtualDisk_Task(new EagerZeroVirtualDisk_TaskRequest(eagerZeroVirtualDiskRequestType)).EagerZeroVirtualDisk_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void EagerZeroVirtualDisk(string name, ManagedObjectReference datacenter)
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				ManagedObjectReference taskReference = this.EagerZeroVirtualDisk_Task(name, datacenter);
				this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public ManagedObjectReference ZeroFillVirtualDisk_Task(string name, ManagedObjectReference datacenter)
		{
			ManagedObjectReference result;
			try
			{
				ZeroFillVirtualDiskRequestType zeroFillVirtualDiskRequestType = new ZeroFillVirtualDiskRequestType();
				zeroFillVirtualDiskRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				zeroFillVirtualDiskRequestType.name = name;
				zeroFillVirtualDiskRequestType.datacenter = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(datacenter);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.ZeroFillVirtualDisk_Task(new ZeroFillVirtualDisk_TaskRequest(zeroFillVirtualDiskRequestType)).ZeroFillVirtualDisk_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void ZeroFillVirtualDisk(string name, ManagedObjectReference datacenter)
		{
			try
			{
				ManagedObjectReference taskReference = this.ZeroFillVirtualDisk_Task(name, datacenter);
				this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void SetVirtualDiskUuid(string name, ManagedObjectReference datacenter, string uuid)
		{
			try
			{
				SetVirtualDiskUuidRequestType setVirtualDiskUuidRequestType = new SetVirtualDiskUuidRequestType();
				setVirtualDiskUuidRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				setVirtualDiskUuidRequestType.name = name;
				setVirtualDiskUuidRequestType.datacenter = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(datacenter);
				setVirtualDiskUuidRequestType.uuid = uuid;
				this.VimServiceProxy.SetVirtualDiskUuid(new SetVirtualDiskUuidRequest(setVirtualDiskUuidRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public string QueryVirtualDiskUuid(string name, ManagedObjectReference datacenter)
		{
			string returnval;
			try
			{
				QueryVirtualDiskUuidRequestType queryVirtualDiskUuidRequestType = new QueryVirtualDiskUuidRequestType();
				queryVirtualDiskUuidRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				queryVirtualDiskUuidRequestType.name = name;
				queryVirtualDiskUuidRequestType.datacenter = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(datacenter);
				returnval = this.VimServiceProxy.QueryVirtualDiskUuid(new QueryVirtualDiskUuidRequest(queryVirtualDiskUuidRequestType)).QueryVirtualDiskUuidResponse.returnval;
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return returnval;
		}
		public HostDiskDimensionsChs QueryVirtualDiskGeometry(string name, ManagedObjectReference datacenter)
		{
			HostDiskDimensionsChs result;
			try
			{
				QueryVirtualDiskGeometryRequestType queryVirtualDiskGeometryRequestType = new QueryVirtualDiskGeometryRequestType();
				queryVirtualDiskGeometryRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				queryVirtualDiskGeometryRequestType.name = name;
				queryVirtualDiskGeometryRequestType.datacenter = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(datacenter);
				result = (HostDiskDimensionsChs)VIConvert.ToVim(this.VimServiceProxy.QueryVirtualDiskGeometry(new QueryVirtualDiskGeometryRequest(queryVirtualDiskGeometryRequestType)).QueryVirtualDiskGeometryResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void ImportUnmanagedSnapshot(string vdisk, ManagedObjectReference datacenter, string vvolId)
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim60);
				ImportUnmanagedSnapshotRequestType importUnmanagedSnapshotRequestType = new ImportUnmanagedSnapshotRequestType();
				importUnmanagedSnapshotRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				importUnmanagedSnapshotRequestType.vdisk = vdisk;
				importUnmanagedSnapshotRequestType.datacenter = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(datacenter);
				importUnmanagedSnapshotRequestType.vvolId = vvolId;
				this.VimServiceProxy.ImportUnmanagedSnapshot(new ImportUnmanagedSnapshotRequest(importUnmanagedSnapshotRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void ReleaseManagedSnapshot(string vdisk, ManagedObjectReference datacenter)
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim65);
				ReleaseManagedSnapshotRequestType releaseManagedSnapshotRequestType = new ReleaseManagedSnapshotRequestType();
				releaseManagedSnapshotRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				releaseManagedSnapshotRequestType.vdisk = vdisk;
				releaseManagedSnapshotRequestType.datacenter = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(datacenter);
				this.VimServiceProxy.ReleaseManagedSnapshot(new ReleaseManagedSnapshotRequest(releaseManagedSnapshotRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
	}
}
