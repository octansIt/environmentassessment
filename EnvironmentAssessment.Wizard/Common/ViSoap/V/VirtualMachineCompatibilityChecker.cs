using System;
using System.Web.Services.Protocols;
using VimApi_60;
namespace EnvironmentAssessment.Common.VISoap
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
				if (this.Client.Version == VimVersion.Vim25)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				result = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).CheckCompatibility_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(vm), (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(host), (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(pool), testType));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public CheckResult[] CheckCompatibility(ManagedObjectReference vm, ManagedObjectReference host, ManagedObjectReference pool, string[] testType)
		{
			CheckResult[] result;
			try
			{
				if (this.Client.Version == VimVersion.Vim25)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				ManagedObjectReference taskReference = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).CheckCompatibility_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(vm), (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(host), (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(pool), testType));
				result = (CheckResult[])this.Client.WaitForTask(taskReference);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
	}
}
