using System;
using System.Web.Services.Protocols;
using VimApi_60;
namespace EnvironmentAssessment.Common.VISoap
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
				if (this.Client.Version == VimVersion.Vim25)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				((VimService)this.Client.VimService).UpdateReferenceHost((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(host));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public void UpdateHostProfile(HostProfileConfigSpec config)
		{
			try
			{
				if (this.Client.Version == VimVersion.Vim25)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				((VimService)this.Client.VimService).UpdateHostProfile((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.HostProfileConfigSpec)VIConvert.ToWsdlType(config));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public ProfileExecuteResult ExecuteHostProfile(ManagedObjectReference host, ProfileDeferredPolicyOptionParameter[] deferredParam)
		{
			ProfileExecuteResult result;
			try
			{
				if (this.Client.Version == VimVersion.Vim25)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				result = (ProfileExecuteResult)VIConvert.ToVim(((VimService)this.Client.VimService).ExecuteHostProfile((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(host), (VimApi_60.ProfileDeferredPolicyOptionParameter[])VIConvert.ToWsdlType(deferredParam)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
	}
}
