using System;
using System.Web.Services.Protocols;
using VimApi_60;
namespace EnvironmentAssessment.Common.VISoap
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
				result = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).CreateVirtualDisk_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), name, (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(datacenter), (VimApi_60.VirtualDiskSpec)VIConvert.ToWsdlType(spec)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public string CreateVirtualDisk(string name, ManagedObjectReference datacenter, VirtualDiskSpec spec)
		{
			string result;
			try
			{
				ManagedObjectReference taskReference = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).CreateVirtualDisk_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), name, (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(datacenter), (VimApi_60.VirtualDiskSpec)VIConvert.ToWsdlType(spec)));
				result = (string)this.Client.WaitForTask(taskReference);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public ManagedObjectReference DeleteVirtualDisk_Task(string name, ManagedObjectReference datacenter)
		{
			ManagedObjectReference result;
			try
			{
				result = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).DeleteVirtualDisk_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), name, (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(datacenter)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public void DeleteVirtualDisk(string name, ManagedObjectReference datacenter)
		{
			try
			{
				ManagedObjectReference taskReference = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).DeleteVirtualDisk_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), name, (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(datacenter)));
				this.Client.WaitForTask(taskReference);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public ManagedObjectReference MoveVirtualDisk_Task(string sourceName, ManagedObjectReference sourceDatacenter, string destName, ManagedObjectReference destDatacenter, bool? force, VirtualMachineProfileSpec[] profile)
		{
			ManagedObjectReference result;
			try
			{
				result = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).MoveVirtualDisk_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), sourceName, (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(sourceDatacenter), destName, (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(destDatacenter), force.GetValueOrDefault(), force.HasValue, (VimApi_60.VirtualMachineProfileSpec[])VIConvert.ToWsdlType(profile)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
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
		public string MoveVirtualDisk(string sourceName, ManagedObjectReference sourceDatacenter, string destName, ManagedObjectReference destDatacenter, bool? force, VirtualMachineProfileSpec[] profile)
		{
			string result;
			try
			{
				ManagedObjectReference taskReference = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).MoveVirtualDisk_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), sourceName, (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(sourceDatacenter), destName, (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(destDatacenter), force.GetValueOrDefault(), force.HasValue, (VimApi_60.VirtualMachineProfileSpec[])VIConvert.ToWsdlType(profile)));
				result = (string)this.Client.WaitForTask(taskReference);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public ManagedObjectReference CopyVirtualDisk_Task(string sourceName, ManagedObjectReference sourceDatacenter, string destName, ManagedObjectReference destDatacenter, VirtualDiskSpec destSpec, bool? force)
		{
			ManagedObjectReference result;
			try
			{
				result = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).CopyVirtualDisk_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), sourceName, (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(sourceDatacenter), destName, (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(destDatacenter), (VimApi_60.VirtualDiskSpec)VIConvert.ToWsdlType(destSpec), force.GetValueOrDefault(), force.HasValue));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public string CopyVirtualDisk(string sourceName, ManagedObjectReference sourceDatacenter, string destName, ManagedObjectReference destDatacenter, VirtualDiskSpec destSpec, bool? force)
		{
			string result;
			try
			{
				ManagedObjectReference taskReference = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).CopyVirtualDisk_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), sourceName, (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(sourceDatacenter), destName, (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(destDatacenter), (VimApi_60.VirtualDiskSpec)VIConvert.ToWsdlType(destSpec), force.GetValueOrDefault(), force.HasValue));
				result = (string)this.Client.WaitForTask(taskReference);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public ManagedObjectReference ExtendVirtualDisk_Task(string name, ManagedObjectReference datacenter, long newCapacityKb, bool? eagerZero)
		{
			ManagedObjectReference result;
			try
			{
				result = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).ExtendVirtualDisk_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), name, (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(datacenter), newCapacityKb, eagerZero.GetValueOrDefault(), eagerZero.HasValue));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public void ExtendVirtualDisk(string name, ManagedObjectReference datacenter, long newCapacityKb, bool? eagerZero)
		{
			try
			{
				ManagedObjectReference taskReference = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).ExtendVirtualDisk_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), name, (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(datacenter), newCapacityKb, eagerZero.GetValueOrDefault(), eagerZero.HasValue));
				this.Client.WaitForTask(taskReference);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public int QueryVirtualDiskFragmentation(string name, ManagedObjectReference datacenter)
		{
			int result;
			try
			{
				result = ((VimService)this.Client.VimService).QueryVirtualDiskFragmentation((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), name, (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(datacenter));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public ManagedObjectReference DefragmentVirtualDisk_Task(string name, ManagedObjectReference datacenter)
		{
			ManagedObjectReference result;
			try
			{
				result = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).DefragmentVirtualDisk_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), name, (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(datacenter)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public void DefragmentVirtualDisk(string name, ManagedObjectReference datacenter)
		{
			try
			{
				ManagedObjectReference taskReference = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).DefragmentVirtualDisk_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), name, (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(datacenter)));
				this.Client.WaitForTask(taskReference);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public ManagedObjectReference ShrinkVirtualDisk_Task(string name, ManagedObjectReference datacenter, bool? copy)
		{
			ManagedObjectReference result;
			try
			{
				result = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).ShrinkVirtualDisk_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), name, (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(datacenter), copy.GetValueOrDefault(), copy.HasValue));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public void ShrinkVirtualDisk(string name, ManagedObjectReference datacenter, bool? copy)
		{
			try
			{
				ManagedObjectReference taskReference = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).ShrinkVirtualDisk_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), name, (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(datacenter), copy.GetValueOrDefault(), copy.HasValue));
				this.Client.WaitForTask(taskReference);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public ManagedObjectReference InflateVirtualDisk_Task(string name, ManagedObjectReference datacenter)
		{
			ManagedObjectReference result;
			try
			{
				result = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).InflateVirtualDisk_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), name, (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(datacenter)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public void InflateVirtualDisk(string name, ManagedObjectReference datacenter)
		{
			try
			{
				ManagedObjectReference taskReference = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).InflateVirtualDisk_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), name, (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(datacenter)));
				this.Client.WaitForTask(taskReference);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public ManagedObjectReference EagerZeroVirtualDisk_Task(string name, ManagedObjectReference datacenter)
		{
			ManagedObjectReference result;
			try
			{
				if (this.Client.Version == VimVersion.Vim25)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				result = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).EagerZeroVirtualDisk_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), name, (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(datacenter)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public void EagerZeroVirtualDisk(string name, ManagedObjectReference datacenter)
		{
			try
			{
				if (this.Client.Version == VimVersion.Vim25)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				ManagedObjectReference taskReference = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).EagerZeroVirtualDisk_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), name, (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(datacenter)));
				this.Client.WaitForTask(taskReference);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public ManagedObjectReference ZeroFillVirtualDisk_Task(string name, ManagedObjectReference datacenter)
		{
			ManagedObjectReference result;
			try
			{
				result = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).ZeroFillVirtualDisk_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), name, (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(datacenter)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public void ZeroFillVirtualDisk(string name, ManagedObjectReference datacenter)
		{
			try
			{
				ManagedObjectReference taskReference = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).ZeroFillVirtualDisk_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), name, (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(datacenter)));
				this.Client.WaitForTask(taskReference);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public void SetVirtualDiskUuid(string name, ManagedObjectReference datacenter, string uuid)
		{
			try
			{
				((VimService)this.Client.VimService).SetVirtualDiskUuid((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), name, (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(datacenter), uuid);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public string QueryVirtualDiskUuid(string name, ManagedObjectReference datacenter)
		{
			string result;
			try
			{
				result = ((VimService)this.Client.VimService).QueryVirtualDiskUuid((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), name, (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(datacenter));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public HostDiskDimensionsChs QueryVirtualDiskGeometry(string name, ManagedObjectReference datacenter)
		{
			HostDiskDimensionsChs result;
			try
			{
				result = (HostDiskDimensionsChs)VIConvert.ToVim(((VimService)this.Client.VimService).QueryVirtualDiskGeometry((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), name, (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(datacenter)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
	}
}
