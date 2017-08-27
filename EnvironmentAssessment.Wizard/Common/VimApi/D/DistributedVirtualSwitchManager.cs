using System;
using System.ServiceModel;
using VimApi_65;
namespace EnvironmentAssessment.Common.VimApi
{
	public class DistributedVirtualSwitchManager : ViewBase
	{
		public DistributedVirtualSwitchManager(IVimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		[Obsolete("The method QueryAvailableDvsSpec in DistributedVirtualSwitchManager is deprecated in version 5.5.")]
		public DistributedVirtualSwitchProductSpec[] QueryAvailableDvsSpec()
		{
			return this.QueryAvailableDvsSpec(null);
		}
		public DistributedVirtualSwitchProductSpec[] QueryAvailableDvsSpec(bool? recommended)
		{
			DistributedVirtualSwitchProductSpec[] result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				QueryAvailableDvsSpecRequestType queryAvailableDvsSpecRequestType = new QueryAvailableDvsSpecRequestType();
				queryAvailableDvsSpecRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				queryAvailableDvsSpecRequestType.recommended = recommended.GetValueOrDefault();
				queryAvailableDvsSpecRequestType.recommendedSpecified = recommended.HasValue;
				result = (DistributedVirtualSwitchProductSpec[])VIConvert.ToVim(this.VimServiceProxy.QueryAvailableDvsSpec(new QueryAvailableDvsSpecRequest(queryAvailableDvsSpecRequestType)).QueryAvailableDvsSpecResponse1);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference[] QueryCompatibleHostForNewDvs(ManagedObjectReference container, bool recursive, DistributedVirtualSwitchProductSpec switchProductSpec)
		{
			ManagedObjectReference[] result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				QueryCompatibleHostForNewDvsRequestType queryCompatibleHostForNewDvsRequestType = new QueryCompatibleHostForNewDvsRequestType();
				queryCompatibleHostForNewDvsRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				queryCompatibleHostForNewDvsRequestType.container = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(container);
				queryCompatibleHostForNewDvsRequestType.recursive = recursive;
				queryCompatibleHostForNewDvsRequestType.switchProductSpec = (VimApi_65.DistributedVirtualSwitchProductSpec)VIConvert.ToWsdlType(switchProductSpec);
				result = (ManagedObjectReference[])VIConvert.ToVim(this.VimServiceProxy.QueryCompatibleHostForNewDvs(new QueryCompatibleHostForNewDvsRequest(queryCompatibleHostForNewDvsRequestType)).QueryCompatibleHostForNewDvsResponse1);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference[] QueryCompatibleHostForExistingDvs(ManagedObjectReference container, bool recursive, ManagedObjectReference dvs)
		{
			ManagedObjectReference[] result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				QueryCompatibleHostForExistingDvsRequestType queryCompatibleHostForExistingDvsRequestType = new QueryCompatibleHostForExistingDvsRequestType();
				queryCompatibleHostForExistingDvsRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				queryCompatibleHostForExistingDvsRequestType.container = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(container);
				queryCompatibleHostForExistingDvsRequestType.recursive = recursive;
				queryCompatibleHostForExistingDvsRequestType.dvs = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(dvs);
				result = (ManagedObjectReference[])VIConvert.ToVim(this.VimServiceProxy.QueryCompatibleHostForExistingDvs(new QueryCompatibleHostForExistingDvsRequest(queryCompatibleHostForExistingDvsRequestType)).QueryCompatibleHostForExistingDvsResponse1);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public DistributedVirtualSwitchHostProductSpec[] QueryDvsCompatibleHostSpec(DistributedVirtualSwitchProductSpec switchProductSpec)
		{
			DistributedVirtualSwitchHostProductSpec[] result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				QueryDvsCompatibleHostSpecRequestType queryDvsCompatibleHostSpecRequestType = new QueryDvsCompatibleHostSpecRequestType();
				queryDvsCompatibleHostSpecRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				queryDvsCompatibleHostSpecRequestType.switchProductSpec = (VimApi_65.DistributedVirtualSwitchProductSpec)VIConvert.ToWsdlType(switchProductSpec);
				result = (DistributedVirtualSwitchHostProductSpec[])VIConvert.ToVim(this.VimServiceProxy.QueryDvsCompatibleHostSpec(new QueryDvsCompatibleHostSpecRequest(queryDvsCompatibleHostSpecRequestType)).QueryDvsCompatibleHostSpecResponse1);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public DVSFeatureCapability QueryDvsFeatureCapability(DistributedVirtualSwitchProductSpec switchProductSpec)
		{
			DVSFeatureCapability result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim41);
				QueryDvsFeatureCapabilityRequestType queryDvsFeatureCapabilityRequestType = new QueryDvsFeatureCapabilityRequestType();
				queryDvsFeatureCapabilityRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				queryDvsFeatureCapabilityRequestType.switchProductSpec = (VimApi_65.DistributedVirtualSwitchProductSpec)VIConvert.ToWsdlType(switchProductSpec);
				result = (DVSFeatureCapability)VIConvert.ToVim(this.VimServiceProxy.QueryDvsFeatureCapability(new QueryDvsFeatureCapabilityRequest(queryDvsFeatureCapabilityRequestType)).QueryDvsFeatureCapabilityResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference QueryDvsByUuid(string uuid)
		{
			ManagedObjectReference result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				QueryDvsByUuidRequestType queryDvsByUuidRequestType = new QueryDvsByUuidRequestType();
				queryDvsByUuidRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				queryDvsByUuidRequestType.uuid = uuid;
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.QueryDvsByUuid(new QueryDvsByUuidRequest(queryDvsByUuidRequestType)).QueryDvsByUuidResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public DVSManagerDvsConfigTarget QueryDvsConfigTarget(ManagedObjectReference host, ManagedObjectReference dvs)
		{
			DVSManagerDvsConfigTarget result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				QueryDvsConfigTargetRequestType queryDvsConfigTargetRequestType = new QueryDvsConfigTargetRequestType();
				queryDvsConfigTargetRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				queryDvsConfigTargetRequestType.host = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(host);
				queryDvsConfigTargetRequestType.dvs = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(dvs);
				result = (DVSManagerDvsConfigTarget)VIConvert.ToVim(this.VimServiceProxy.QueryDvsConfigTarget(new QueryDvsConfigTargetRequest(queryDvsConfigTargetRequestType)).QueryDvsConfigTargetResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public DistributedVirtualSwitchManagerCompatibilityResult[] QueryDvsCheckCompatibility(DistributedVirtualSwitchManagerHostContainer hostContainer, DistributedVirtualSwitchManagerDvsProductSpec dvsProductSpec, DistributedVirtualSwitchManagerHostDvsFilterSpec[] hostFilterSpec)
		{
			DistributedVirtualSwitchManagerCompatibilityResult[] result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim41);
				QueryDvsCheckCompatibilityRequestType queryDvsCheckCompatibilityRequestType = new QueryDvsCheckCompatibilityRequestType();
				queryDvsCheckCompatibilityRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				queryDvsCheckCompatibilityRequestType.hostContainer = (VimApi_65.DistributedVirtualSwitchManagerHostContainer)VIConvert.ToWsdlType(hostContainer);
				queryDvsCheckCompatibilityRequestType.dvsProductSpec = (VimApi_65.DistributedVirtualSwitchManagerDvsProductSpec)VIConvert.ToWsdlType(dvsProductSpec);
				queryDvsCheckCompatibilityRequestType.hostFilterSpec = (VimApi_65.DistributedVirtualSwitchManagerHostDvsFilterSpec[])VIConvert.ToWsdlType(hostFilterSpec);
				result = (DistributedVirtualSwitchManagerCompatibilityResult[])VIConvert.ToVim(this.VimServiceProxy.QueryDvsCheckCompatibility(new QueryDvsCheckCompatibilityRequest(queryDvsCheckCompatibilityRequestType)).QueryDvsCheckCompatibilityResponse1);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference RectifyDvsOnHost_Task(ManagedObjectReference[] hosts)
		{
			ManagedObjectReference result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim50);
				RectifyDvsOnHostRequestType rectifyDvsOnHostRequestType = new RectifyDvsOnHostRequestType();
				rectifyDvsOnHostRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				rectifyDvsOnHostRequestType.hosts = (VimApi_65.ManagedObjectReference[])VIConvert.ToWsdlType(hosts);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.RectifyDvsOnHost_Task(new RectifyDvsOnHost_TaskRequest(rectifyDvsOnHostRequestType)).RectifyDvsOnHost_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void RectifyDvsOnHost(ManagedObjectReference[] hosts)
		{
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim50);
				ManagedObjectReference taskReference = this.RectifyDvsOnHost_Task(hosts);
				this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public ManagedObjectReference DVSManagerExportEntity_Task(SelectionSet[] selectionSet)
		{
			ManagedObjectReference result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim51);
				DVSManagerExportEntityRequestType dVSManagerExportEntityRequestType = new DVSManagerExportEntityRequestType();
				dVSManagerExportEntityRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				dVSManagerExportEntityRequestType.selectionSet = (VimApi_65.SelectionSet[])VIConvert.ToWsdlType(selectionSet);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.DVSManagerExportEntity_Task(new DVSManagerExportEntity_TaskRequest(dVSManagerExportEntityRequestType)).DVSManagerExportEntity_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public EntityBackupConfig[] DVSManagerExportEntity(SelectionSet[] selectionSet)
		{
			EntityBackupConfig[] result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim51);
				ManagedObjectReference taskReference = this.DVSManagerExportEntity_Task(selectionSet);
				result = (EntityBackupConfig[])this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference DVSManagerImportEntity_Task(EntityBackupConfig[] entityBackup, string importType)
		{
			ManagedObjectReference result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim51);
				DVSManagerImportEntityRequestType dVSManagerImportEntityRequestType = new DVSManagerImportEntityRequestType();
				dVSManagerImportEntityRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				dVSManagerImportEntityRequestType.entityBackup = (VimApi_65.EntityBackupConfig[])VIConvert.ToWsdlType(entityBackup);
				dVSManagerImportEntityRequestType.importType = importType;
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.DVSManagerImportEntity_Task(new DVSManagerImportEntity_TaskRequest(dVSManagerImportEntityRequestType)).DVSManagerImportEntity_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public DistributedVirtualSwitchManagerImportResult DVSManagerImportEntity(EntityBackupConfig[] entityBackup, string importType)
		{
			DistributedVirtualSwitchManagerImportResult result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim51);
				ManagedObjectReference taskReference = this.DVSManagerImportEntity_Task(entityBackup, importType);
				result = (DistributedVirtualSwitchManagerImportResult)this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference DVSManagerLookupDvPortGroup(string switchUuid, string portgroupKey)
		{
			ManagedObjectReference result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim51);
				DVSManagerLookupDvPortGroupRequestType dVSManagerLookupDvPortGroupRequestType = new DVSManagerLookupDvPortGroupRequestType();
				dVSManagerLookupDvPortGroupRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				dVSManagerLookupDvPortGroupRequestType.switchUuid = switchUuid;
				dVSManagerLookupDvPortGroupRequestType.portgroupKey = portgroupKey;
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.DVSManagerLookupDvPortGroup(new DVSManagerLookupDvPortGroupRequest(dVSManagerLookupDvPortGroupRequestType)).DVSManagerLookupDvPortGroupResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
	}
}
