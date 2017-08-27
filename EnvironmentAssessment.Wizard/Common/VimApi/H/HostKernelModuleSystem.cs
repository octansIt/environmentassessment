using System.ServiceModel;
using VimApi_65;
namespace EnvironmentAssessment.Common.VimApi
{
	public class HostKernelModuleSystem : ViewBase
	{
		public HostKernelModuleSystem(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public KernelModuleInfo[] QueryModules()
		{
			KernelModuleInfo[] result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				QueryModulesRequestType queryModulesRequestType = new QueryModulesRequestType();
				queryModulesRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				result = (KernelModuleInfo[])VIConvert.ToVim(this.VimServiceProxy.QueryModules(new QueryModulesRequest(queryModulesRequestType)).QueryModulesResponse1);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void UpdateModuleOptionString(string name, string options)
		{
			try
			{
				UpdateModuleOptionStringRequestType updateModuleOptionStringRequestType = new UpdateModuleOptionStringRequestType();
				updateModuleOptionStringRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				updateModuleOptionStringRequestType.name = name;
				updateModuleOptionStringRequestType.options = options;
				this.VimServiceProxy.UpdateModuleOptionString(new UpdateModuleOptionStringRequest(updateModuleOptionStringRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public string QueryConfiguredModuleOptionString(string name)
		{
			string returnval;
			try
			{
				QueryConfiguredModuleOptionStringRequestType queryConfiguredModuleOptionStringRequestType = new QueryConfiguredModuleOptionStringRequestType();
				queryConfiguredModuleOptionStringRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				queryConfiguredModuleOptionStringRequestType.name = name;
				returnval = this.VimServiceProxy.QueryConfiguredModuleOptionString(new QueryConfiguredModuleOptionStringRequest(queryConfiguredModuleOptionStringRequestType)).QueryConfiguredModuleOptionStringResponse.returnval;
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return returnval;
		}
	}
}
