using System.ServiceModel;
using VimApi_65;
namespace EnvironmentAssessment.Common.VimApi
{
	public class ProfileManager : ViewBase
	{
		protected ManagedObjectReference[] _profile;
		protected ProfileManager_LinkedView _linkedView;
		public ManagedObjectReference[] Profile
		{
			get
			{
				return this._profile;
			}
		}
		public ProfileManager_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
		public ProfileManager(IVimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public ManagedObjectReference CreateProfile(ProfileCreateSpec createSpec)
		{
			ManagedObjectReference result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				CreateProfileRequestType createProfileRequestType = new CreateProfileRequestType();
				createProfileRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				createProfileRequestType.createSpec = (VimApi_65.ProfileCreateSpec)VIConvert.ToWsdlType(createSpec);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.CreateProfile(new CreateProfileRequest(createProfileRequestType)).CreateProfileResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ProfilePolicyMetadata[] QueryPolicyMetadata(string[] policyName, ManagedObjectReference profile)
		{
			ProfilePolicyMetadata[] result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				QueryPolicyMetadataRequestType queryPolicyMetadataRequestType = new QueryPolicyMetadataRequestType();
				queryPolicyMetadataRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				queryPolicyMetadataRequestType.policyName = policyName;
				queryPolicyMetadataRequestType.profile = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(profile);
				result = (ProfilePolicyMetadata[])VIConvert.ToVim(this.VimServiceProxy.QueryPolicyMetadata(new QueryPolicyMetadataRequest(queryPolicyMetadataRequestType)).QueryPolicyMetadataResponse1);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference[] FindAssociatedProfile(ManagedObjectReference entity)
		{
			ManagedObjectReference[] result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				FindAssociatedProfileRequestType findAssociatedProfileRequestType = new FindAssociatedProfileRequestType();
				findAssociatedProfileRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				findAssociatedProfileRequestType.entity = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(entity);
				result = (ManagedObjectReference[])VIConvert.ToVim(this.VimServiceProxy.FindAssociatedProfile(new FindAssociatedProfileRequest(findAssociatedProfileRequestType)).FindAssociatedProfileResponse1);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
	}
}
