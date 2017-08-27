using System.ServiceModel;
using VimApi_65;
namespace EnvironmentAssessment.Common.VimApi
{
	public class HostVsanInternalSystem : ViewBase
	{
		public HostVsanInternalSystem(IVimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public string QueryCmmds(HostVsanInternalSystemCmmdsQuery[] queries)
		{
			string returnval;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim55);
				QueryCmmdsRequestType queryCmmdsRequestType = new QueryCmmdsRequestType();
				queryCmmdsRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				queryCmmdsRequestType.queries = (VimApi_65.HostVsanInternalSystemCmmdsQuery[])VIConvert.ToWsdlType(queries);
				returnval = this.VimServiceProxy.QueryCmmds(new QueryCmmdsRequest(queryCmmdsRequestType)).QueryCmmdsResponse.returnval;
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return returnval;
		}
		public string QueryPhysicalVsanDisks(string[] props)
		{
			string returnval;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim55);
				QueryPhysicalVsanDisksRequestType queryPhysicalVsanDisksRequestType = new QueryPhysicalVsanDisksRequestType();
				queryPhysicalVsanDisksRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				queryPhysicalVsanDisksRequestType.props = props;
				returnval = this.VimServiceProxy.QueryPhysicalVsanDisks(new QueryPhysicalVsanDisksRequest(queryPhysicalVsanDisksRequestType)).QueryPhysicalVsanDisksResponse.returnval;
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return returnval;
		}
		public string QueryVsanObjects(string[] uuids)
		{
			string returnval;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim55);
				QueryVsanObjectsRequestType queryVsanObjectsRequestType = new QueryVsanObjectsRequestType();
				queryVsanObjectsRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				queryVsanObjectsRequestType.uuids = uuids;
				returnval = this.VimServiceProxy.QueryVsanObjects(new QueryVsanObjectsRequest(queryVsanObjectsRequestType)).QueryVsanObjectsResponse.returnval;
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return returnval;
		}
		public string QueryObjectsOnPhysicalVsanDisk(string[] disks)
		{
			string returnval;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim55);
				QueryObjectsOnPhysicalVsanDiskRequestType queryObjectsOnPhysicalVsanDiskRequestType = new QueryObjectsOnPhysicalVsanDiskRequestType();
				queryObjectsOnPhysicalVsanDiskRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				queryObjectsOnPhysicalVsanDiskRequestType.disks = disks;
				returnval = this.VimServiceProxy.QueryObjectsOnPhysicalVsanDisk(new QueryObjectsOnPhysicalVsanDiskRequest(queryObjectsOnPhysicalVsanDiskRequestType)).QueryObjectsOnPhysicalVsanDiskResponse.returnval;
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return returnval;
		}
		public string[] AbdicateDomOwnership(string[] uuids)
		{
			string[] abdicateDomOwnershipResponse;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim60);
				AbdicateDomOwnershipRequestType abdicateDomOwnershipRequestType = new AbdicateDomOwnershipRequestType();
				abdicateDomOwnershipRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				abdicateDomOwnershipRequestType.uuids = uuids;
				abdicateDomOwnershipResponse = this.VimServiceProxy.AbdicateDomOwnership(new AbdicateDomOwnershipRequest(abdicateDomOwnershipRequestType)).AbdicateDomOwnershipResponse1;
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return abdicateDomOwnershipResponse;
		}
		public string QueryVsanStatistics(string[] labels)
		{
			string returnval;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim60);
				QueryVsanStatisticsRequestType queryVsanStatisticsRequestType = new QueryVsanStatisticsRequestType();
				queryVsanStatisticsRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				queryVsanStatisticsRequestType.labels = labels;
				returnval = this.VimServiceProxy.QueryVsanStatistics(new QueryVsanStatisticsRequest(queryVsanStatisticsRequestType)).QueryVsanStatisticsResponse.returnval;
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return returnval;
		}
		public void ReconfigureDomObject(string uuid, string policy)
		{
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim60);
				ReconfigureDomObjectRequestType reconfigureDomObjectRequestType = new ReconfigureDomObjectRequestType();
				reconfigureDomObjectRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				reconfigureDomObjectRequestType.uuid = uuid;
				reconfigureDomObjectRequestType.policy = policy;
				this.VimServiceProxy.ReconfigureDomObject(new ReconfigureDomObjectRequest(reconfigureDomObjectRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public string QuerySyncingVsanObjects(string[] uuids)
		{
			string returnval;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim60);
				QuerySyncingVsanObjectsRequestType querySyncingVsanObjectsRequestType = new QuerySyncingVsanObjectsRequestType();
				querySyncingVsanObjectsRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				querySyncingVsanObjectsRequestType.uuids = uuids;
				returnval = this.VimServiceProxy.QuerySyncingVsanObjects(new QuerySyncingVsanObjectsRequest(querySyncingVsanObjectsRequestType)).QuerySyncingVsanObjectsResponse.returnval;
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return returnval;
		}
		public HostVsanInternalSystemVsanPhysicalDiskDiagnosticsResult[] RunVsanPhysicalDiskDiagnostics(string[] disks)
		{
			HostVsanInternalSystemVsanPhysicalDiskDiagnosticsResult[] result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim60);
				RunVsanPhysicalDiskDiagnosticsRequestType runVsanPhysicalDiskDiagnosticsRequestType = new RunVsanPhysicalDiskDiagnosticsRequestType();
				runVsanPhysicalDiskDiagnosticsRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				runVsanPhysicalDiskDiagnosticsRequestType.disks = disks;
				result = (HostVsanInternalSystemVsanPhysicalDiskDiagnosticsResult[])VIConvert.ToVim(this.VimServiceProxy.RunVsanPhysicalDiskDiagnostics(new RunVsanPhysicalDiskDiagnosticsRequest(runVsanPhysicalDiskDiagnosticsRequestType)).RunVsanPhysicalDiskDiagnosticsResponse1);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public string GetVsanObjExtAttrs(string[] uuids)
		{
			string returnval;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim60);
				GetVsanObjExtAttrsRequestType getVsanObjExtAttrsRequestType = new GetVsanObjExtAttrsRequestType();
				getVsanObjExtAttrsRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				getVsanObjExtAttrsRequestType.uuids = uuids;
				returnval = this.VimServiceProxy.GetVsanObjExtAttrs(new GetVsanObjExtAttrsRequest(getVsanObjExtAttrsRequestType)).GetVsanObjExtAttrsResponse.returnval;
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return returnval;
		}
		public VsanPolicySatisfiability[] ReconfigurationSatisfiable(VsanPolicyChangeBatch[] pcbs, bool? ignoreSatisfiability)
		{
			VsanPolicySatisfiability[] result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim60);
				ReconfigurationSatisfiableRequestType reconfigurationSatisfiableRequestType = new ReconfigurationSatisfiableRequestType();
				reconfigurationSatisfiableRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				reconfigurationSatisfiableRequestType.pcbs = (VimApi_65.VsanPolicyChangeBatch[])VIConvert.ToWsdlType(pcbs);
				reconfigurationSatisfiableRequestType.ignoreSatisfiability = ignoreSatisfiability.GetValueOrDefault();
				reconfigurationSatisfiableRequestType.ignoreSatisfiabilitySpecified = ignoreSatisfiability.HasValue;
				result = (VsanPolicySatisfiability[])VIConvert.ToVim(this.VimServiceProxy.ReconfigurationSatisfiable(new ReconfigurationSatisfiableRequest(reconfigurationSatisfiableRequestType)).ReconfigurationSatisfiableResponse1);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public VsanPolicySatisfiability[] CanProvisionObjects(VsanNewPolicyBatch[] npbs, bool? ignoreSatisfiability)
		{
			VsanPolicySatisfiability[] result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim60);
				CanProvisionObjectsRequestType canProvisionObjectsRequestType = new CanProvisionObjectsRequestType();
				canProvisionObjectsRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				canProvisionObjectsRequestType.npbs = (VimApi_65.VsanNewPolicyBatch[])VIConvert.ToWsdlType(npbs);
				canProvisionObjectsRequestType.ignoreSatisfiability = ignoreSatisfiability.GetValueOrDefault();
				canProvisionObjectsRequestType.ignoreSatisfiabilitySpecified = ignoreSatisfiability.HasValue;
				result = (VsanPolicySatisfiability[])VIConvert.ToVim(this.VimServiceProxy.CanProvisionObjects(new CanProvisionObjectsRequest(canProvisionObjectsRequestType)).CanProvisionObjectsResponse1);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public HostVsanInternalSystemDeleteVsanObjectsResult[] DeleteVsanObjects(string[] uuids, bool? force)
		{
			HostVsanInternalSystemDeleteVsanObjectsResult[] result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim60);
				DeleteVsanObjectsRequestType deleteVsanObjectsRequestType = new DeleteVsanObjectsRequestType();
				deleteVsanObjectsRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				deleteVsanObjectsRequestType.uuids = uuids;
				deleteVsanObjectsRequestType.force = force.GetValueOrDefault();
				deleteVsanObjectsRequestType.forceSpecified = force.HasValue;
				result = (HostVsanInternalSystemDeleteVsanObjectsResult[])VIConvert.ToVim(this.VimServiceProxy.DeleteVsanObjects(new DeleteVsanObjectsRequest(deleteVsanObjectsRequestType)).DeleteVsanObjectsResponse1);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public HostVsanInternalSystemVsanObjectOperationResult[] UpgradeVsanObjects(string[] uuids, int newVersion)
		{
			HostVsanInternalSystemVsanObjectOperationResult[] result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim60);
				UpgradeVsanObjectsRequestType upgradeVsanObjectsRequestType = new UpgradeVsanObjectsRequestType();
				upgradeVsanObjectsRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				upgradeVsanObjectsRequestType.uuids = uuids;
				upgradeVsanObjectsRequestType.newVersion = newVersion;
				result = (HostVsanInternalSystemVsanObjectOperationResult[])VIConvert.ToVim(this.VimServiceProxy.UpgradeVsanObjects(new UpgradeVsanObjectsRequest(upgradeVsanObjectsRequestType)).UpgradeVsanObjectsResponse1);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public string[] QueryVsanObjectUuidsByFilter(string[] uuids, int? limit, int? version)
		{
			string[] queryVsanObjectUuidsByFilterResponse;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim60);
				QueryVsanObjectUuidsByFilterRequestType queryVsanObjectUuidsByFilterRequestType = new QueryVsanObjectUuidsByFilterRequestType();
				queryVsanObjectUuidsByFilterRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				queryVsanObjectUuidsByFilterRequestType.uuids = uuids;
				queryVsanObjectUuidsByFilterRequestType.limit = limit.GetValueOrDefault();
				queryVsanObjectUuidsByFilterRequestType.limitSpecified = limit.HasValue;
				queryVsanObjectUuidsByFilterRequestType.version = version.GetValueOrDefault();
				queryVsanObjectUuidsByFilterRequestType.versionSpecified = version.HasValue;
				queryVsanObjectUuidsByFilterResponse = this.VimServiceProxy.QueryVsanObjectUuidsByFilter(new QueryVsanObjectUuidsByFilterRequest(queryVsanObjectUuidsByFilterRequestType)).QueryVsanObjectUuidsByFilterResponse1;
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return queryVsanObjectUuidsByFilterResponse;
		}
	}
}
