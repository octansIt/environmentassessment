using System.ServiceModel;
using VimApi_65;
namespace EnvironmentAssessment.Common.VimApi
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
				UpdateDefaultPolicyRequestType updateDefaultPolicyRequestType = new UpdateDefaultPolicyRequestType();
				updateDefaultPolicyRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				updateDefaultPolicyRequestType.defaultPolicy = (VimApi_65.HostFirewallDefaultPolicy)VIConvert.ToWsdlType(defaultPolicy);
				this.VimServiceProxy.UpdateDefaultPolicy(new UpdateDefaultPolicyRequest(updateDefaultPolicyRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void EnableRuleset(string id)
		{
			try
			{
				EnableRulesetRequestType enableRulesetRequestType = new EnableRulesetRequestType();
				enableRulesetRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				enableRulesetRequestType.id = id;
				this.VimServiceProxy.EnableRuleset(new EnableRulesetRequest(enableRulesetRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void DisableRuleset(string id)
		{
			try
			{
				DisableRulesetRequestType disableRulesetRequestType = new DisableRulesetRequestType();
				disableRulesetRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				disableRulesetRequestType.id = id;
				this.VimServiceProxy.DisableRuleset(new DisableRulesetRequest(disableRulesetRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void UpdateRuleset(string id, HostFirewallRulesetRulesetSpec spec)
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim50);
				UpdateRulesetRequestType updateRulesetRequestType = new UpdateRulesetRequestType();
				updateRulesetRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				updateRulesetRequestType.id = id;
				updateRulesetRequestType.spec = (VimApi_65.HostFirewallRulesetRulesetSpec)VIConvert.ToWsdlType(spec);
				this.VimServiceProxy.UpdateRuleset(new UpdateRulesetRequest(updateRulesetRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void RefreshFirewall()
		{
			try
			{
				RefreshFirewallRequestType refreshFirewallRequestType = new RefreshFirewallRequestType();
				refreshFirewallRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				this.VimServiceProxy.RefreshFirewall(new RefreshFirewallRequest(refreshFirewallRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
	}
}
