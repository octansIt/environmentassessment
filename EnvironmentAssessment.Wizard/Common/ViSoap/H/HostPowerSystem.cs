using System;
using System.Web.Services.Protocols;
using VimApi_60;
namespace EnvironmentAssessment.Common.VISoap
{
	public class HostPowerSystem : ViewBase
	{
		protected PowerSystemCapability _capability;
		protected PowerSystemInfo _info;
		public PowerSystemCapability Capability
		{
			get
			{
				return this._capability;
			}
		}
		public PowerSystemInfo Info
		{
			get
			{
				return this._info;
			}
		}
		public HostPowerSystem(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public void ConfigurePowerPolicy(int key)
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
				((VimService)this.Client.VimService).ConfigurePowerPolicy((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), key);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
	}
}
