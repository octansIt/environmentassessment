using System;
using System.ServiceModel;
using VimApi_65;
namespace EnvironmentAssessment.Common.VimApi
{
	public class IoFilterManager : ViewBase
	{
		public IoFilterManager(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public ManagedObjectReference InstallIoFilter_Task(string vibUrl, ManagedObjectReference compRes)
		{
			ManagedObjectReference result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim60);
				InstallIoFilterRequestType installIoFilterRequestType = new InstallIoFilterRequestType();
				installIoFilterRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				installIoFilterRequestType.vibUrl = vibUrl;
				installIoFilterRequestType.compRes = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(compRes);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.InstallIoFilter_Task(new InstallIoFilter_TaskRequest(installIoFilterRequestType)).InstallIoFilter_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ClusterIoFilterInfo InstallIoFilter(string vibUrl, ManagedObjectReference compRes)
		{
			ClusterIoFilterInfo result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim60);
				ManagedObjectReference taskReference = this.InstallIoFilter_Task(vibUrl, compRes);
				result = (ClusterIoFilterInfo)this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference UninstallIoFilter_Task(string filterId, ManagedObjectReference compRes)
		{
			ManagedObjectReference result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim60);
				UninstallIoFilterRequestType uninstallIoFilterRequestType = new UninstallIoFilterRequestType();
				uninstallIoFilterRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				uninstallIoFilterRequestType.filterId = filterId;
				uninstallIoFilterRequestType.compRes = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(compRes);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.UninstallIoFilter_Task(new UninstallIoFilter_TaskRequest(uninstallIoFilterRequestType)).UninstallIoFilter_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void UninstallIoFilter(string filterId, ManagedObjectReference compRes)
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim60);
				ManagedObjectReference taskReference = this.UninstallIoFilter_Task(filterId, compRes);
				this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public ManagedObjectReference UpgradeIoFilter_Task(string filterId, ManagedObjectReference compRes, string vibUrl)
		{
			ManagedObjectReference result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim60);
				UpgradeIoFilterRequestType upgradeIoFilterRequestType = new UpgradeIoFilterRequestType();
				upgradeIoFilterRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				upgradeIoFilterRequestType.filterId = filterId;
				upgradeIoFilterRequestType.compRes = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(compRes);
				upgradeIoFilterRequestType.vibUrl = vibUrl;
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.UpgradeIoFilter_Task(new UpgradeIoFilter_TaskRequest(upgradeIoFilterRequestType)).UpgradeIoFilter_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ClusterIoFilterInfo UpgradeIoFilter(string filterId, ManagedObjectReference compRes, string vibUrl)
		{
			ClusterIoFilterInfo result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim60);
				ManagedObjectReference taskReference = this.UpgradeIoFilter_Task(filterId, compRes, vibUrl);
				result = (ClusterIoFilterInfo)this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public IoFilterQueryIssueResult QueryIoFilterIssues(string filterId, ManagedObjectReference compRes)
		{
			IoFilterQueryIssueResult result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim60);
				QueryIoFilterIssuesRequestType queryIoFilterIssuesRequestType = new QueryIoFilterIssuesRequestType();
				queryIoFilterIssuesRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				queryIoFilterIssuesRequestType.filterId = filterId;
				queryIoFilterIssuesRequestType.compRes = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(compRes);
				result = (IoFilterQueryIssueResult)VIConvert.ToVim(this.VimServiceProxy.QueryIoFilterIssues(new QueryIoFilterIssuesRequest(queryIoFilterIssuesRequestType)).QueryIoFilterIssuesResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ClusterIoFilterInfo[] QueryIoFilterInfo(ManagedObjectReference compRes)
		{
			ClusterIoFilterInfo[] result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim60);
				QueryIoFilterInfoRequestType queryIoFilterInfoRequestType = new QueryIoFilterInfoRequestType();
				queryIoFilterInfoRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				queryIoFilterInfoRequestType.compRes = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(compRes);
				result = (ClusterIoFilterInfo[])VIConvert.ToVim(this.VimServiceProxy.QueryIoFilterInfo(new QueryIoFilterInfoRequest(queryIoFilterInfoRequestType)).QueryIoFilterInfoResponse1);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference ResolveInstallationErrorsOnHost_Task(string filterId, ManagedObjectReference host)
		{
			ManagedObjectReference result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim60);
				ResolveInstallationErrorsOnHostRequestType resolveInstallationErrorsOnHostRequestType = new ResolveInstallationErrorsOnHostRequestType();
				resolveInstallationErrorsOnHostRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				resolveInstallationErrorsOnHostRequestType.filterId = filterId;
				resolveInstallationErrorsOnHostRequestType.host = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(host);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.ResolveInstallationErrorsOnHost_Task(new ResolveInstallationErrorsOnHost_TaskRequest(resolveInstallationErrorsOnHostRequestType)).ResolveInstallationErrorsOnHost_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void ResolveInstallationErrorsOnHost(string filterId, ManagedObjectReference host)
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim60);
				ManagedObjectReference taskReference = this.ResolveInstallationErrorsOnHost_Task(filterId, host);
				this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public ManagedObjectReference ResolveInstallationErrorsOnCluster_Task(string filterId, ManagedObjectReference cluster)
		{
			ManagedObjectReference result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim60);
				ResolveInstallationErrorsOnClusterRequestType resolveInstallationErrorsOnClusterRequestType = new ResolveInstallationErrorsOnClusterRequestType();
				resolveInstallationErrorsOnClusterRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				resolveInstallationErrorsOnClusterRequestType.filterId = filterId;
				resolveInstallationErrorsOnClusterRequestType.cluster = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(cluster);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.ResolveInstallationErrorsOnCluster_Task(new ResolveInstallationErrorsOnCluster_TaskRequest(resolveInstallationErrorsOnClusterRequestType)).ResolveInstallationErrorsOnCluster_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void ResolveInstallationErrorsOnCluster(string filterId, ManagedObjectReference cluster)
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim60);
				ManagedObjectReference taskReference = this.ResolveInstallationErrorsOnCluster_Task(filterId, cluster);
				this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public VirtualDiskId[] QueryDisksUsingFilter(string filterId, ManagedObjectReference compRes)
		{
			VirtualDiskId[] result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim60);
				QueryDisksUsingFilterRequestType queryDisksUsingFilterRequestType = new QueryDisksUsingFilterRequestType();
				queryDisksUsingFilterRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				queryDisksUsingFilterRequestType.filterId = filterId;
				queryDisksUsingFilterRequestType.compRes = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(compRes);
				result = (VirtualDiskId[])VIConvert.ToVim(this.VimServiceProxy.QueryDisksUsingFilter(new QueryDisksUsingFilterRequest(queryDisksUsingFilterRequestType)).QueryDisksUsingFilterResponse1);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
	}
}
