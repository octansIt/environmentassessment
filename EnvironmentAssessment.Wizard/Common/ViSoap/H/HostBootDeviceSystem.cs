using System.Web.Services.Protocols;
using VimApi_60;
namespace EnvironmentAssessment.Common.VISoap
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
				result = (HostBootDeviceInfo)VIConvert.ToVim(((VimService)this.Client.VimService).QueryBootDevices((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public void UpdateBootDevice(string key)
		{
			try
			{
				((VimService)this.Client.VimService).UpdateBootDevice((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), key);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
	}
}
