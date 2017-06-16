using System;
using System.Web.Services.Protocols;
using VimApi_60;
namespace EnvironmentAssessment.Common.VISoap
{
	public class VmwareDistributedVirtualSwitch : DistributedVirtualSwitch
	{
		public new VmwareDistributedVirtualSwitch_LinkedView LinkedView
		{
			get
			{
				return (VmwareDistributedVirtualSwitch_LinkedView)this._linkedView;
			}
		}
		public VmwareDistributedVirtualSwitch(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public ManagedObjectReference UpdateDVSLacpGroupConfig_Task(VMwareDvsLacpGroupSpec[] lacpGroupSpec)
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
				result = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).UpdateDVSLacpGroupConfig_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.VMwareDvsLacpGroupSpec[])VIConvert.ToWsdlType(lacpGroupSpec)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public void UpdateDVSLacpGroupConfig(VMwareDvsLacpGroupSpec[] lacpGroupSpec)
		{
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
				ManagedObjectReference taskReference = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).UpdateDVSLacpGroupConfig_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.VMwareDvsLacpGroupSpec[])VIConvert.ToWsdlType(lacpGroupSpec)));
				this.Client.WaitForTask(taskReference);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
	}
}
