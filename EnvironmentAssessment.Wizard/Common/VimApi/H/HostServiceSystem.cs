using System.ServiceModel;
using VimApi_65;
namespace EnvironmentAssessment.Common.VimApi
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
				UpdateServicePolicyRequestType updateServicePolicyRequestType = new UpdateServicePolicyRequestType();
				updateServicePolicyRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				updateServicePolicyRequestType.id = id;
				updateServicePolicyRequestType.policy = policy;
				this.VimServiceProxy.UpdateServicePolicy(new UpdateServicePolicyRequest(updateServicePolicyRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void StartService(string id)
		{
			try
			{
				StartServiceRequestType startServiceRequestType = new StartServiceRequestType();
				startServiceRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				startServiceRequestType.id = id;
				this.VimServiceProxy.StartService(new StartServiceRequest(startServiceRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void StopService(string id)
		{
			try
			{
				StopServiceRequestType stopServiceRequestType = new StopServiceRequestType();
				stopServiceRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				stopServiceRequestType.id = id;
				this.VimServiceProxy.StopService(new StopServiceRequest(stopServiceRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void RestartService(string id)
		{
			try
			{
				RestartServiceRequestType restartServiceRequestType = new RestartServiceRequestType();
				restartServiceRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				restartServiceRequestType.id = id;
				this.VimServiceProxy.RestartService(new RestartServiceRequest(restartServiceRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void UninstallService(string id)
		{
			try
			{
				UninstallServiceRequestType uninstallServiceRequestType = new UninstallServiceRequestType();
				uninstallServiceRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				uninstallServiceRequestType.id = id;
				this.VimServiceProxy.UninstallService(new UninstallServiceRequest(uninstallServiceRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void RefreshServices()
		{
			try
			{
				RefreshServicesRequestType refreshServicesRequestType = new RefreshServicesRequestType();
				refreshServicesRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				this.VimServiceProxy.RefreshServices(new RefreshServicesRequest(refreshServicesRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
	}
}
