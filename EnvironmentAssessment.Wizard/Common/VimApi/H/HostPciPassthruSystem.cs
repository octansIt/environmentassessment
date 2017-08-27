using System.ServiceModel;
using VimApi_65;
namespace EnvironmentAssessment.Common.VimApi
{
	public class HostPciPassthruSystem : ExtensibleManagedObject
	{
		protected HostPciPassthruInfo[] _pciPassthruInfo;
		protected HostSriovDevicePoolInfo[] _sriovDevicePoolInfo;
		public HostPciPassthruInfo[] PciPassthruInfo
		{
			get
			{
				return this._pciPassthruInfo;
			}
		}
		public HostSriovDevicePoolInfo[] SriovDevicePoolInfo
		{
			get
			{
				return this._sriovDevicePoolInfo;
			}
		}
		public HostPciPassthruSystem(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public void Refresh()
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				RefreshRequestType refreshRequestType = new RefreshRequestType();
				refreshRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				this.VimServiceProxy.Refresh(new RefreshRequest(refreshRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void UpdatePassthruConfig(HostPciPassthruConfig[] config)
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				UpdatePassthruConfigRequestType updatePassthruConfigRequestType = new UpdatePassthruConfigRequestType();
				updatePassthruConfigRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				updatePassthruConfigRequestType.config = (VimApi_65.HostPciPassthruConfig[])VIConvert.ToWsdlType(config);
				this.VimServiceProxy.UpdatePassthruConfig(new UpdatePassthruConfigRequest(updatePassthruConfigRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
	}
}
