using System;
using System.Web.Services.Protocols;
using VimApi_60;
namespace EnvironmentAssessment.Common.VISoap
{
	public class VirtualMachineSnapshot : ExtensibleManagedObject
	{
		protected VirtualMachineConfigInfo _config;
		protected ManagedObjectReference[] _childSnapshot;
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
				result = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).RevertToSnapshot_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(host), suppressPowerOn.GetValueOrDefault(), suppressPowerOn.HasValue));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public void RevertToSnapshot(ManagedObjectReference host, bool? suppressPowerOn)
		{
			try
			{
				ManagedObjectReference taskReference = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).RevertToSnapshot_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(host), suppressPowerOn.GetValueOrDefault(), suppressPowerOn.HasValue));
				this.Client.WaitForTask(taskReference);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public ManagedObjectReference RemoveSnapshot_Task(bool removeChildren, bool? consolidate)
		{
			ManagedObjectReference result;
			try
			{
				result = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).RemoveSnapshot_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), removeChildren, consolidate.GetValueOrDefault(), consolidate.HasValue));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public void RemoveSnapshot(bool removeChildren, bool? consolidate)
		{
			try
			{
				ManagedObjectReference taskReference = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).RemoveSnapshot_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), removeChildren, consolidate.GetValueOrDefault(), consolidate.HasValue));
				this.Client.WaitForTask(taskReference);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public void RenameSnapshot(string name, string description)
		{
			try
			{
				((VimService)this.Client.VimService).RenameSnapshot((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), name, description);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public ManagedObjectReference ExportSnapshot()
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
				result = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).ExportSnapshot((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
	}
}
