using System.ServiceModel;
using VimApi_65;
namespace EnvironmentAssessment.Common.VimApi
{
	public class GuestAuthManager : ViewBase
	{
		public GuestAuthManager(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public void ValidateCredentialsInGuest(ManagedObjectReference vm, GuestAuthentication auth)
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim50);
				ValidateCredentialsInGuestRequestType validateCredentialsInGuestRequestType = new ValidateCredentialsInGuestRequestType();
				validateCredentialsInGuestRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				validateCredentialsInGuestRequestType.vm = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(vm);
				validateCredentialsInGuestRequestType.auth = (VimApi_65.GuestAuthentication)VIConvert.ToWsdlType(auth);
				this.VimServiceProxy.ValidateCredentialsInGuest(new ValidateCredentialsInGuestRequest(validateCredentialsInGuestRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public GuestAuthentication AcquireCredentialsInGuest(ManagedObjectReference vm, GuestAuthentication requestedAuth, long? sessionID)
		{
			GuestAuthentication result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim50);
				AcquireCredentialsInGuestRequestType acquireCredentialsInGuestRequestType = new AcquireCredentialsInGuestRequestType();
				acquireCredentialsInGuestRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				acquireCredentialsInGuestRequestType.vm = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(vm);
				acquireCredentialsInGuestRequestType.requestedAuth = (VimApi_65.GuestAuthentication)VIConvert.ToWsdlType(requestedAuth);
				acquireCredentialsInGuestRequestType.sessionID = sessionID.GetValueOrDefault();
				acquireCredentialsInGuestRequestType.sessionIDSpecified = sessionID.HasValue;
				result = (GuestAuthentication)VIConvert.ToVim(this.VimServiceProxy.AcquireCredentialsInGuest(new AcquireCredentialsInGuestRequest(acquireCredentialsInGuestRequestType)).AcquireCredentialsInGuestResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void ReleaseCredentialsInGuest(ManagedObjectReference vm, GuestAuthentication auth)
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim50);
				ReleaseCredentialsInGuestRequestType releaseCredentialsInGuestRequestType = new ReleaseCredentialsInGuestRequestType();
				releaseCredentialsInGuestRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				releaseCredentialsInGuestRequestType.vm = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(vm);
				releaseCredentialsInGuestRequestType.auth = (VimApi_65.GuestAuthentication)VIConvert.ToWsdlType(auth);
				this.VimServiceProxy.ReleaseCredentialsInGuest(new ReleaseCredentialsInGuestRequest(releaseCredentialsInGuestRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
	}
}
