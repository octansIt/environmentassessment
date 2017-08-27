using System.ServiceModel;
using VimApi_65;
namespace EnvironmentAssessment.Common.VimApi
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
				UpdateIpConfigRequestType updateIpConfigRequestType = new UpdateIpConfigRequestType();
				updateIpConfigRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				updateIpConfigRequestType.ipConfig = (VimApi_65.HostIpConfig)VIConvert.ToWsdlType(ipConfig);
				this.VimServiceProxy.UpdateIpConfig(new UpdateIpConfigRequest(updateIpConfigRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void SelectVnic(string device)
		{
			try
			{
				SelectVnicRequestType selectVnicRequestType = new SelectVnicRequestType();
				selectVnicRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				selectVnicRequestType.device = device;
				this.VimServiceProxy.SelectVnic(new SelectVnicRequest(selectVnicRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void DeselectVnic()
		{
			try
			{
				DeselectVnicRequestType deselectVnicRequestType = new DeselectVnicRequestType();
				deselectVnicRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				this.VimServiceProxy.DeselectVnic(new DeselectVnicRequest(deselectVnicRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
	}
}
