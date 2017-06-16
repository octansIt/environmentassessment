using System;
using System.Web.Services.Protocols;
using VimApi_60;
namespace EnvironmentAssessment.Common.VISoap
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
				result = (HostNetworkConfigResult)VIConvert.ToVim(((VimService)this.Client.VimService).UpdateNetworkConfig((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.HostNetworkConfig)VIConvert.ToWsdlType(config), changeMode));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public void UpdateDnsConfig(HostDnsConfig config)
		{
			try
			{
				((VimService)this.Client.VimService).UpdateDnsConfig((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.HostDnsConfig)VIConvert.ToWsdlType(config));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public void UpdateIpRouteConfig(HostIpRouteConfig config)
		{
			try
			{
				((VimService)this.Client.VimService).UpdateIpRouteConfig((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.HostIpRouteConfig)VIConvert.ToWsdlType(config));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public void UpdateConsoleIpRouteConfig(HostIpRouteConfig config)
		{
			try
			{
				((VimService)this.Client.VimService).UpdateConsoleIpRouteConfig((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.HostIpRouteConfig)VIConvert.ToWsdlType(config));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public void UpdateIpRouteTableConfig(HostIpRouteTableConfig config)
		{
			try
			{
				if (this.Client.Version == VimVersion.Vim25)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				((VimService)this.Client.VimService).UpdateIpRouteTableConfig((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.HostIpRouteTableConfig)VIConvert.ToWsdlType(config));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public void AddVirtualSwitch(string vswitchName, HostVirtualSwitchSpec spec)
		{
			try
			{
				((VimService)this.Client.VimService).AddVirtualSwitch((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), vswitchName, (VimApi_60.HostVirtualSwitchSpec)VIConvert.ToWsdlType(spec));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public void RemoveVirtualSwitch(string vswitchName)
		{
			try
			{
				((VimService)this.Client.VimService).RemoveVirtualSwitch((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), vswitchName);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public void UpdateVirtualSwitch(string vswitchName, HostVirtualSwitchSpec spec)
		{
			try
			{
				((VimService)this.Client.VimService).UpdateVirtualSwitch((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), vswitchName, (VimApi_60.HostVirtualSwitchSpec)VIConvert.ToWsdlType(spec));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public void AddPortGroup(HostPortGroupSpec portgrp)
		{
			try
			{
				((VimService)this.Client.VimService).AddPortGroup((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.HostPortGroupSpec)VIConvert.ToWsdlType(portgrp));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public void RemovePortGroup(string pgName)
		{
			try
			{
				((VimService)this.Client.VimService).RemovePortGroup((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), pgName);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public void UpdatePortGroup(string pgName, HostPortGroupSpec portgrp)
		{
			try
			{
				((VimService)this.Client.VimService).UpdatePortGroup((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), pgName, (VimApi_60.HostPortGroupSpec)VIConvert.ToWsdlType(portgrp));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public void UpdatePhysicalNicLinkSpeed(string device, PhysicalNicLinkInfo linkSpeed)
		{
			try
			{
				((VimService)this.Client.VimService).UpdatePhysicalNicLinkSpeed((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), device, (VimApi_60.PhysicalNicLinkInfo)VIConvert.ToWsdlType(linkSpeed));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public PhysicalNicHintInfo[] QueryNetworkHint(string[] device)
		{
			PhysicalNicHintInfo[] result;
			try
			{
				result = (PhysicalNicHintInfo[])VIConvert.ToVim(((VimService)this.Client.VimService).QueryNetworkHint((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), device));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public string AddVirtualNic(string portgroup, HostVirtualNicSpec nic)
		{
			string result;
			try
			{
				result = ((VimService)this.Client.VimService).AddVirtualNic((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), portgroup, (VimApi_60.HostVirtualNicSpec)VIConvert.ToWsdlType(nic));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public void RemoveVirtualNic(string device)
		{
			try
			{
				((VimService)this.Client.VimService).RemoveVirtualNic((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), device);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public void UpdateVirtualNic(string device, HostVirtualNicSpec nic)
		{
			try
			{
				((VimService)this.Client.VimService).UpdateVirtualNic((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), device, (VimApi_60.HostVirtualNicSpec)VIConvert.ToWsdlType(nic));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public string AddServiceConsoleVirtualNic(string portgroup, HostVirtualNicSpec nic)
		{
			string result;
			try
			{
				result = ((VimService)this.Client.VimService).AddServiceConsoleVirtualNic((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), portgroup, (VimApi_60.HostVirtualNicSpec)VIConvert.ToWsdlType(nic));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public void RemoveServiceConsoleVirtualNic(string device)
		{
			try
			{
				((VimService)this.Client.VimService).RemoveServiceConsoleVirtualNic((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), device);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public void UpdateServiceConsoleVirtualNic(string device, HostVirtualNicSpec nic)
		{
			try
			{
				((VimService)this.Client.VimService).UpdateServiceConsoleVirtualNic((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), device, (VimApi_60.HostVirtualNicSpec)VIConvert.ToWsdlType(nic));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public void RestartServiceConsoleVirtualNic(string device)
		{
			try
			{
				((VimService)this.Client.VimService).RestartServiceConsoleVirtualNic((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), device);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public void RefreshNetworkSystem()
		{
			try
			{
				((VimService)this.Client.VimService).RefreshNetworkSystem((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
	}
}
