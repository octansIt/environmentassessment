using System.Web.Services.Protocols;
using VimApi_60;
namespace EnvironmentAssessment.Common.VISoap
{
    public class HostFirmwareSystem : ViewBase
	{
		public HostFirmwareSystem(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public void ResetFirmwareToFactoryDefaults()
		{
			try
			{
				((VimService)this.Client.VimService).ResetFirmwareToFactoryDefaults((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public string BackupFirmwareConfiguration()
		{
			string result;
			try
			{
				result = ((VimService)this.Client.VimService).BackupFirmwareConfiguration((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public string QueryFirmwareConfigUploadURL()
		{
			string result;
			try
			{
				result = ((VimService)this.Client.VimService).QueryFirmwareConfigUploadURL((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public void RestoreFirmwareConfiguration(bool force)
		{
			try
			{
				((VimService)this.Client.VimService).RestoreFirmwareConfiguration((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), force);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
	}
}
