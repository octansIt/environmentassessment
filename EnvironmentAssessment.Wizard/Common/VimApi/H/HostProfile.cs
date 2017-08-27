using System.ServiceModel;
using VimApi_65;
namespace EnvironmentAssessment.Common.VimApi
{
	public class HostProfile : Profile
	{
		protected ManagedObjectReference _referenceHost;
		public ManagedObjectReference ReferenceHost
		{
			get
			{
				return this._referenceHost;
			}
		}
		public new HostProfile_LinkedView LinkedView
		{
			get
			{
				return (HostProfile_LinkedView)this._linkedView;
			}
		}
		public HostProfile(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public void UpdateReferenceHost(ManagedObjectReference host)
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				UpdateReferenceHostRequestType updateReferenceHostRequestType = new UpdateReferenceHostRequestType();
				updateReferenceHostRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				updateReferenceHostRequestType.host = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(host);
				this.VimServiceProxy.UpdateReferenceHost(new UpdateReferenceHostRequest(updateReferenceHostRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void UpdateHostProfile(HostProfileConfigSpec config)
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				UpdateHostProfileRequestType updateHostProfileRequestType = new UpdateHostProfileRequestType();
				updateHostProfileRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				updateHostProfileRequestType.config = (VimApi_65.HostProfileConfigSpec)VIConvert.ToWsdlType(config);
				this.VimServiceProxy.UpdateHostProfile(new UpdateHostProfileRequest(updateHostProfileRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public ProfileExecuteResult ExecuteHostProfile(ManagedObjectReference host, ProfileDeferredPolicyOptionParameter[] deferredParam)
		{
			ProfileExecuteResult result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				ExecuteHostProfileRequestType executeHostProfileRequestType = new ExecuteHostProfileRequestType();
				executeHostProfileRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				executeHostProfileRequestType.host = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(host);
				executeHostProfileRequestType.deferredParam = (VimApi_65.ProfileDeferredPolicyOptionParameter[])VIConvert.ToWsdlType(deferredParam);
				result = (ProfileExecuteResult)VIConvert.ToVim(this.VimServiceProxy.ExecuteHostProfile(new ExecuteHostProfileRequest(executeHostProfileRequestType)).ExecuteHostProfileResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
	}
}
