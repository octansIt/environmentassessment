using System.ServiceModel;
using VimApi_65;
namespace EnvironmentAssessment.Common.VimApi
{
	public class HostPowerSystem : ViewBase
	{
		protected PowerSystemCapability _capability;
		protected PowerSystemInfo _info;
		public PowerSystemCapability Capability
		{
			get
			{
				return this._capability;
			}
		}
		public PowerSystemInfo Info
		{
			get
			{
				return this._info;
			}
		}
		public HostPowerSystem(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public void ConfigurePowerPolicy(int key)
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim41);
				ConfigurePowerPolicyRequestType configurePowerPolicyRequestType = new ConfigurePowerPolicyRequestType();
				configurePowerPolicyRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				configurePowerPolicyRequestType.key = key;
				this.VimServiceProxy.ConfigurePowerPolicy(new ConfigurePowerPolicyRequest(configurePowerPolicyRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
	}
}
