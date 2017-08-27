using System;
using System.ServiceModel;
using VimApi_65;
namespace EnvironmentAssessment.Common.VimApi
{
	public class VsanUpgradeSystem : ViewBase
	{
		public VsanUpgradeSystem(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public VsanUpgradeSystemPreflightCheckResult PerformVsanUpgradePreflightCheck(ManagedObjectReference cluster, bool? downgradeFormat)
		{
			VsanUpgradeSystemPreflightCheckResult result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim60);
				PerformVsanUpgradePreflightCheckRequestType performVsanUpgradePreflightCheckRequestType = new PerformVsanUpgradePreflightCheckRequestType();
				performVsanUpgradePreflightCheckRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				performVsanUpgradePreflightCheckRequestType.cluster = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(cluster);
				performVsanUpgradePreflightCheckRequestType.downgradeFormat = downgradeFormat.GetValueOrDefault();
				performVsanUpgradePreflightCheckRequestType.downgradeFormatSpecified = downgradeFormat.HasValue;
				result = (VsanUpgradeSystemPreflightCheckResult)VIConvert.ToVim(this.VimServiceProxy.PerformVsanUpgradePreflightCheck(new PerformVsanUpgradePreflightCheckRequest(performVsanUpgradePreflightCheckRequestType)).PerformVsanUpgradePreflightCheckResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public VsanUpgradeSystemUpgradeStatus QueryVsanUpgradeStatus(ManagedObjectReference cluster)
		{
			VsanUpgradeSystemUpgradeStatus result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim60);
				QueryVsanUpgradeStatusRequestType queryVsanUpgradeStatusRequestType = new QueryVsanUpgradeStatusRequestType();
				queryVsanUpgradeStatusRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				queryVsanUpgradeStatusRequestType.cluster = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(cluster);
				result = (VsanUpgradeSystemUpgradeStatus)VIConvert.ToVim(this.VimServiceProxy.QueryVsanUpgradeStatus(new QueryVsanUpgradeStatusRequest(queryVsanUpgradeStatusRequestType)).QueryVsanUpgradeStatusResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference PerformVsanUpgrade_Task(ManagedObjectReference cluster, bool? performObjectUpgrade, bool? downgradeFormat, bool? allowReducedRedundancy, ManagedObjectReference[] excludeHosts)
		{
			ManagedObjectReference result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim60);
				PerformVsanUpgradeRequestType performVsanUpgradeRequestType = new PerformVsanUpgradeRequestType();
				performVsanUpgradeRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				performVsanUpgradeRequestType.cluster = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(cluster);
				performVsanUpgradeRequestType.performObjectUpgrade = performObjectUpgrade.GetValueOrDefault();
				performVsanUpgradeRequestType.performObjectUpgradeSpecified = performObjectUpgrade.HasValue;
				performVsanUpgradeRequestType.downgradeFormat = downgradeFormat.GetValueOrDefault();
				performVsanUpgradeRequestType.downgradeFormatSpecified = downgradeFormat.HasValue;
				performVsanUpgradeRequestType.allowReducedRedundancy = allowReducedRedundancy.GetValueOrDefault();
				performVsanUpgradeRequestType.allowReducedRedundancySpecified = allowReducedRedundancy.HasValue;
				performVsanUpgradeRequestType.excludeHosts = (VimApi_65.ManagedObjectReference[])VIConvert.ToWsdlType(excludeHosts);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.PerformVsanUpgrade_Task(new PerformVsanUpgrade_TaskRequest(performVsanUpgradeRequestType)).PerformVsanUpgrade_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public VsanUpgradeSystemUpgradeStatus PerformVsanUpgrade(ManagedObjectReference cluster, bool? performObjectUpgrade, bool? downgradeFormat, bool? allowReducedRedundancy, ManagedObjectReference[] excludeHosts)
		{
			VsanUpgradeSystemUpgradeStatus result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim60);
				ManagedObjectReference taskReference = this.PerformVsanUpgrade_Task(cluster, performObjectUpgrade, downgradeFormat, allowReducedRedundancy, excludeHosts);
				result = (VsanUpgradeSystemUpgradeStatus)this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
	}
}
