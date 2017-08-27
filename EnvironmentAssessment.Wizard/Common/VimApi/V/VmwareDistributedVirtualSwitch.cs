using System;
using System.ServiceModel;
using VimApi_65;
namespace EnvironmentAssessment.Common.VimApi
{
	public class VmwareDistributedVirtualSwitch : DistributedVirtualSwitch
	{
		public new VmwareDistributedVirtualSwitch_LinkedView LinkedView
		{
			get
			{
				return (VmwareDistributedVirtualSwitch_LinkedView)this._linkedView;
			}
		}
		public VmwareDistributedVirtualSwitch(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public ManagedObjectReference UpdateDVSLacpGroupConfig_Task(VMwareDvsLacpGroupSpec[] lacpGroupSpec)
		{
			ManagedObjectReference result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim55);
				UpdateDVSLacpGroupConfigRequestType updateDVSLacpGroupConfigRequestType = new UpdateDVSLacpGroupConfigRequestType();
				updateDVSLacpGroupConfigRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				updateDVSLacpGroupConfigRequestType.lacpGroupSpec = (VimApi_65.VMwareDvsLacpGroupSpec[])VIConvert.ToWsdlType(lacpGroupSpec);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.UpdateDVSLacpGroupConfig_Task(new UpdateDVSLacpGroupConfig_TaskRequest(updateDVSLacpGroupConfigRequestType)).UpdateDVSLacpGroupConfig_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void UpdateDVSLacpGroupConfig(VMwareDvsLacpGroupSpec[] lacpGroupSpec)
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim55);
				ManagedObjectReference taskReference = this.UpdateDVSLacpGroupConfig_Task(lacpGroupSpec);
				this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
	}
}
