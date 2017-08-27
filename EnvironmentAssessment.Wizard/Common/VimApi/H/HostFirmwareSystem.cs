using System.ServiceModel;
using VimApi_65;
namespace EnvironmentAssessment.Common.VimApi
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
				ResetFirmwareToFactoryDefaultsRequestType resetFirmwareToFactoryDefaultsRequestType = new ResetFirmwareToFactoryDefaultsRequestType();
				resetFirmwareToFactoryDefaultsRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				this.VimServiceProxy.ResetFirmwareToFactoryDefaults(new ResetFirmwareToFactoryDefaultsRequest(resetFirmwareToFactoryDefaultsRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public string BackupFirmwareConfiguration()
		{
			string returnval;
			try
			{
				BackupFirmwareConfigurationRequestType backupFirmwareConfigurationRequestType = new BackupFirmwareConfigurationRequestType();
				backupFirmwareConfigurationRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				returnval = this.VimServiceProxy.BackupFirmwareConfiguration(new BackupFirmwareConfigurationRequest(backupFirmwareConfigurationRequestType)).BackupFirmwareConfigurationResponse.returnval;
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return returnval;
		}
		public string QueryFirmwareConfigUploadURL()
		{
			string returnval;
			try
			{
				QueryFirmwareConfigUploadURLRequestType queryFirmwareConfigUploadURLRequestType = new QueryFirmwareConfigUploadURLRequestType();
				queryFirmwareConfigUploadURLRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				returnval = this.VimServiceProxy.QueryFirmwareConfigUploadURL(new QueryFirmwareConfigUploadURLRequest(queryFirmwareConfigUploadURLRequestType)).QueryFirmwareConfigUploadURLResponse.returnval;
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return returnval;
		}
		public void RestoreFirmwareConfiguration(bool force)
		{
			try
			{
				RestoreFirmwareConfigurationRequestType restoreFirmwareConfigurationRequestType = new RestoreFirmwareConfigurationRequestType();
				restoreFirmwareConfigurationRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				restoreFirmwareConfigurationRequestType.force = force;
				this.VimServiceProxy.RestoreFirmwareConfiguration(new RestoreFirmwareConfigurationRequest(restoreFirmwareConfigurationRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
	}
}
