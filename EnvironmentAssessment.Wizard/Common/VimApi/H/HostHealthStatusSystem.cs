using System.ServiceModel;
using VimApi_65;
namespace EnvironmentAssessment.Common.VimApi
{
	public class HostHealthStatusSystem : ViewBase
	{
		protected HealthSystemRuntime _runtime;
		public HealthSystemRuntime Runtime
		{
			get
			{
				return this._runtime;
			}
		}
		public HostHealthStatusSystem(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public void RefreshHealthStatusSystem()
		{
			try
			{
				RefreshHealthStatusSystemRequestType refreshHealthStatusSystemRequestType = new RefreshHealthStatusSystemRequestType();
				refreshHealthStatusSystemRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				this.VimServiceProxy.RefreshHealthStatusSystem(new RefreshHealthStatusSystemRequest(refreshHealthStatusSystemRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void ResetSystemHealthInfo()
		{
			try
			{
				ResetSystemHealthInfoRequestType resetSystemHealthInfoRequestType = new ResetSystemHealthInfoRequestType();
				resetSystemHealthInfoRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				this.VimServiceProxy.ResetSystemHealthInfo(new ResetSystemHealthInfoRequest(resetSystemHealthInfoRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void ClearSystemEventLog()
		{
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim65);
				ClearSystemEventLogRequestType clearSystemEventLogRequestType = new ClearSystemEventLogRequestType();
				clearSystemEventLogRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				this.VimServiceProxy.ClearSystemEventLog(new ClearSystemEventLogRequest(clearSystemEventLogRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public SystemEventInfo[] FetchSystemEventLog()
		{
			SystemEventInfo[] result;
			try
			{
                VersionUtils.RequiresVersion(this.Client,VimVersion.Vim65);
				FetchSystemEventLogRequestType fetchSystemEventLogRequestType = new FetchSystemEventLogRequestType();
				fetchSystemEventLogRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				result = (SystemEventInfo[])VIConvert.ToVim(this.VimServiceProxy.FetchSystemEventLog(new FetchSystemEventLogRequest(fetchSystemEventLogRequestType)).FetchSystemEventLogResponse1);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
	}
}
