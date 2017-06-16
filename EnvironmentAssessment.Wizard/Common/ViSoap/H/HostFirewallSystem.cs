using System;
using System.Web.Services.Protocols;
using VimApi_60;
namespace EnvironmentAssessment.Common.VISoap
{
	public class HostFirewallSystem : ExtensibleManagedObject
	{
		protected HostFirewallInfo _firewallInfo;
		public HostFirewallInfo FirewallInfo
		{
			get
			{
				return this._firewallInfo;
			}
		}
		public HostFirewallSystem(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public void UpdateDefaultPolicy(HostFirewallDefaultPolicy defaultPolicy)
		{
			try
			{
				((VimService)this.Client.VimService).UpdateDefaultPolicy((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.HostFirewallDefaultPolicy)VIConvert.ToWsdlType(defaultPolicy));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public void EnableRuleset(string id)
		{
			try
			{
				((VimService)this.Client.VimService).EnableRuleset((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), id);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public void DisableRuleset(string id)
		{
			try
			{
				((VimService)this.Client.VimService).DisableRuleset((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), id);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public void UpdateRuleset(string id, HostFirewallRulesetRulesetSpec spec)
		{
			try
			{
				if (this.Client.Version == VimVersion.Vim25)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				if (this.Client.Version == VimVersion.Vim4)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				if (this.Client.Version == VimVersion.Vim41)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				((VimService)this.Client.VimService).UpdateRuleset((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), id, (VimApi_60.HostFirewallRulesetRulesetSpec)VIConvert.ToWsdlType(spec));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public void RefreshFirewall()
		{
			try
			{
				((VimService)this.Client.VimService).RefreshFirewall((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
	}
}
