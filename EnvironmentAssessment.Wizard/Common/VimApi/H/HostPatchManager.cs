using System.ServiceModel;
using VimApi_65;
namespace EnvironmentAssessment.Common.VimApi
{
	public class HostPatchManager : ViewBase
	{
		public HostPatchManager(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public ManagedObjectReference CheckHostPatch_Task(string[] metaUrls, string[] bundleUrls, HostPatchManagerPatchManagerOperationSpec spec)
		{
			ManagedObjectReference result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				CheckHostPatchRequestType checkHostPatchRequestType = new CheckHostPatchRequestType();
				checkHostPatchRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				checkHostPatchRequestType.metaUrls = metaUrls;
				checkHostPatchRequestType.bundleUrls = bundleUrls;
				checkHostPatchRequestType.spec = (VimApi_65.HostPatchManagerPatchManagerOperationSpec)VIConvert.ToWsdlType(spec);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.CheckHostPatch_Task(new CheckHostPatch_TaskRequest(checkHostPatchRequestType)).CheckHostPatch_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public HostPatchManagerResult CheckHostPatch(string[] metaUrls, string[] bundleUrls, HostPatchManagerPatchManagerOperationSpec spec)
		{
			HostPatchManagerResult result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				ManagedObjectReference taskReference = this.CheckHostPatch_Task(metaUrls, bundleUrls, spec);
				result = (HostPatchManagerResult)this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference ScanHostPatch_Task(HostPatchManagerLocator repository, string[] updateID)
		{
			ManagedObjectReference result;
			try
			{
				ScanHostPatchRequestType scanHostPatchRequestType = new ScanHostPatchRequestType();
				scanHostPatchRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				scanHostPatchRequestType.repository = (VimApi_65.HostPatchManagerLocator)VIConvert.ToWsdlType(repository);
				scanHostPatchRequestType.updateID = updateID;
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.ScanHostPatch_Task(new ScanHostPatch_TaskRequest(scanHostPatchRequestType)).ScanHostPatch_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public HostPatchManagerStatus[] ScanHostPatch(HostPatchManagerLocator repository, string[] updateID)
		{
			HostPatchManagerStatus[] result;
			try
			{
				ManagedObjectReference taskReference = this.ScanHostPatch_Task(repository, updateID);
				result = (HostPatchManagerStatus[])this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference ScanHostPatchV2_Task(string[] metaUrls, string[] bundleUrls, HostPatchManagerPatchManagerOperationSpec spec)
		{
			ManagedObjectReference result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				ScanHostPatchV2RequestType scanHostPatchV2RequestType = new ScanHostPatchV2RequestType();
				scanHostPatchV2RequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				scanHostPatchV2RequestType.metaUrls = metaUrls;
				scanHostPatchV2RequestType.bundleUrls = bundleUrls;
				scanHostPatchV2RequestType.spec = (VimApi_65.HostPatchManagerPatchManagerOperationSpec)VIConvert.ToWsdlType(spec);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.ScanHostPatchV2_Task(new ScanHostPatchV2_TaskRequest(scanHostPatchV2RequestType)).ScanHostPatchV2_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public HostPatchManagerResult ScanHostPatchV2(string[] metaUrls, string[] bundleUrls, HostPatchManagerPatchManagerOperationSpec spec)
		{
			HostPatchManagerResult result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				ManagedObjectReference taskReference = this.ScanHostPatchV2_Task(metaUrls, bundleUrls, spec);
				result = (HostPatchManagerResult)this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference StageHostPatch_Task(string[] metaUrls, string[] bundleUrls, string[] vibUrls, HostPatchManagerPatchManagerOperationSpec spec)
		{
			ManagedObjectReference result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				StageHostPatchRequestType stageHostPatchRequestType = new StageHostPatchRequestType();
				stageHostPatchRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				stageHostPatchRequestType.metaUrls = metaUrls;
				stageHostPatchRequestType.bundleUrls = bundleUrls;
				stageHostPatchRequestType.vibUrls = vibUrls;
				stageHostPatchRequestType.spec = (VimApi_65.HostPatchManagerPatchManagerOperationSpec)VIConvert.ToWsdlType(spec);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.StageHostPatch_Task(new StageHostPatch_TaskRequest(stageHostPatchRequestType)).StageHostPatch_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public HostPatchManagerResult StageHostPatch(string[] metaUrls, string[] bundleUrls, string[] vibUrls, HostPatchManagerPatchManagerOperationSpec spec)
		{
			HostPatchManagerResult result;
			try
			{	
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				ManagedObjectReference taskReference = this.StageHostPatch_Task(metaUrls, bundleUrls, vibUrls, spec);
				result = (HostPatchManagerResult)this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference InstallHostPatch_Task(HostPatchManagerLocator repository, string updateID, bool? force)
		{
			ManagedObjectReference result;
			try
			{
				InstallHostPatchRequestType installHostPatchRequestType = new InstallHostPatchRequestType();
				installHostPatchRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				installHostPatchRequestType.repository = (VimApi_65.HostPatchManagerLocator)VIConvert.ToWsdlType(repository);
				installHostPatchRequestType.updateID = updateID;
				installHostPatchRequestType.force = force.GetValueOrDefault();
				installHostPatchRequestType.forceSpecified = force.HasValue;
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.InstallHostPatch_Task(new InstallHostPatch_TaskRequest(installHostPatchRequestType)).InstallHostPatch_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void InstallHostPatch(HostPatchManagerLocator repository, string updateID, bool? force)
		{
			try
			{
				ManagedObjectReference taskReference = this.InstallHostPatch_Task(repository, updateID, force);
				this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public ManagedObjectReference InstallHostPatchV2_Task(string[] metaUrls, string[] bundleUrls, string[] vibUrls, HostPatchManagerPatchManagerOperationSpec spec)
		{
			ManagedObjectReference result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				InstallHostPatchV2RequestType installHostPatchV2RequestType = new InstallHostPatchV2RequestType();
				installHostPatchV2RequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				installHostPatchV2RequestType.metaUrls = metaUrls;
				installHostPatchV2RequestType.bundleUrls = bundleUrls;
				installHostPatchV2RequestType.vibUrls = vibUrls;
				installHostPatchV2RequestType.spec = (VimApi_65.HostPatchManagerPatchManagerOperationSpec)VIConvert.ToWsdlType(spec);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.InstallHostPatchV2_Task(new InstallHostPatchV2_TaskRequest(installHostPatchV2RequestType)).InstallHostPatchV2_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public HostPatchManagerResult InstallHostPatchV2(string[] metaUrls, string[] bundleUrls, string[] vibUrls, HostPatchManagerPatchManagerOperationSpec spec)
		{
			HostPatchManagerResult result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				ManagedObjectReference taskReference = this.InstallHostPatchV2_Task(metaUrls, bundleUrls, vibUrls, spec);
				result = (HostPatchManagerResult)this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference UninstallHostPatch_Task(string[] bulletinIds, HostPatchManagerPatchManagerOperationSpec spec)
		{
			ManagedObjectReference result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				UninstallHostPatchRequestType uninstallHostPatchRequestType = new UninstallHostPatchRequestType();
				uninstallHostPatchRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				uninstallHostPatchRequestType.bulletinIds = bulletinIds;
				uninstallHostPatchRequestType.spec = (VimApi_65.HostPatchManagerPatchManagerOperationSpec)VIConvert.ToWsdlType(spec);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.UninstallHostPatch_Task(new UninstallHostPatch_TaskRequest(uninstallHostPatchRequestType)).UninstallHostPatch_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public HostPatchManagerResult UninstallHostPatch(string[] bulletinIds, HostPatchManagerPatchManagerOperationSpec spec)
		{
			HostPatchManagerResult result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				ManagedObjectReference taskReference = this.UninstallHostPatch_Task(bulletinIds, spec);
				result = (HostPatchManagerResult)this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference QueryHostPatch_Task(HostPatchManagerPatchManagerOperationSpec spec)
		{
			ManagedObjectReference result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				QueryHostPatchRequestType queryHostPatchRequestType = new QueryHostPatchRequestType();
				queryHostPatchRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				queryHostPatchRequestType.spec = (VimApi_65.HostPatchManagerPatchManagerOperationSpec)VIConvert.ToWsdlType(spec);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.QueryHostPatch_Task(new QueryHostPatch_TaskRequest(queryHostPatchRequestType)).QueryHostPatch_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public HostPatchManagerResult QueryHostPatch(HostPatchManagerPatchManagerOperationSpec spec)
		{
			HostPatchManagerResult result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				ManagedObjectReference taskReference = this.QueryHostPatch_Task(spec);
				result = (HostPatchManagerResult)this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
	}
}
