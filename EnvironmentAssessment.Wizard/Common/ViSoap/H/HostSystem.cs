using System;
using System.Web.Services.Protocols;
using VimApi_60;
namespace EnvironmentAssessment.Common.VISoap
{
	public class HostSystem : ManagedEntity
	{
		protected HostRuntimeInfo _runtime;
		protected HostListSummary _summary;
		protected HostHardwareInfo _hardware;
		protected HostCapability _capability;
		protected HostLicensableResourceInfo _licensableResource;
		protected HostConfigManager _configManager;
		protected HostConfigInfo _config;
		protected ManagedObjectReference[] _vm;
		protected ManagedObjectReference[] _datastore;
		protected ManagedObjectReference[] _network;
		protected ManagedObjectReference _datastoreBrowser;
		protected HostSystemResourceInfo _systemResources;
		public HostRuntimeInfo Runtime
		{
			get
			{
				return this._runtime;
			}
		}
		public HostListSummary Summary
		{
			get
			{
				return this._summary;
			}
		}
		public HostHardwareInfo Hardware
		{
			get
			{
				return this._hardware;
			}
		}
		public HostCapability Capability
		{
			get
			{
				return this._capability;
			}
		}
		public HostLicensableResourceInfo LicensableResource
		{
			get
			{
				return this._licensableResource;
			}
		}
		public HostConfigManager ConfigManager
		{
			get
			{
				return this._configManager;
			}
		}
		public HostConfigInfo Config
		{
			get
			{
				return this._config;
			}
		}
		public ManagedObjectReference[] Vm
		{
			get
			{
				return this._vm;
			}
		}
		public ManagedObjectReference[] Datastore
		{
			get
			{
				return this._datastore;
			}
		}
		public ManagedObjectReference[] Network
		{
			get
			{
				return this._network;
			}
		}
		public ManagedObjectReference DatastoreBrowser
		{
			get
			{
				return this._datastoreBrowser;
			}
		}
		public HostSystemResourceInfo SystemResources
		{
			get
			{
				return this._systemResources;
			}
		}
		public new HostSystem_LinkedView LinkedView
		{
			get
			{
				return (HostSystem_LinkedView)this._linkedView;
			}
		}
		public HostSystem(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public HostTpmAttestationReport QueryTpmAttestationReport()
		{
			HostTpmAttestationReport result;
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
				if (this.Client.Version == VimVersion.Vim50)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				result = (HostTpmAttestationReport)VIConvert.ToVim(((VimService)this.Client.VimService).QueryTpmAttestationReport((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public HostConnectInfo QueryHostConnectionInfo()
		{
			HostConnectInfo result;
			try
			{
				result = (HostConnectInfo)VIConvert.ToVim(((VimService)this.Client.VimService).QueryHostConnectionInfo((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public void UpdateSystemResources(HostSystemResourceInfo resourceInfo)
		{
			try
			{
				((VimService)this.Client.VimService).UpdateSystemResources((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.HostSystemResourceInfo)VIConvert.ToWsdlType(resourceInfo));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public void UpdateSystemSwapConfiguration(HostSystemSwapConfiguration sysSwapConfig)
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
				if (this.Client.Version == VimVersion.Vim50)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				((VimService)this.Client.VimService).UpdateSystemSwapConfiguration((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.HostSystemSwapConfiguration)VIConvert.ToWsdlType(sysSwapConfig));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public ManagedObjectReference ReconnectHost_Task(HostConnectSpec cnxSpec, HostSystemReconnectSpec reconnectSpec)
		{
			ManagedObjectReference result;
			try
			{
				result = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).ReconnectHost_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.HostConnectSpec)VIConvert.ToWsdlType(cnxSpec), (VimApi_60.HostSystemReconnectSpec)VIConvert.ToWsdlType(reconnectSpec)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public void ReconnectHost(HostConnectSpec cnxSpec, HostSystemReconnectSpec reconnectSpec)
		{
			try
			{
				ManagedObjectReference taskReference = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).ReconnectHost_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.HostConnectSpec)VIConvert.ToWsdlType(cnxSpec), (VimApi_60.HostSystemReconnectSpec)VIConvert.ToWsdlType(reconnectSpec)));
				this.Client.WaitForTask(taskReference);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public ManagedObjectReference DisconnectHost_Task()
		{
			ManagedObjectReference result;
			try
			{
				result = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).DisconnectHost_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public void DisconnectHost()
		{
			try
			{
				ManagedObjectReference taskReference = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).DisconnectHost_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef)));
				this.Client.WaitForTask(taskReference);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public ManagedObjectReference EnterMaintenanceMode_Task(int timeout, bool? evacuatePoweredOffVms, HostMaintenanceSpec maintenanceSpec)
		{
			ManagedObjectReference result;
			try
			{
				result = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).EnterMaintenanceMode_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), timeout, evacuatePoweredOffVms.GetValueOrDefault(), evacuatePoweredOffVms.HasValue, (VimApi_60.HostMaintenanceSpec)VIConvert.ToWsdlType(maintenanceSpec)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		[Obsolete("The method EnterMaintenanceMode in HostSystem is deprecated in version 5.1.")]
		public void EnterMaintenanceMode(int timeout, bool? evacuatePoweredOffVms)
		{
			this.EnterMaintenanceMode(timeout, evacuatePoweredOffVms, null);
		}
		[Obsolete("The method EnterMaintenanceMode_Task in HostSystem is deprecated in version 5.1.")]
		public ManagedObjectReference EnterMaintenanceMode_Task(int timeout, bool? evacuatePoweredOffVms)
		{
			return this.EnterMaintenanceMode_Task(timeout, evacuatePoweredOffVms, null);
		}
		public void EnterMaintenanceMode(int timeout, bool? evacuatePoweredOffVms, HostMaintenanceSpec maintenanceSpec)
		{
			try
			{
				ManagedObjectReference taskReference = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).EnterMaintenanceMode_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), timeout, evacuatePoweredOffVms.GetValueOrDefault(), evacuatePoweredOffVms.HasValue, (VimApi_60.HostMaintenanceSpec)VIConvert.ToWsdlType(maintenanceSpec)));
				this.Client.WaitForTask(taskReference);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public ManagedObjectReference ExitMaintenanceMode_Task(int timeout)
		{
			ManagedObjectReference result;
			try
			{
				result = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).ExitMaintenanceMode_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), timeout));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public void ExitMaintenanceMode(int timeout)
		{
			try
			{
				ManagedObjectReference taskReference = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).ExitMaintenanceMode_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), timeout));
				this.Client.WaitForTask(taskReference);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public ManagedObjectReference RebootHost_Task(bool force)
		{
			ManagedObjectReference result;
			try
			{
				result = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).RebootHost_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), force));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public void RebootHost(bool force)
		{
			try
			{
				ManagedObjectReference taskReference = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).RebootHost_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), force));
				this.Client.WaitForTask(taskReference);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public ManagedObjectReference ShutdownHost_Task(bool force)
		{
			ManagedObjectReference result;
			try
			{
				result = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).ShutdownHost_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), force));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public void ShutdownHost(bool force)
		{
			try
			{
				ManagedObjectReference taskReference = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).ShutdownHost_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), force));
				this.Client.WaitForTask(taskReference);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public ManagedObjectReference PowerDownHostToStandBy_Task(int timeoutSec, bool? evacuatePoweredOffVms)
		{
			ManagedObjectReference result;
			try
			{
				result = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).PowerDownHostToStandBy_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), timeoutSec, evacuatePoweredOffVms.GetValueOrDefault(), evacuatePoweredOffVms.HasValue));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public void PowerDownHostToStandBy(int timeoutSec, bool? evacuatePoweredOffVms)
		{
			try
			{
				ManagedObjectReference taskReference = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).PowerDownHostToStandBy_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), timeoutSec, evacuatePoweredOffVms.GetValueOrDefault(), evacuatePoweredOffVms.HasValue));
				this.Client.WaitForTask(taskReference);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public ManagedObjectReference PowerUpHostFromStandBy_Task(int timeoutSec)
		{
			ManagedObjectReference result;
			try
			{
				result = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).PowerUpHostFromStandBy_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), timeoutSec));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public void PowerUpHostFromStandBy(int timeoutSec)
		{
			try
			{
				ManagedObjectReference taskReference = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).PowerUpHostFromStandBy_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), timeoutSec));
				this.Client.WaitForTask(taskReference);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public long QueryMemoryOverhead(long memorySize, int? videoRamSize, int numVcpus)
		{
			long result;
			try
			{
				result = ((VimService)this.Client.VimService).QueryMemoryOverhead((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), memorySize, videoRamSize.GetValueOrDefault(), videoRamSize.HasValue, numVcpus);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public long QueryMemoryOverheadEx(VirtualMachineConfigInfo vmConfigInfo)
		{
			long result;
			try
			{
				result = ((VimService)this.Client.VimService).QueryMemoryOverheadEx((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.VirtualMachineConfigInfo)VIConvert.ToWsdlType(vmConfigInfo));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public ManagedObjectReference ReconfigureHostForDAS_Task()
		{
			ManagedObjectReference result;
			try
			{
				result = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).ReconfigureHostForDAS_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public void ReconfigureHostForDAS()
		{
			try
			{
				ManagedObjectReference taskReference = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).ReconfigureHostForDAS_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef)));
				this.Client.WaitForTask(taskReference);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public void UpdateFlags(HostFlagInfo flagInfo)
		{
			try
			{
				((VimService)this.Client.VimService).UpdateFlags((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.HostFlagInfo)VIConvert.ToWsdlType(flagInfo));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public void EnterLockdownMode()
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
				((VimService)this.Client.VimService).EnterLockdownMode((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public void ExitLockdownMode()
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
				((VimService)this.Client.VimService).ExitLockdownMode((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public HostServiceTicket AcquireCimServicesTicket()
		{
			HostServiceTicket result;
			try
			{
				result = (HostServiceTicket)VIConvert.ToVim(((VimService)this.Client.VimService).AcquireCimServicesTicket((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public void UpdateIpmi(HostIpmiInfo ipmiInfo)
		{
			try
			{
				if (this.Client.Version == VimVersion.Vim25)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				((VimService)this.Client.VimService).UpdateIpmi((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.HostIpmiInfo)VIConvert.ToWsdlType(ipmiInfo));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public long RetrieveHardwareUptime()
		{
			long result;
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
				result = ((VimService)this.Client.VimService).RetrieveHardwareUptime((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
	}
}
