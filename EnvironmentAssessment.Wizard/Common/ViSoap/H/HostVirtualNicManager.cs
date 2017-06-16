using System;
using System.Web.Services.Protocols;
using VimApi_60;
namespace EnvironmentAssessment.Common.VISoap
{
	public class HostVirtualNicManager : ExtensibleManagedObject
	{
		protected HostVirtualNicManagerInfo _info;
		public HostVirtualNicManagerInfo Info
		{
			get
			{
				return this._info;
			}
		}
		public HostVirtualNicManager(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public VirtualNicManagerNetConfig QueryNetConfig(string nicType)
		{
			VirtualNicManagerNetConfig result;
			try
			{
				if (this.Client.Version == VimVersion.Vim25)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				result = (VirtualNicManagerNetConfig)VIConvert.ToVim(((VimService)this.Client.VimService).QueryNetConfig((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), nicType));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public void SelectVnicForNicType(string nicType, string device)
		{
			try
			{
				if (this.Client.Version == VimVersion.Vim25)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				((VimService)this.Client.VimService).SelectVnicForNicType((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), nicType, device);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public void DeselectVnicForNicType(string nicType, string device)
		{
			try
			{
				if (this.Client.Version == VimVersion.Vim25)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				((VimService)this.Client.VimService).DeselectVnicForNicType((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), nicType, device);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
	}
}
