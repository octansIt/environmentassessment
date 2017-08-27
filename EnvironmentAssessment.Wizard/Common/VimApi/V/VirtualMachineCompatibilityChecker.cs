using System;
using System.ServiceModel;
using VimApi_65;
namespace EnvironmentAssessment.Common.VimApi
{
	public class VirtualMachineCompatibilityChecker : ViewBase
	{
		public VirtualMachineCompatibilityChecker(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public ManagedObjectReference CheckCompatibility_Task(ManagedObjectReference vm, ManagedObjectReference host, ManagedObjectReference pool, string[] testType)
		{
			ManagedObjectReference result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				CheckCompatibilityRequestType checkCompatibilityRequestType = new CheckCompatibilityRequestType();
				checkCompatibilityRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				checkCompatibilityRequestType.vm = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(vm);
				checkCompatibilityRequestType.host = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(host);
				checkCompatibilityRequestType.pool = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(pool);
				checkCompatibilityRequestType.testType = testType;
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.CheckCompatibility_Task(new CheckCompatibility_TaskRequest(checkCompatibilityRequestType)).CheckCompatibility_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public CheckResult[] CheckCompatibility(ManagedObjectReference vm, ManagedObjectReference host, ManagedObjectReference pool, string[] testType)
		{
			CheckResult[] result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				ManagedObjectReference taskReference = this.CheckCompatibility_Task(vm, host, pool, testType);
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
