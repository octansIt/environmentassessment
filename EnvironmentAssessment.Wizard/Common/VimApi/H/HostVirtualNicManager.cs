using System.ServiceModel;
using VimApi_65;
namespace EnvironmentAssessment.Common.VimApi
{
	public class HostVirtualNicManager : ExtensibleManagedObject
	{
		protected HostVirtualNicManagerInfo _info;
		public HostVirtualNicManagerInfo Info
		{
			get
			{
				return this._info;
			}
		}
		public HostVirtualNicManager(IVimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public VirtualNicManagerNetConfig QueryNetConfig(string nicType)
		{
			VirtualNicManagerNetConfig result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				QueryNetConfigRequestType queryNetConfigRequestType = new QueryNetConfigRequestType();
				queryNetConfigRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				queryNetConfigRequestType.nicType = nicType;
				result = (VirtualNicManagerNetConfig)VIConvert.ToVim(this.VimServiceProxy.QueryNetConfig(new QueryNetConfigRequest(queryNetConfigRequestType)).QueryNetConfigResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void SelectVnicForNicType(string nicType, string device)
		{
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				SelectVnicForNicTypeRequestType selectVnicForNicTypeRequestType = new SelectVnicForNicTypeRequestType();
				selectVnicForNicTypeRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				selectVnicForNicTypeRequestType.nicType = nicType;
				selectVnicForNicTypeRequestType.device = device;
				this.VimServiceProxy.SelectVnicForNicType(new SelectVnicForNicTypeRequest(selectVnicForNicTypeRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void DeselectVnicForNicType(string nicType, string device)
		{
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				DeselectVnicForNicTypeRequestType deselectVnicForNicTypeRequestType = new DeselectVnicForNicTypeRequestType();
				deselectVnicForNicTypeRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				deselectVnicForNicTypeRequestType.nicType = nicType;
				deselectVnicForNicTypeRequestType.device = device;
				this.VimServiceProxy.DeselectVnicForNicType(new DeselectVnicForNicTypeRequest(deselectVnicForNicTypeRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
	}
}
