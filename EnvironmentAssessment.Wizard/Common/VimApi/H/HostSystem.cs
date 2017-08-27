using System;
using System.ServiceModel;
using VimApi_65;
namespace EnvironmentAssessment.Common.VimApi
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
		public HostSystem(IVimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public HostTpmAttestationReport QueryTpmAttestationReport()
		{
			HostTpmAttestationReport result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim51);
				QueryTpmAttestationReportRequestType queryTpmAttestationReportRequestType = new QueryTpmAttestationReportRequestType();
				queryTpmAttestationReportRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				result = (HostTpmAttestationReport)VIConvert.ToVim(this.VimServiceProxy.QueryTpmAttestationReport(new QueryTpmAttestationReportRequest(queryTpmAttestationReportRequestType)).QueryTpmAttestationReportResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public HostConnectInfo QueryHostConnectionInfo()
		{
			HostConnectInfo result;
			try
			{
				QueryHostConnectionInfoRequestType queryHostConnectionInfoRequestType = new QueryHostConnectionInfoRequestType();
				queryHostConnectionInfoRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				result = (HostConnectInfo)VIConvert.ToVim(this.VimServiceProxy.QueryHostConnectionInfo(new QueryHostConnectionInfoRequest(queryHostConnectionInfoRequestType)).QueryHostConnectionInfoResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void UpdateSystemResources(HostSystemResourceInfo resourceInfo)
		{
			try
			{
				UpdateSystemResourcesRequestType updateSystemResourcesRequestType = new UpdateSystemResourcesRequestType();
				updateSystemResourcesRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				updateSystemResourcesRequestType.resourceInfo = (VimApi_65.HostSystemResourceInfo)VIConvert.ToWsdlType(resourceInfo);
				this.VimServiceProxy.UpdateSystemResources(new UpdateSystemResourcesRequest(updateSystemResourcesRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void UpdateSystemSwapConfiguration(HostSystemSwapConfiguration sysSwapConfig)
		{
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim51);
				UpdateSystemSwapConfigurationRequestType updateSystemSwapConfigurationRequestType = new UpdateSystemSwapConfigurationRequestType();
				updateSystemSwapConfigurationRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				updateSystemSwapConfigurationRequestType.sysSwapConfig = (VimApi_65.HostSystemSwapConfiguration)VIConvert.ToWsdlType(sysSwapConfig);
				this.VimServiceProxy.UpdateSystemSwapConfiguration(new UpdateSystemSwapConfigurationRequest(updateSystemSwapConfigurationRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public ManagedObjectReference ReconnectHost_Task(HostConnectSpec cnxSpec, HostSystemReconnectSpec reconnectSpec)
		{
			ManagedObjectReference result;
			try
			{
				ReconnectHostRequestType reconnectHostRequestType = new ReconnectHostRequestType();
				reconnectHostRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				reconnectHostRequestType.cnxSpec = (VimApi_65.HostConnectSpec)VIConvert.ToWsdlType(cnxSpec);
				reconnectHostRequestType.reconnectSpec = (VimApi_65.HostSystemReconnectSpec)VIConvert.ToWsdlType(reconnectSpec);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.ReconnectHost_Task(new ReconnectHost_TaskRequest(reconnectHostRequestType)).ReconnectHost_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void ReconnectHost(HostConnectSpec cnxSpec, HostSystemReconnectSpec reconnectSpec)
		{
			try
			{
				ManagedObjectReference taskReference = this.ReconnectHost_Task(cnxSpec, reconnectSpec);
				this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public ManagedObjectReference DisconnectHost_Task()
		{
			ManagedObjectReference result;
			try
			{
				DisconnectHostRequestType disconnectHostRequestType = new DisconnectHostRequestType();
				disconnectHostRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.DisconnectHost_Task(new DisconnectHost_TaskRequest(disconnectHostRequestType)).DisconnectHost_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void DisconnectHost()
		{
			try
			{
				ManagedObjectReference taskReference = this.DisconnectHost_Task();
				this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
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
		
		public ManagedObjectReference EnterMaintenanceMode_Task(int timeout, bool? evacuatePoweredOffVms, HostMaintenanceSpec maintenanceSpec)
		{
			ManagedObjectReference result;
			try
			{
				EnterMaintenanceModeRequestType enterMaintenanceModeRequestType = new EnterMaintenanceModeRequestType();
				enterMaintenanceModeRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				enterMaintenanceModeRequestType.timeout = timeout;
				enterMaintenanceModeRequestType.evacuatePoweredOffVms = evacuatePoweredOffVms.GetValueOrDefault();
				enterMaintenanceModeRequestType.evacuatePoweredOffVmsSpecified = evacuatePoweredOffVms.HasValue;
				enterMaintenanceModeRequestType.maintenanceSpec = (VimApi_65.HostMaintenanceSpec)VIConvert.ToWsdlType(maintenanceSpec);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.EnterMaintenanceMode_Task(new EnterMaintenanceMode_TaskRequest(enterMaintenanceModeRequestType)).EnterMaintenanceMode_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void EnterMaintenanceMode(int timeout, bool? evacuatePoweredOffVms, HostMaintenanceSpec maintenanceSpec)
		{
			try
			{
				ManagedObjectReference taskReference = this.EnterMaintenanceMode_Task(timeout, evacuatePoweredOffVms, maintenanceSpec);
				this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public ManagedObjectReference ExitMaintenanceMode_Task(int timeout)
		{
			ManagedObjectReference result;
			try
			{
				ExitMaintenanceModeRequestType exitMaintenanceModeRequestType = new ExitMaintenanceModeRequestType();
				exitMaintenanceModeRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				exitMaintenanceModeRequestType.timeout = timeout;
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.ExitMaintenanceMode_Task(new ExitMaintenanceMode_TaskRequest(exitMaintenanceModeRequestType)).ExitMaintenanceMode_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void ExitMaintenanceMode(int timeout)
		{
			try
			{
				ManagedObjectReference taskReference = this.ExitMaintenanceMode_Task(timeout);
				this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public ManagedObjectReference RebootHost_Task(bool force)
		{
			ManagedObjectReference result;
			try
			{
				RebootHostRequestType rebootHostRequestType = new RebootHostRequestType();
				rebootHostRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				rebootHostRequestType.force = force;
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.RebootHost_Task(new RebootHost_TaskRequest(rebootHostRequestType)).RebootHost_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void RebootHost(bool force)
		{
			try
			{
				ManagedObjectReference taskReference = this.RebootHost_Task(force);
				this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public ManagedObjectReference ShutdownHost_Task(bool force)
		{
			ManagedObjectReference result;
			try
			{
				ShutdownHostRequestType shutdownHostRequestType = new ShutdownHostRequestType();
				shutdownHostRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				shutdownHostRequestType.force = force;
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.ShutdownHost_Task(new ShutdownHost_TaskRequest(shutdownHostRequestType)).ShutdownHost_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void ShutdownHost(bool force)
		{
			try
			{
				ManagedObjectReference taskReference = this.ShutdownHost_Task(force);
				this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public ManagedObjectReference PowerDownHostToStandBy_Task(int timeoutSec, bool? evacuatePoweredOffVms)
		{
			ManagedObjectReference result;
			try
			{
				PowerDownHostToStandByRequestType powerDownHostToStandByRequestType = new PowerDownHostToStandByRequestType();
				powerDownHostToStandByRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				powerDownHostToStandByRequestType.timeoutSec = timeoutSec;
				powerDownHostToStandByRequestType.evacuatePoweredOffVms = evacuatePoweredOffVms.GetValueOrDefault();
				powerDownHostToStandByRequestType.evacuatePoweredOffVmsSpecified = evacuatePoweredOffVms.HasValue;
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.PowerDownHostToStandBy_Task(new PowerDownHostToStandBy_TaskRequest(powerDownHostToStandByRequestType)).PowerDownHostToStandBy_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void PowerDownHostToStandBy(int timeoutSec, bool? evacuatePoweredOffVms)
		{
			try
			{
				ManagedObjectReference taskReference = this.PowerDownHostToStandBy_Task(timeoutSec, evacuatePoweredOffVms);
				this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public ManagedObjectReference PowerUpHostFromStandBy_Task(int timeoutSec)
		{
			ManagedObjectReference result;
			try
			{
				PowerUpHostFromStandByRequestType powerUpHostFromStandByRequestType = new PowerUpHostFromStandByRequestType();
				powerUpHostFromStandByRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				powerUpHostFromStandByRequestType.timeoutSec = timeoutSec;
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.PowerUpHostFromStandBy_Task(new PowerUpHostFromStandBy_TaskRequest(powerUpHostFromStandByRequestType)).PowerUpHostFromStandBy_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void PowerUpHostFromStandBy(int timeoutSec)
		{
			try
			{
				ManagedObjectReference taskReference = this.PowerUpHostFromStandBy_Task(timeoutSec);
				this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public long QueryMemoryOverhead(long memorySize, int? videoRamSize, int numVcpus)
		{
			long returnval;
			try
			{
				QueryMemoryOverheadRequestType queryMemoryOverheadRequestType = new QueryMemoryOverheadRequestType();
				queryMemoryOverheadRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				queryMemoryOverheadRequestType.memorySize = memorySize;
				queryMemoryOverheadRequestType.videoRamSize = videoRamSize.GetValueOrDefault();
				queryMemoryOverheadRequestType.videoRamSizeSpecified = videoRamSize.HasValue;
				queryMemoryOverheadRequestType.numVcpus = numVcpus;
				returnval = this.VimServiceProxy.QueryMemoryOverhead(new QueryMemoryOverheadRequest(queryMemoryOverheadRequestType)).QueryMemoryOverheadResponse.returnval;
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return returnval;
		}
		public long QueryMemoryOverheadEx(VirtualMachineConfigInfo vmConfigInfo)
		{
			long returnval;
			try
			{
				QueryMemoryOverheadExRequestType queryMemoryOverheadExRequestType = new QueryMemoryOverheadExRequestType();
				queryMemoryOverheadExRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				queryMemoryOverheadExRequestType.vmConfigInfo = (VimApi_65.VirtualMachineConfigInfo)VIConvert.ToWsdlType(vmConfigInfo);
				returnval = this.VimServiceProxy.QueryMemoryOverheadEx(new QueryMemoryOverheadExRequest(queryMemoryOverheadExRequestType)).QueryMemoryOverheadExResponse.returnval;
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return returnval;
		}
		public ManagedObjectReference ReconfigureHostForDAS_Task()
		{
			ManagedObjectReference result;
			try
			{
				ReconfigureHostForDASRequestType reconfigureHostForDASRequestType = new ReconfigureHostForDASRequestType();
				reconfigureHostForDASRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.ReconfigureHostForDAS_Task(new ReconfigureHostForDAS_TaskRequest(reconfigureHostForDASRequestType)).ReconfigureHostForDAS_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void ReconfigureHostForDAS()
		{
			try
			{
				ManagedObjectReference taskReference = this.ReconfigureHostForDAS_Task();
				this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void UpdateFlags(HostFlagInfo flagInfo)
		{
			try
			{
				UpdateFlagsRequestType updateFlagsRequestType = new UpdateFlagsRequestType();
				updateFlagsRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				updateFlagsRequestType.flagInfo = (VimApi_65.HostFlagInfo)VIConvert.ToWsdlType(flagInfo);
				this.VimServiceProxy.UpdateFlags(new UpdateFlagsRequest(updateFlagsRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void EnterLockdownMode()
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim41);
				EnterLockdownModeRequestType enterLockdownModeRequestType = new EnterLockdownModeRequestType();
				enterLockdownModeRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				this.VimServiceProxy.EnterLockdownMode(new EnterLockdownModeRequest(enterLockdownModeRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void ExitLockdownMode()
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim41);
				ExitLockdownModeRequestType exitLockdownModeRequestType = new ExitLockdownModeRequestType();
				exitLockdownModeRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				this.VimServiceProxy.ExitLockdownMode(new ExitLockdownModeRequest(exitLockdownModeRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public HostServiceTicket AcquireCimServicesTicket()
		{
			HostServiceTicket result;
			try
			{
				AcquireCimServicesTicketRequestType acquireCimServicesTicketRequestType = new AcquireCimServicesTicketRequestType();
				acquireCimServicesTicketRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				result = (HostServiceTicket)VIConvert.ToVim(this.VimServiceProxy.AcquireCimServicesTicket(new AcquireCimServicesTicketRequest(acquireCimServicesTicketRequestType)).AcquireCimServicesTicketResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void UpdateIpmi(HostIpmiInfo ipmiInfo)
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				UpdateIpmiRequestType updateIpmiRequestType = new UpdateIpmiRequestType();
				updateIpmiRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				updateIpmiRequestType.ipmiInfo = (VimApi_65.HostIpmiInfo)VIConvert.ToWsdlType(ipmiInfo);
				this.VimServiceProxy.UpdateIpmi(new UpdateIpmiRequest(updateIpmiRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public long RetrieveHardwareUptime()
		{
			long returnval;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim41);
				RetrieveHardwareUptimeRequestType retrieveHardwareUptimeRequestType = new RetrieveHardwareUptimeRequestType();
				retrieveHardwareUptimeRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				returnval = this.VimServiceProxy.RetrieveHardwareUptime(new RetrieveHardwareUptimeRequest(retrieveHardwareUptimeRequestType)).RetrieveHardwareUptimeResponse.returnval;
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return returnval;
		}
		public void PrepareCrypto()
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim65);
				PrepareCryptoRequestType prepareCryptoRequestType = new PrepareCryptoRequestType();
				prepareCryptoRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				this.VimServiceProxy.PrepareCrypto(new PrepareCryptoRequest(prepareCryptoRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void EnableCrypto(CryptoKeyPlain keyPlain)
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim65);
				EnableCryptoRequestType enableCryptoRequestType = new EnableCryptoRequestType();
				enableCryptoRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				enableCryptoRequestType.keyPlain = (VimApi_65.CryptoKeyPlain)VIConvert.ToWsdlType(keyPlain);
				this.VimServiceProxy.EnableCrypto(new EnableCryptoRequest(enableCryptoRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void ConfigureCryptoKey(CryptoKeyId keyId)
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim65);
				ConfigureCryptoKeyRequestType configureCryptoKeyRequestType = new ConfigureCryptoKeyRequestType();
				configureCryptoKeyRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				configureCryptoKeyRequestType.keyId = (VimApi_65.CryptoKeyId)VIConvert.ToWsdlType(keyId);
				this.VimServiceProxy.ConfigureCryptoKey(new ConfigureCryptoKeyRequest(configureCryptoKeyRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
	}
}
