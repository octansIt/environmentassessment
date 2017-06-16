using System;
using System.Web.Services.Protocols;
using VimApi_60;
namespace EnvironmentAssessment.Common.VISoap
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
		public ProfileManager(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public ManagedObjectReference CreateProfile(ProfileCreateSpec createSpec)
		{
			ManagedObjectReference result;
			try
			{
				if (this.Client.Version == VimVersion.Vim25)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				result = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).CreateProfile((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.ProfileCreateSpec)VIConvert.ToWsdlType(createSpec)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public ProfilePolicyMetadata[] QueryPolicyMetadata(string[] policyName, ManagedObjectReference profile)
		{
			ProfilePolicyMetadata[] result;
			try
			{
				if (this.Client.Version == VimVersion.Vim25)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				result = (ProfilePolicyMetadata[])VIConvert.ToVim(((VimService)this.Client.VimService).QueryPolicyMetadata((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), policyName, (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(profile)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public ManagedObjectReference[] FindAssociatedProfile(ManagedObjectReference entity)
		{
			ManagedObjectReference[] result;
			try
			{
				if (this.Client.Version == VimVersion.Vim25)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				result = (ManagedObjectReference[])VIConvert.ToVim(((VimService)this.Client.VimService).FindAssociatedProfile((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(entity)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
	}
}
