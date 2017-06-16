using System.Web.Services.Protocols;
using VimApi_60;
namespace EnvironmentAssessment.Common.VISoap
{
    public class HostServiceSystem : ExtensibleManagedObject
	{
		protected HostServiceInfo _serviceInfo;
		public HostServiceInfo ServiceInfo
		{
			get
			{
				return this._serviceInfo;
			}
		}
		public HostServiceSystem(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public void UpdateServicePolicy(string id, string policy)
		{
			try
			{
				((VimService)this.Client.VimService).UpdateServicePolicy((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), id, policy);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public void StartService(string id)
		{
			try
			{
				((VimService)this.Client.VimService).StartService((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), id);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public void StopService(string id)
		{
			try
			{
				((VimService)this.Client.VimService).StopService((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), id);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public void RestartService(string id)
		{
			try
			{
				((VimService)this.Client.VimService).RestartService((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), id);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public void UninstallService(string id)
		{
			try
			{
				((VimService)this.Client.VimService).UninstallService((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), id);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public void RefreshServices()
		{
			try
			{
				((VimService)this.Client.VimService).RefreshServices((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
	}
}
