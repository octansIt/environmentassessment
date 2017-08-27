using System.ServiceModel;
using VimApi_65;
namespace EnvironmentAssessment.Common.VimApi
{
	public class HostGraphicsManager : ExtensibleManagedObject
	{
		protected HostGraphicsInfo[] _graphicsInfo;
		protected HostGraphicsConfig _graphicsConfig;
		protected string[] _sharedPassthruGpuTypes;
		public HostGraphicsInfo[] GraphicsInfo
		{
			get
			{
				return this._graphicsInfo;
			}
		}
		public HostGraphicsConfig GraphicsConfig
		{
			get
			{
				return this._graphicsConfig;
			}
		}
		public string[] SharedPassthruGpuTypes
		{
			get
			{
				return this._sharedPassthruGpuTypes;
			}
		}
		public HostGraphicsManager(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public void RefreshGraphicsManager()
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim55);
				RefreshGraphicsManagerRequestType refreshGraphicsManagerRequestType = new RefreshGraphicsManagerRequestType();
				refreshGraphicsManagerRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				this.VimServiceProxy.RefreshGraphicsManager(new RefreshGraphicsManagerRequest(refreshGraphicsManagerRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public bool IsSharedGraphicsActive()
		{
			bool returnval;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim55);
				IsSharedGraphicsActiveRequestType isSharedGraphicsActiveRequestType = new IsSharedGraphicsActiveRequestType();
				isSharedGraphicsActiveRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				returnval = this.VimServiceProxy.IsSharedGraphicsActive(new IsSharedGraphicsActiveRequest(isSharedGraphicsActiveRequestType)).IsSharedGraphicsActiveResponse.returnval;
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return returnval;
		}
		public void UpdateGraphicsConfig(HostGraphicsConfig config)
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim65);
				UpdateGraphicsConfigRequestType updateGraphicsConfigRequestType = new UpdateGraphicsConfigRequestType();
				updateGraphicsConfigRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				updateGraphicsConfigRequestType.config = (VimApi_65.HostGraphicsConfig)VIConvert.ToWsdlType(config);
				this.VimServiceProxy.UpdateGraphicsConfig(new UpdateGraphicsConfigRequest(updateGraphicsConfigRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
	}
}
