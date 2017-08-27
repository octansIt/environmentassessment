using System.ServiceModel;
using VimApi_65;
namespace EnvironmentAssessment.Common.VimApi
{
	public class EnvironmentBrowser : ViewBase
	{
		protected ManagedObjectReference _datastoreBrowser;
		protected EnvironmentBrowser_LinkedView _linkedView;
		public ManagedObjectReference DatastoreBrowser
		{
			get
			{
				return this._datastoreBrowser;
			}
		}
		public EnvironmentBrowser_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
		public EnvironmentBrowser(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public VirtualMachineConfigOptionDescriptor[] QueryConfigOptionDescriptor()
		{
			VirtualMachineConfigOptionDescriptor[] result;
			try
			{
				QueryConfigOptionDescriptorRequestType queryConfigOptionDescriptorRequestType = new QueryConfigOptionDescriptorRequestType();
				queryConfigOptionDescriptorRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				result = (VirtualMachineConfigOptionDescriptor[])VIConvert.ToVim(this.VimServiceProxy.QueryConfigOptionDescriptor(new QueryConfigOptionDescriptorRequest(queryConfigOptionDescriptorRequestType)).QueryConfigOptionDescriptorResponse1);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public VirtualMachineConfigOption QueryConfigOption(string key, ManagedObjectReference host)
		{
			VirtualMachineConfigOption result;
			try
			{
				QueryConfigOptionRequestType queryConfigOptionRequestType = new QueryConfigOptionRequestType();
				queryConfigOptionRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				queryConfigOptionRequestType.key = key;
				queryConfigOptionRequestType.host = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(host);
				result = (VirtualMachineConfigOption)VIConvert.ToVim(this.VimServiceProxy.QueryConfigOption(new QueryConfigOptionRequest(queryConfigOptionRequestType)).QueryConfigOptionResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public VirtualMachineConfigOption QueryConfigOptionEx(EnvironmentBrowserConfigOptionQuerySpec spec)
		{
			VirtualMachineConfigOption result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim60);
				QueryConfigOptionExRequestType queryConfigOptionExRequestType = new QueryConfigOptionExRequestType();
				queryConfigOptionExRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				queryConfigOptionExRequestType.spec = (VimApi_65.EnvironmentBrowserConfigOptionQuerySpec)VIConvert.ToWsdlType(spec);
				result = (VirtualMachineConfigOption)VIConvert.ToVim(this.VimServiceProxy.QueryConfigOptionEx(new QueryConfigOptionExRequest(queryConfigOptionExRequestType)).QueryConfigOptionExResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ConfigTarget QueryConfigTarget(ManagedObjectReference host)
		{
			ConfigTarget result;
			try
			{
				QueryConfigTargetRequestType queryConfigTargetRequestType = new QueryConfigTargetRequestType();
				queryConfigTargetRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				queryConfigTargetRequestType.host = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(host);
				result = (ConfigTarget)VIConvert.ToVim(this.VimServiceProxy.QueryConfigTarget(new QueryConfigTargetRequest(queryConfigTargetRequestType)).QueryConfigTargetResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public HostCapability QueryTargetCapabilities(ManagedObjectReference host)
		{
			HostCapability result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim25);
				QueryTargetCapabilitiesRequestType queryTargetCapabilitiesRequestType = new QueryTargetCapabilitiesRequestType();
				queryTargetCapabilitiesRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				queryTargetCapabilitiesRequestType.host = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(host);
				result = (HostCapability)VIConvert.ToVim(this.VimServiceProxy.QueryTargetCapabilities(new QueryTargetCapabilitiesRequest(queryTargetCapabilitiesRequestType)).QueryTargetCapabilitiesResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
	}
}
