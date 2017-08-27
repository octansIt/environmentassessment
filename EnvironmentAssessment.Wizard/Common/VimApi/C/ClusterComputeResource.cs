
using System.ServiceModel;
using VimApi_65;namespace EnvironmentAssessment.Common.VimApi
{
	public class ClusterComputeResource : ComputeResource
	{
		protected ClusterConfigInfo _configuration;
		protected ClusterRecommendation[] _recommendation;
		protected ClusterDrsRecommendation[] _drsRecommendation;
		protected ClusterDrsMigration[] _migrationHistory;
		protected ClusterActionHistory[] _actionHistory;
		protected ClusterDrsFaults[] _drsFault;
		public ClusterConfigInfo Configuration
		{
			get
			{
				return this._configuration;
			}
		}
		public ClusterRecommendation[] Recommendation
		{
			get
			{
				return this._recommendation;
			}
		}
		public ClusterDrsRecommendation[] DrsRecommendation
		{
			get
			{
				return this._drsRecommendation;
			}
		}
		public ClusterDrsMigration[] MigrationHistory
		{
			get
			{
				return this._migrationHistory;
			}
		}
		public ClusterActionHistory[] ActionHistory
		{
			get
			{
				return this._actionHistory;
			}
		}
		public ClusterDrsFaults[] DrsFault
		{
			get
			{
				return this._drsFault;
			}
		}
		public new ClusterComputeResource_LinkedView LinkedView
		{
			get
			{
				return (ClusterComputeResource_LinkedView)this._linkedView;
			}
		}
		public ClusterComputeResource(IVimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public ManagedObjectReference ReconfigureCluster_Task(ClusterConfigSpec spec, bool modify)
		{
			ManagedObjectReference result;
			try
			{
				ReconfigureClusterRequestType reconfigureClusterRequestType = new ReconfigureClusterRequestType();
				reconfigureClusterRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				reconfigureClusterRequestType.spec = (VimApi_65.ClusterConfigSpec)VIConvert.ToWsdlType(spec);
				reconfigureClusterRequestType.modify = modify;
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.ReconfigureCluster_Task(new ReconfigureCluster_TaskRequest(reconfigureClusterRequestType)).ReconfigureCluster_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void ReconfigureCluster(ClusterConfigSpec spec, bool modify)
		{
			try
			{
				ManagedObjectReference taskReference = this.ReconfigureCluster_Task(spec, modify);
				this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void ApplyRecommendation(string key)
		{
			try
			{
				ApplyRecommendationRequestType applyRecommendationRequestType = new ApplyRecommendationRequestType();
				applyRecommendationRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				applyRecommendationRequestType.key = key;
				this.VimServiceProxy.ApplyRecommendation(new ApplyRecommendationRequest(applyRecommendationRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void CancelRecommendation(string key)
		{
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim41);
                CancelRecommendationRequestType cancelRecommendationRequestType = new CancelRecommendationRequestType();
				cancelRecommendationRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				cancelRecommendationRequestType.key = key;
				this.VimServiceProxy.CancelRecommendation(new CancelRecommendationRequest(cancelRecommendationRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public ClusterHostRecommendation[] RecommendHostsForVm(ManagedObjectReference vm, ManagedObjectReference pool)
		{
			ClusterHostRecommendation[] result;
			try
			{
				RecommendHostsForVmRequestType recommendHostsForVmRequestType = new RecommendHostsForVmRequestType();
				recommendHostsForVmRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				recommendHostsForVmRequestType.vm = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(vm);
				recommendHostsForVmRequestType.pool = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(pool);
				result = (ClusterHostRecommendation[])VIConvert.ToVim(this.VimServiceProxy.RecommendHostsForVm(new RecommendHostsForVmRequest(recommendHostsForVmRequestType)).RecommendHostsForVmResponse1);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference AddHost_Task(HostConnectSpec spec, bool asConnected, ManagedObjectReference resourcePool, string license)
		{
			ManagedObjectReference result;
			try
			{
				AddHostRequestType addHostRequestType = new AddHostRequestType();
				addHostRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				addHostRequestType.spec = (VimApi_65.HostConnectSpec)VIConvert.ToWsdlType(spec);
				addHostRequestType.asConnected = asConnected;
				addHostRequestType.resourcePool = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(resourcePool);
				addHostRequestType.license = license;
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.AddHost_Task(new AddHost_TaskRequest(addHostRequestType)).AddHost_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference AddHost(HostConnectSpec spec, bool asConnected, ManagedObjectReference resourcePool, string license)
		{
			ManagedObjectReference result;
			try
			{
				ManagedObjectReference taskReference = this.AddHost_Task(spec, asConnected, resourcePool, license);
				result = (ManagedObjectReference)this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference MoveInto_Task(ManagedObjectReference[] host)
		{
			ManagedObjectReference result;
			try
			{
				MoveIntoRequestType moveIntoRequestType = new MoveIntoRequestType();
				moveIntoRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				moveIntoRequestType.host = (VimApi_65.ManagedObjectReference[])VIConvert.ToWsdlType(host);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.MoveInto_Task(new MoveInto_TaskRequest(moveIntoRequestType)).MoveInto_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void MoveInto(ManagedObjectReference[] host)
		{
			try
			{
				ManagedObjectReference taskReference = this.MoveInto_Task(host);
				this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public ManagedObjectReference MoveHostInto_Task(ManagedObjectReference host, ManagedObjectReference resourcePool)
		{
			ManagedObjectReference result;
			try
			{
				MoveHostIntoRequestType moveHostIntoRequestType = new MoveHostIntoRequestType();
				moveHostIntoRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				moveHostIntoRequestType.host = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(host);
				moveHostIntoRequestType.resourcePool = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(resourcePool);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.MoveHostInto_Task(new MoveHostInto_TaskRequest(moveHostIntoRequestType)).MoveHostInto_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void MoveHostInto(ManagedObjectReference host, ManagedObjectReference resourcePool)
		{
			try
			{
				ManagedObjectReference taskReference = this.MoveHostInto_Task(host, resourcePool);
				this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void RefreshRecommendation()
		{
			try
			{
				RefreshRecommendationRequestType refreshRecommendationRequestType = new RefreshRecommendationRequestType();
				refreshRecommendationRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				this.VimServiceProxy.RefreshRecommendation(new RefreshRecommendationRequest(refreshRecommendationRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public ManagedObjectReference EvcManager()
		{
			ManagedObjectReference result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim60);
				EvcManagerRequestType evcManagerRequestType = new EvcManagerRequestType();
				evcManagerRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.EvcManager(new EvcManagerRequest(evcManagerRequestType)).EvcManagerResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ClusterDasAdvancedRuntimeInfo RetrieveDasAdvancedRuntimeInfo()
		{
			ClusterDasAdvancedRuntimeInfo result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
                RetrieveDasAdvancedRuntimeInfoRequestType retrieveDasAdvancedRuntimeInfoRequestType = new RetrieveDasAdvancedRuntimeInfoRequestType();
				retrieveDasAdvancedRuntimeInfoRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				result = (ClusterDasAdvancedRuntimeInfo)VIConvert.ToVim(this.VimServiceProxy.RetrieveDasAdvancedRuntimeInfo(new RetrieveDasAdvancedRuntimeInfoRequest(retrieveDasAdvancedRuntimeInfoRequestType)).RetrieveDasAdvancedRuntimeInfoResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ClusterEnterMaintenanceResult ClusterEnterMaintenanceMode(ManagedObjectReference[] host, OptionValue[] option)
		{
			ClusterEnterMaintenanceResult result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim50);
                ClusterEnterMaintenanceModeRequestType clusterEnterMaintenanceModeRequestType = new ClusterEnterMaintenanceModeRequestType();
				clusterEnterMaintenanceModeRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				clusterEnterMaintenanceModeRequestType.host = (VimApi_65.ManagedObjectReference[])VIConvert.ToWsdlType(host);
				clusterEnterMaintenanceModeRequestType.option = (VimApi_65.OptionValue[])VIConvert.ToWsdlType(option);
				result = (ClusterEnterMaintenanceResult)VIConvert.ToVim(this.VimServiceProxy.ClusterEnterMaintenanceMode(new ClusterEnterMaintenanceModeRequest(clusterEnterMaintenanceModeRequestType)).ClusterEnterMaintenanceModeResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public PlacementResult PlaceVm(PlacementSpec placementSpec)
		{
			PlacementResult result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim60);
                PlaceVmRequestType placeVmRequestType = new PlaceVmRequestType();
				placeVmRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				placeVmRequestType.placementSpec = (VimApi_65.PlacementSpec)VIConvert.ToWsdlType(placementSpec);
				result = (PlacementResult)VIConvert.ToVim(this.VimServiceProxy.PlaceVm(new PlaceVmRequest(placeVmRequestType)).PlaceVmResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ClusterRuleInfo[] FindRulesForVm(ManagedObjectReference vm)
		{
			ClusterRuleInfo[] result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim60);
                FindRulesForVmRequestType findRulesForVmRequestType = new FindRulesForVmRequestType();
				findRulesForVmRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				findRulesForVmRequestType.vm = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(vm);
				result = (ClusterRuleInfo[])VIConvert.ToVim(this.VimServiceProxy.FindRulesForVm(new FindRulesForVmRequest(findRulesForVmRequestType)).FindRulesForVmResponse1);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference StampAllRulesWithUuid_Task()
		{
			ManagedObjectReference result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim60);
                StampAllRulesWithUuidRequestType stampAllRulesWithUuidRequestType = new StampAllRulesWithUuidRequestType();
				stampAllRulesWithUuidRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.StampAllRulesWithUuid_Task(new StampAllRulesWithUuid_TaskRequest(stampAllRulesWithUuidRequestType)).StampAllRulesWithUuid_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void StampAllRulesWithUuid()
		{
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim60);
                ManagedObjectReference taskReference = this.StampAllRulesWithUuid_Task();
				this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public ClusterResourceUsageSummary GetResourceUsage()
		{
			ClusterResourceUsageSummary result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim60);
                GetResourceUsageRequestType getResourceUsageRequestType = new GetResourceUsageRequestType();
				getResourceUsageRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				result = (ClusterResourceUsageSummary)VIConvert.ToVim(this.VimServiceProxy.GetResourceUsage(new GetResourceUsageRequest(getResourceUsageRequestType)).GetResourceUsageResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
	}
}
