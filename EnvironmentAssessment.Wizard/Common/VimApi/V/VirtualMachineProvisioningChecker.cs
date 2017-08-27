using System;
using System.ServiceModel;
using VimApi_65;
namespace EnvironmentAssessment.Common.VimApi
{
	public class VirtualMachineProvisioningChecker : ViewBase
	{
		public VirtualMachineProvisioningChecker(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public ManagedObjectReference QueryVMotionCompatibilityEx_Task(ManagedObjectReference[] vm, ManagedObjectReference[] host)
		{
			ManagedObjectReference result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				QueryVMotionCompatibilityExRequestType queryVMotionCompatibilityExRequestType = new QueryVMotionCompatibilityExRequestType();
				queryVMotionCompatibilityExRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				queryVMotionCompatibilityExRequestType.vm = (VimApi_65.ManagedObjectReference[])VIConvert.ToWsdlType(vm);
				queryVMotionCompatibilityExRequestType.host = (VimApi_65.ManagedObjectReference[])VIConvert.ToWsdlType(host);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.QueryVMotionCompatibilityEx_Task(new QueryVMotionCompatibilityEx_TaskRequest(queryVMotionCompatibilityExRequestType)).QueryVMotionCompatibilityEx_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public CheckResult[] QueryVMotionCompatibilityEx(ManagedObjectReference[] vm, ManagedObjectReference[] host)
		{
			CheckResult[] result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				ManagedObjectReference taskReference = this.QueryVMotionCompatibilityEx_Task(vm, host);
				result = (CheckResult[])this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference CheckMigrate_Task(ManagedObjectReference vm, ManagedObjectReference host, ManagedObjectReference pool, VirtualMachinePowerState? state, string[] testType)
		{
			ManagedObjectReference result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				CheckMigrateRequestType checkMigrateRequestType = new CheckMigrateRequestType();
				checkMigrateRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				checkMigrateRequestType.vm = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(vm);
				checkMigrateRequestType.host = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(host);
				checkMigrateRequestType.pool = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(pool);
				checkMigrateRequestType.state = (VimApi_65.VirtualMachinePowerState)VIConvert.ToWsdlType(state.GetValueOrDefault());
				checkMigrateRequestType.stateSpecified = state.HasValue;
				checkMigrateRequestType.testType = testType;
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.CheckMigrate_Task(new CheckMigrate_TaskRequest(checkMigrateRequestType)).CheckMigrate_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public CheckResult[] CheckMigrate(ManagedObjectReference vm, ManagedObjectReference host, ManagedObjectReference pool, VirtualMachinePowerState? state, string[] testType)
		{
			CheckResult[] result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				ManagedObjectReference taskReference = this.CheckMigrate_Task(vm, host, pool, state, testType);
				result = (CheckResult[])this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference CheckRelocate_Task(ManagedObjectReference vm, VirtualMachineRelocateSpec spec, string[] testType)
		{
			ManagedObjectReference result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				CheckRelocateRequestType checkRelocateRequestType = new CheckRelocateRequestType();
				checkRelocateRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				checkRelocateRequestType.vm = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(vm);
				checkRelocateRequestType.spec = (VimApi_65.VirtualMachineRelocateSpec)VIConvert.ToWsdlType(spec);
				checkRelocateRequestType.testType = testType;
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.CheckRelocate_Task(new CheckRelocate_TaskRequest(checkRelocateRequestType)).CheckRelocate_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public CheckResult[] CheckRelocate(ManagedObjectReference vm, VirtualMachineRelocateSpec spec, string[] testType)
		{
			CheckResult[] result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				ManagedObjectReference taskReference = this.CheckRelocate_Task(vm, spec, testType);
				result = (CheckResult[])this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
	}
}
