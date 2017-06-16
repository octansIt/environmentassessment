using System.Web.Services.Protocols;
using VimApi_60;
namespace EnvironmentAssessment.Common.VISoap
{
    public class HostVMotionSystem : ExtensibleManagedObject
	{
		protected HostVMotionNetConfig _netConfig;
		protected HostIpConfig _ipConfig;
		public HostVMotionNetConfig NetConfig
		{
			get
			{
				return this._netConfig;
			}
		}
		public HostIpConfig IpConfig
		{
			get
			{
				return this._ipConfig;
			}
		}
		public HostVMotionSystem(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public void UpdateIpConfig(HostIpConfig ipConfig)
		{
			try
			{
				((VimService)this.Client.VimService).UpdateIpConfig((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.HostIpConfig)VIConvert.ToWsdlType(ipConfig));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public void SelectVnic(string device)
		{
			try
			{
				((VimService)this.Client.VimService).SelectVnic((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), device);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public void DeselectVnic()
		{
			try
			{
				((VimService)this.Client.VimService).DeselectVnic((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
	}
}
