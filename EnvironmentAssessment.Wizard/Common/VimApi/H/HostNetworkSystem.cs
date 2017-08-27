using System.ServiceModel;
using VimApi_65;
namespace EnvironmentAssessment.Common.VimApi
{
	public class HostNetworkSystem : ExtensibleManagedObject
	{
		protected HostNetCapabilities _capabilities;
		protected HostNetworkInfo _networkInfo;
		protected HostNetOffloadCapabilities _offloadCapabilities;
		protected HostNetworkConfig _networkConfig;
		protected HostDnsConfig _dnsConfig;
		protected HostIpRouteConfig _ipRouteConfig;
		protected HostIpRouteConfig _consoleIpRouteConfig;
		public HostNetCapabilities Capabilities
		{
			get
			{
				return this._capabilities;
			}
		}
		public HostNetworkInfo NetworkInfo
		{
			get
			{
				return this._networkInfo;
			}
		}
		public HostNetOffloadCapabilities OffloadCapabilities
		{
			get
			{
				return this._offloadCapabilities;
			}
		}
		public HostNetworkConfig NetworkConfig
		{
			get
			{
				return this._networkConfig;
			}
		}
		public HostDnsConfig DnsConfig
		{
			get
			{
				return this._dnsConfig;
			}
		}
		public HostIpRouteConfig IpRouteConfig
		{
			get
			{
				return this._ipRouteConfig;
			}
		}
		public HostIpRouteConfig ConsoleIpRouteConfig
		{
			get
			{
				return this._consoleIpRouteConfig;
			}
		}
		public HostNetworkSystem(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public HostNetworkConfigResult UpdateNetworkConfig(HostNetworkConfig config, string changeMode)
		{
			HostNetworkConfigResult result;
			try
			{
				UpdateNetworkConfigRequestType updateNetworkConfigRequestType = new UpdateNetworkConfigRequestType();
				updateNetworkConfigRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				updateNetworkConfigRequestType.config = (VimApi_65.HostNetworkConfig)VIConvert.ToWsdlType(config);
				updateNetworkConfigRequestType.changeMode = changeMode;
				result = (HostNetworkConfigResult)VIConvert.ToVim(this.VimServiceProxy.UpdateNetworkConfig(new UpdateNetworkConfigRequest(updateNetworkConfigRequestType)).UpdateNetworkConfigResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void UpdateDnsConfig(HostDnsConfig config)
		{
			try
			{
				UpdateDnsConfigRequestType updateDnsConfigRequestType = new UpdateDnsConfigRequestType();
				updateDnsConfigRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				updateDnsConfigRequestType.config = (VimApi_65.HostDnsConfig)VIConvert.ToWsdlType(config);
				this.VimServiceProxy.UpdateDnsConfig(new UpdateDnsConfigRequest(updateDnsConfigRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void UpdateIpRouteConfig(HostIpRouteConfig config)
		{
			try
			{
				UpdateIpRouteConfigRequestType updateIpRouteConfigRequestType = new UpdateIpRouteConfigRequestType();
				updateIpRouteConfigRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				updateIpRouteConfigRequestType.config = (VimApi_65.HostIpRouteConfig)VIConvert.ToWsdlType(config);
				this.VimServiceProxy.UpdateIpRouteConfig(new UpdateIpRouteConfigRequest(updateIpRouteConfigRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void UpdateConsoleIpRouteConfig(HostIpRouteConfig config)
		{
			try
			{
				UpdateConsoleIpRouteConfigRequestType updateConsoleIpRouteConfigRequestType = new UpdateConsoleIpRouteConfigRequestType();
				updateConsoleIpRouteConfigRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				updateConsoleIpRouteConfigRequestType.config = (VimApi_65.HostIpRouteConfig)VIConvert.ToWsdlType(config);
				this.VimServiceProxy.UpdateConsoleIpRouteConfig(new UpdateConsoleIpRouteConfigRequest(updateConsoleIpRouteConfigRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void UpdateIpRouteTableConfig(HostIpRouteTableConfig config)
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				UpdateIpRouteTableConfigRequestType updateIpRouteTableConfigRequestType = new UpdateIpRouteTableConfigRequestType();
				updateIpRouteTableConfigRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				updateIpRouteTableConfigRequestType.config = (VimApi_65.HostIpRouteTableConfig)VIConvert.ToWsdlType(config);
				this.VimServiceProxy.UpdateIpRouteTableConfig(new UpdateIpRouteTableConfigRequest(updateIpRouteTableConfigRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void AddVirtualSwitch(string vswitchName, HostVirtualSwitchSpec spec)
		{
			try
			{
				AddVirtualSwitchRequestType addVirtualSwitchRequestType = new AddVirtualSwitchRequestType();
				addVirtualSwitchRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				addVirtualSwitchRequestType.vswitchName = vswitchName;
				addVirtualSwitchRequestType.spec = (VimApi_65.HostVirtualSwitchSpec)VIConvert.ToWsdlType(spec);
				this.VimServiceProxy.AddVirtualSwitch(new AddVirtualSwitchRequest(addVirtualSwitchRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void RemoveVirtualSwitch(string vswitchName)
		{
			try
			{
				RemoveVirtualSwitchRequestType removeVirtualSwitchRequestType = new RemoveVirtualSwitchRequestType();
				removeVirtualSwitchRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				removeVirtualSwitchRequestType.vswitchName = vswitchName;
				this.VimServiceProxy.RemoveVirtualSwitch(new RemoveVirtualSwitchRequest(removeVirtualSwitchRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void UpdateVirtualSwitch(string vswitchName, HostVirtualSwitchSpec spec)
		{
			try
			{
				UpdateVirtualSwitchRequestType updateVirtualSwitchRequestType = new UpdateVirtualSwitchRequestType();
				updateVirtualSwitchRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				updateVirtualSwitchRequestType.vswitchName = vswitchName;
				updateVirtualSwitchRequestType.spec = (VimApi_65.HostVirtualSwitchSpec)VIConvert.ToWsdlType(spec);
				this.VimServiceProxy.UpdateVirtualSwitch(new UpdateVirtualSwitchRequest(updateVirtualSwitchRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void AddPortGroup(HostPortGroupSpec portgrp)
		{
			try
			{
				AddPortGroupRequestType addPortGroupRequestType = new AddPortGroupRequestType();
				addPortGroupRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				addPortGroupRequestType.portgrp = (VimApi_65.HostPortGroupSpec)VIConvert.ToWsdlType(portgrp);
				this.VimServiceProxy.AddPortGroup(new AddPortGroupRequest(addPortGroupRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void RemovePortGroup(string pgName)
		{
			try
			{
				RemovePortGroupRequestType removePortGroupRequestType = new RemovePortGroupRequestType();
				removePortGroupRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				removePortGroupRequestType.pgName = pgName;
				this.VimServiceProxy.RemovePortGroup(new RemovePortGroupRequest(removePortGroupRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void UpdatePortGroup(string pgName, HostPortGroupSpec portgrp)
		{
			try
			{
				UpdatePortGroupRequestType updatePortGroupRequestType = new UpdatePortGroupRequestType();
				updatePortGroupRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				updatePortGroupRequestType.pgName = pgName;
				updatePortGroupRequestType.portgrp = (VimApi_65.HostPortGroupSpec)VIConvert.ToWsdlType(portgrp);
				this.VimServiceProxy.UpdatePortGroup(new UpdatePortGroupRequest(updatePortGroupRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void UpdatePhysicalNicLinkSpeed(string device, PhysicalNicLinkInfo linkSpeed)
		{
			try
			{
				UpdatePhysicalNicLinkSpeedRequestType updatePhysicalNicLinkSpeedRequestType = new UpdatePhysicalNicLinkSpeedRequestType();
				updatePhysicalNicLinkSpeedRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				updatePhysicalNicLinkSpeedRequestType.device = device;
				updatePhysicalNicLinkSpeedRequestType.linkSpeed = (VimApi_65.PhysicalNicLinkInfo)VIConvert.ToWsdlType(linkSpeed);
				this.VimServiceProxy.UpdatePhysicalNicLinkSpeed(new UpdatePhysicalNicLinkSpeedRequest(updatePhysicalNicLinkSpeedRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public PhysicalNicHintInfo[] QueryNetworkHint(string[] device)
		{
			PhysicalNicHintInfo[] result;
			try
			{
				QueryNetworkHintRequestType queryNetworkHintRequestType = new QueryNetworkHintRequestType();
				queryNetworkHintRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				queryNetworkHintRequestType.device = device;
				result = (PhysicalNicHintInfo[])VIConvert.ToVim(this.VimServiceProxy.QueryNetworkHint(new QueryNetworkHintRequest(queryNetworkHintRequestType)).QueryNetworkHintResponse1);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public string AddVirtualNic(string portgroup, HostVirtualNicSpec nic)
		{
			string returnval;
			try
			{
				AddVirtualNicRequestType addVirtualNicRequestType = new AddVirtualNicRequestType();
				addVirtualNicRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				addVirtualNicRequestType.portgroup = portgroup;
				addVirtualNicRequestType.nic = (VimApi_65.HostVirtualNicSpec)VIConvert.ToWsdlType(nic);
				returnval = this.VimServiceProxy.AddVirtualNic(new AddVirtualNicRequest(addVirtualNicRequestType)).AddVirtualNicResponse.returnval;
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return returnval;
		}
		public void RemoveVirtualNic(string device)
		{
			try
			{
				RemoveVirtualNicRequestType removeVirtualNicRequestType = new RemoveVirtualNicRequestType();
				removeVirtualNicRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				removeVirtualNicRequestType.device = device;
				this.VimServiceProxy.RemoveVirtualNic(new RemoveVirtualNicRequest(removeVirtualNicRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void UpdateVirtualNic(string device, HostVirtualNicSpec nic)
		{
			try
			{
				UpdateVirtualNicRequestType updateVirtualNicRequestType = new UpdateVirtualNicRequestType();
				updateVirtualNicRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				updateVirtualNicRequestType.device = device;
				updateVirtualNicRequestType.nic = (VimApi_65.HostVirtualNicSpec)VIConvert.ToWsdlType(nic);
				this.VimServiceProxy.UpdateVirtualNic(new UpdateVirtualNicRequest(updateVirtualNicRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public string AddServiceConsoleVirtualNic(string portgroup, HostVirtualNicSpec nic)
		{
			string returnval;
			try
			{
				AddServiceConsoleVirtualNicRequestType addServiceConsoleVirtualNicRequestType = new AddServiceConsoleVirtualNicRequestType();
				addServiceConsoleVirtualNicRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				addServiceConsoleVirtualNicRequestType.portgroup = portgroup;
				addServiceConsoleVirtualNicRequestType.nic = (VimApi_65.HostVirtualNicSpec)VIConvert.ToWsdlType(nic);
				returnval = this.VimServiceProxy.AddServiceConsoleVirtualNic(new AddServiceConsoleVirtualNicRequest(addServiceConsoleVirtualNicRequestType)).AddServiceConsoleVirtualNicResponse.returnval;
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return returnval;
		}
		public void RemoveServiceConsoleVirtualNic(string device)
		{
			try
			{
				RemoveServiceConsoleVirtualNicRequestType removeServiceConsoleVirtualNicRequestType = new RemoveServiceConsoleVirtualNicRequestType();
				removeServiceConsoleVirtualNicRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				removeServiceConsoleVirtualNicRequestType.device = device;
				this.VimServiceProxy.RemoveServiceConsoleVirtualNic(new RemoveServiceConsoleVirtualNicRequest(removeServiceConsoleVirtualNicRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void UpdateServiceConsoleVirtualNic(string device, HostVirtualNicSpec nic)
		{
			try
			{
				UpdateServiceConsoleVirtualNicRequestType updateServiceConsoleVirtualNicRequestType = new UpdateServiceConsoleVirtualNicRequestType();
				updateServiceConsoleVirtualNicRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				updateServiceConsoleVirtualNicRequestType.device = device;
				updateServiceConsoleVirtualNicRequestType.nic = (VimApi_65.HostVirtualNicSpec)VIConvert.ToWsdlType(nic);
				this.VimServiceProxy.UpdateServiceConsoleVirtualNic(new UpdateServiceConsoleVirtualNicRequest(updateServiceConsoleVirtualNicRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void RestartServiceConsoleVirtualNic(string device)
		{
			try
			{
				RestartServiceConsoleVirtualNicRequestType restartServiceConsoleVirtualNicRequestType = new RestartServiceConsoleVirtualNicRequestType();
				restartServiceConsoleVirtualNicRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				restartServiceConsoleVirtualNicRequestType.device = device;
				this.VimServiceProxy.RestartServiceConsoleVirtualNic(new RestartServiceConsoleVirtualNicRequest(restartServiceConsoleVirtualNicRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void RefreshNetworkSystem()
		{
			try
			{
				RefreshNetworkSystemRequestType refreshNetworkSystemRequestType = new RefreshNetworkSystemRequestType();
				refreshNetworkSystemRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				this.VimServiceProxy.RefreshNetworkSystem(new RefreshNetworkSystemRequest(refreshNetworkSystemRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
	}
}
