using System.ServiceModel;
using VimApi_65;
namespace EnvironmentAssessment.Common.VimApi
{
	public class DistributedVirtualSwitch : ManagedEntity
	{
		protected string _uuid;
		protected DVSCapability _capability;
		protected DVSSummary _summary;
		protected DVSConfigInfo _config;
		protected DVSNetworkResourcePool[] _networkResourcePool;
		protected ManagedObjectReference[] _portgroup;
		protected DVSRuntimeInfo _runtime;
		public string Uuid
		{
			get
			{
				return this._uuid;
			}
		}
		public DVSCapability Capability
		{
			get
			{
				return this._capability;
			}
		}
		public DVSSummary Summary
		{
			get
			{
				return this._summary;
			}
		}
		public DVSConfigInfo Config
		{
			get
			{
				return this._config;
			}
		}
		public DVSNetworkResourcePool[] NetworkResourcePool
		{
			get
			{
				return this._networkResourcePool;
			}
		}
		public ManagedObjectReference[] Portgroup
		{
			get
			{
				return this._portgroup;
			}
		}
		public DVSRuntimeInfo Runtime
		{
			get
			{
				return this._runtime;
			}
		}
		public new DistributedVirtualSwitch_LinkedView LinkedView
		{
			get
			{
				return (DistributedVirtualSwitch_LinkedView)this._linkedView;
			}
		}
		public DistributedVirtualSwitch(IVimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public string[] FetchDVPortKeys(DistributedVirtualSwitchPortCriteria criteria)
		{
			string[] fetchDVPortKeysResponse;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				FetchDVPortKeysRequestType fetchDVPortKeysRequestType = new FetchDVPortKeysRequestType();
				fetchDVPortKeysRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				fetchDVPortKeysRequestType.criteria = (VimApi_65.DistributedVirtualSwitchPortCriteria)VIConvert.ToWsdlType(criteria);
				fetchDVPortKeysResponse = this.VimServiceProxy.FetchDVPortKeys(new FetchDVPortKeysRequest(fetchDVPortKeysRequestType)).FetchDVPortKeysResponse1;
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return fetchDVPortKeysResponse;
		}
		public DistributedVirtualPort[] FetchDVPorts(DistributedVirtualSwitchPortCriteria criteria)
		{
			DistributedVirtualPort[] result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				FetchDVPortsRequestType fetchDVPortsRequestType = new FetchDVPortsRequestType();
				fetchDVPortsRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				fetchDVPortsRequestType.criteria = (VimApi_65.DistributedVirtualSwitchPortCriteria)VIConvert.ToWsdlType(criteria);
				result = (DistributedVirtualPort[])VIConvert.ToVim(this.VimServiceProxy.FetchDVPorts(new FetchDVPortsRequest(fetchDVPortsRequestType)).FetchDVPortsResponse1);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public int[] QueryUsedVlanIdInDvs()
		{
			int[] queryUsedVlanIdInDvsResponse;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				QueryUsedVlanIdInDvsRequestType queryUsedVlanIdInDvsRequestType = new QueryUsedVlanIdInDvsRequestType();
				queryUsedVlanIdInDvsRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				queryUsedVlanIdInDvsResponse = this.VimServiceProxy.QueryUsedVlanIdInDvs(new QueryUsedVlanIdInDvsRequest(queryUsedVlanIdInDvsRequestType)).QueryUsedVlanIdInDvsResponse1;
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return queryUsedVlanIdInDvsResponse;
		}
		public ManagedObjectReference ReconfigureDvs_Task(DVSConfigSpec spec)
		{
			ManagedObjectReference result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				ReconfigureDvsRequestType reconfigureDvsRequestType = new ReconfigureDvsRequestType();
				reconfigureDvsRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				reconfigureDvsRequestType.spec = (VimApi_65.DVSConfigSpec)VIConvert.ToWsdlType(spec);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.ReconfigureDvs_Task(new ReconfigureDvs_TaskRequest(reconfigureDvsRequestType)).ReconfigureDvs_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void ReconfigureDvs(DVSConfigSpec spec)
		{
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				ManagedObjectReference taskReference = this.ReconfigureDvs_Task(spec);
				this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public ManagedObjectReference PerformDvsProductSpecOperation_Task(string operation, DistributedVirtualSwitchProductSpec productSpec)
		{
			ManagedObjectReference result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				PerformDvsProductSpecOperationRequestType performDvsProductSpecOperationRequestType = new PerformDvsProductSpecOperationRequestType();
				performDvsProductSpecOperationRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				performDvsProductSpecOperationRequestType.operation = operation;
				performDvsProductSpecOperationRequestType.productSpec = (VimApi_65.DistributedVirtualSwitchProductSpec)VIConvert.ToWsdlType(productSpec);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.PerformDvsProductSpecOperation_Task(new PerformDvsProductSpecOperation_TaskRequest(performDvsProductSpecOperationRequestType)).PerformDvsProductSpecOperation_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void PerformDvsProductSpecOperation(string operation, DistributedVirtualSwitchProductSpec productSpec)
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				ManagedObjectReference taskReference = this.PerformDvsProductSpecOperation_Task(operation, productSpec);
				this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public ManagedObjectReference MergeDvs_Task(ManagedObjectReference dvs)
		{
			ManagedObjectReference result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				MergeDvsRequestType mergeDvsRequestType = new MergeDvsRequestType();
				mergeDvsRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				mergeDvsRequestType.dvs = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(dvs);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.MergeDvs_Task(new MergeDvs_TaskRequest(mergeDvsRequestType)).MergeDvs_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void MergeDvs(ManagedObjectReference dvs)
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				ManagedObjectReference taskReference = this.MergeDvs_Task(dvs);
				this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public ManagedObjectReference AddDVPortgroup_Task(DVPortgroupConfigSpec[] spec)
		{
			ManagedObjectReference result;
			try
			{	
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				AddDVPortgroupRequestType addDVPortgroupRequestType = new AddDVPortgroupRequestType();
				addDVPortgroupRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				addDVPortgroupRequestType.spec = (VimApi_65.DVPortgroupConfigSpec[])VIConvert.ToWsdlType(spec);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.AddDVPortgroup_Task(new AddDVPortgroup_TaskRequest(addDVPortgroupRequestType)).AddDVPortgroup_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void AddDVPortgroup(DVPortgroupConfigSpec[] spec)
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				ManagedObjectReference taskReference = this.AddDVPortgroup_Task(spec);
				this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public ManagedObjectReference MoveDVPort_Task(string[] portKey, string destinationPortgroupKey)
		{
			ManagedObjectReference result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				MoveDVPortRequestType moveDVPortRequestType = new MoveDVPortRequestType();
				moveDVPortRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				moveDVPortRequestType.portKey = portKey;
				moveDVPortRequestType.destinationPortgroupKey = destinationPortgroupKey;
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.MoveDVPort_Task(new MoveDVPort_TaskRequest(moveDVPortRequestType)).MoveDVPort_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void MoveDVPort(string[] portKey, string destinationPortgroupKey)
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				ManagedObjectReference taskReference = this.MoveDVPort_Task(portKey, destinationPortgroupKey);
				this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void UpdateDvsCapability(DVSCapability capability)
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				UpdateDvsCapabilityRequestType updateDvsCapabilityRequestType = new UpdateDvsCapabilityRequestType();
				updateDvsCapabilityRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				updateDvsCapabilityRequestType.capability = (VimApi_65.DVSCapability)VIConvert.ToWsdlType(capability);
				this.VimServiceProxy.UpdateDvsCapability(new UpdateDvsCapabilityRequest(updateDvsCapabilityRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public ManagedObjectReference ReconfigureDVPort_Task(DVPortConfigSpec[] port)
		{
			ManagedObjectReference result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				ReconfigureDVPortRequestType reconfigureDVPortRequestType = new ReconfigureDVPortRequestType();
				reconfigureDVPortRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				reconfigureDVPortRequestType.port = (VimApi_65.DVPortConfigSpec[])VIConvert.ToWsdlType(port);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.ReconfigureDVPort_Task(new ReconfigureDVPort_TaskRequest(reconfigureDVPortRequestType)).ReconfigureDVPort_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void ReconfigureDVPort(DVPortConfigSpec[] port)
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				ManagedObjectReference taskReference = this.ReconfigureDVPort_Task(port);
				this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void RefreshDVPortState(string[] portKeys)
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				RefreshDVPortStateRequestType refreshDVPortStateRequestType = new RefreshDVPortStateRequestType();
				refreshDVPortStateRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				refreshDVPortStateRequestType.portKeys = portKeys;
				this.VimServiceProxy.RefreshDVPortState(new RefreshDVPortStateRequest(refreshDVPortStateRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public ManagedObjectReference RectifyDvsHost_Task(ManagedObjectReference[] hosts)
		{
			ManagedObjectReference result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				RectifyDvsHostRequestType rectifyDvsHostRequestType = new RectifyDvsHostRequestType();
				rectifyDvsHostRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				rectifyDvsHostRequestType.hosts = (VimApi_65.ManagedObjectReference[])VIConvert.ToWsdlType(hosts);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.RectifyDvsHost_Task(new RectifyDvsHost_TaskRequest(rectifyDvsHostRequestType)).RectifyDvsHost_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void RectifyDvsHost(ManagedObjectReference[] hosts)
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				ManagedObjectReference taskReference = this.RectifyDvsHost_Task(hosts);
				this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void UpdateNetworkResourcePool(DVSNetworkResourcePoolConfigSpec[] configSpec)
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim41);
				UpdateNetworkResourcePoolRequestType updateNetworkResourcePoolRequestType = new UpdateNetworkResourcePoolRequestType();
				updateNetworkResourcePoolRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				updateNetworkResourcePoolRequestType.configSpec = (VimApi_65.DVSNetworkResourcePoolConfigSpec[])VIConvert.ToWsdlType(configSpec);
				this.VimServiceProxy.UpdateNetworkResourcePool(new UpdateNetworkResourcePoolRequest(updateNetworkResourcePoolRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void AddNetworkResourcePool(DVSNetworkResourcePoolConfigSpec[] configSpec)
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim50);
				AddNetworkResourcePoolRequestType addNetworkResourcePoolRequestType = new AddNetworkResourcePoolRequestType();
				addNetworkResourcePoolRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				addNetworkResourcePoolRequestType.configSpec = (VimApi_65.DVSNetworkResourcePoolConfigSpec[])VIConvert.ToWsdlType(configSpec);
				this.VimServiceProxy.AddNetworkResourcePool(new AddNetworkResourcePoolRequest(addNetworkResourcePoolRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void RemoveNetworkResourcePool(string[] key)
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim50);
				RemoveNetworkResourcePoolRequestType removeNetworkResourcePoolRequestType = new RemoveNetworkResourcePoolRequestType();
				removeNetworkResourcePoolRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				removeNetworkResourcePoolRequestType.key = key;
				this.VimServiceProxy.RemoveNetworkResourcePool(new RemoveNetworkResourcePoolRequest(removeNetworkResourcePoolRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public ManagedObjectReference DvsReconfigureVmVnicNetworkResourcePool_Task(DvsVmVnicResourcePoolConfigSpec[] configSpec)
		{
			ManagedObjectReference result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim60);
				DvsReconfigureVmVnicNetworkResourcePoolRequestType dvsReconfigureVmVnicNetworkResourcePoolRequestType = new DvsReconfigureVmVnicNetworkResourcePoolRequestType();
				dvsReconfigureVmVnicNetworkResourcePoolRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				dvsReconfigureVmVnicNetworkResourcePoolRequestType.configSpec = (VimApi_65.DvsVmVnicResourcePoolConfigSpec[])VIConvert.ToWsdlType(configSpec);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.DvsReconfigureVmVnicNetworkResourcePool_Task(new DvsReconfigureVmVnicNetworkResourcePool_TaskRequest(dvsReconfigureVmVnicNetworkResourcePoolRequestType)).DvsReconfigureVmVnicNetworkResourcePool_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void DvsReconfigureVmVnicNetworkResourcePool(DvsVmVnicResourcePoolConfigSpec[] configSpec)
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim60);
				ManagedObjectReference taskReference = this.DvsReconfigureVmVnicNetworkResourcePool_Task(configSpec);
				this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void EnableNetworkResourceManagement(bool enable)
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim41);
				EnableNetworkResourceManagementRequestType enableNetworkResourceManagementRequestType = new EnableNetworkResourceManagementRequestType();
				enableNetworkResourceManagementRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				enableNetworkResourceManagementRequestType.enable = enable;
				this.VimServiceProxy.EnableNetworkResourceManagement(new EnableNetworkResourceManagementRequest(enableNetworkResourceManagementRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public ManagedObjectReference DVSRollback_Task(EntityBackupConfig entityBackup)
		{
			ManagedObjectReference result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim51);
				DVSRollbackRequestType dVSRollbackRequestType = new DVSRollbackRequestType();
				dVSRollbackRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				dVSRollbackRequestType.entityBackup = (VimApi_65.EntityBackupConfig)VIConvert.ToWsdlType(entityBackup);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.DVSRollback_Task(new DVSRollback_TaskRequest(dVSRollbackRequestType)).DVSRollback_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public DVSConfigSpec DVSRollback(EntityBackupConfig entityBackup)
		{
			DVSConfigSpec result;
			try
			{	
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim51);
				ManagedObjectReference taskReference = this.DVSRollback_Task(entityBackup);
				result = (DVSConfigSpec)this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference CreateDVPortgroup_Task(DVPortgroupConfigSpec spec)
		{
			ManagedObjectReference result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim51);
				CreateDVPortgroupRequestType createDVPortgroupRequestType = new CreateDVPortgroupRequestType();
				createDVPortgroupRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				createDVPortgroupRequestType.spec = (VimApi_65.DVPortgroupConfigSpec)VIConvert.ToWsdlType(spec);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.CreateDVPortgroup_Task(new CreateDVPortgroup_TaskRequest(createDVPortgroupRequestType)).CreateDVPortgroup_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference CreateDVPortgroup(DVPortgroupConfigSpec spec)
		{
			ManagedObjectReference result;
			try
			{	
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim51);
				ManagedObjectReference taskReference = this.CreateDVPortgroup_Task(spec);
				result = (ManagedObjectReference)this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference UpdateDVSHealthCheckConfig_Task(DVSHealthCheckConfig[] healthCheckConfig)
		{
			ManagedObjectReference result;
			try
			{	
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim51);
				UpdateDVSHealthCheckConfigRequestType updateDVSHealthCheckConfigRequestType = new UpdateDVSHealthCheckConfigRequestType();
				updateDVSHealthCheckConfigRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				updateDVSHealthCheckConfigRequestType.healthCheckConfig = (VimApi_65.DVSHealthCheckConfig[])VIConvert.ToWsdlType(healthCheckConfig);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.UpdateDVSHealthCheckConfig_Task(new UpdateDVSHealthCheckConfig_TaskRequest(updateDVSHealthCheckConfigRequestType)).UpdateDVSHealthCheckConfig_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void UpdateDVSHealthCheckConfig(DVSHealthCheckConfig[] healthCheckConfig)
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim51);
				ManagedObjectReference taskReference = this.UpdateDVSHealthCheckConfig_Task(healthCheckConfig);
				this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public ManagedObjectReference LookupDvPortGroup(string portgroupKey)
		{
			ManagedObjectReference result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim51);
				LookupDvPortGroupRequestType lookupDvPortGroupRequestType = new LookupDvPortGroupRequestType();
				lookupDvPortGroupRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				lookupDvPortGroupRequestType.portgroupKey = portgroupKey;
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.LookupDvPortGroup(new LookupDvPortGroupRequest(lookupDvPortGroupRequestType)).LookupDvPortGroupResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
	}
}
