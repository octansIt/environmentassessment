using System;
using System.Web.Services.Protocols;
using VimApi_60;
namespace EnvironmentAssessment.Common.VISoap
{
	public class HostPciPassthruSystem : ExtensibleManagedObject
	{
		protected HostPciPassthruInfo[] _pciPassthruInfo;
		public HostPciPassthruInfo[] PciPassthruInfo
		{
			get
			{
				return this._pciPassthruInfo;
			}
		}
		public HostPciPassthruSystem(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public void Refresh()
		{
			try
			{
				if (this.Client.Version == VimVersion.Vim25)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				((VimService)this.Client.VimService).Refresh((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public void UpdatePassthruConfig(HostPciPassthruConfig[] config)
		{
			try
			{
				if (this.Client.Version == VimVersion.Vim25)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				((VimService)this.Client.VimService).UpdatePassthruConfig((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.HostPciPassthruConfig[])VIConvert.ToWsdlType(config));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
	}
}
