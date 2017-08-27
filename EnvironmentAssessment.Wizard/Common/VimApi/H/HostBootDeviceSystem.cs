using System.ServiceModel;
using VimApi_65;
namespace EnvironmentAssessment.Common.VimApi
{
	public class HostBootDeviceSystem : ViewBase
	{
		public HostBootDeviceSystem(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public HostBootDeviceInfo QueryBootDevices()
		{
			HostBootDeviceInfo result;
			try
			{
				QueryBootDevicesRequestType queryBootDevicesRequestType = new QueryBootDevicesRequestType();
				queryBootDevicesRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				result = (HostBootDeviceInfo)VIConvert.ToVim(this.VimServiceProxy.QueryBootDevices(new QueryBootDevicesRequest(queryBootDevicesRequestType)).QueryBootDevicesResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void UpdateBootDevice(string key)
		{
			try
			{
				UpdateBootDeviceRequestType updateBootDeviceRequestType = new UpdateBootDeviceRequestType();
				updateBootDeviceRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				updateBootDeviceRequestType.key = key;
				this.VimServiceProxy.UpdateBootDevice(new UpdateBootDeviceRequest(updateBootDeviceRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
	}
}
