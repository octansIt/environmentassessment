using System.ServiceModel;
using VimApi_65;
namespace EnvironmentAssessment.Common.VimApi
{
	public class GuestProcessManager : ViewBase
	{
		public GuestProcessManager(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public long StartProgramInGuest(ManagedObjectReference vm, GuestAuthentication auth, GuestProgramSpec spec)
		{
			long returnval;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim50);
				StartProgramInGuestRequestType startProgramInGuestRequestType = new StartProgramInGuestRequestType();
				startProgramInGuestRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				startProgramInGuestRequestType.vm = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(vm);
				startProgramInGuestRequestType.auth = (VimApi_65.GuestAuthentication)VIConvert.ToWsdlType(auth);
				startProgramInGuestRequestType.spec = (VimApi_65.GuestProgramSpec)VIConvert.ToWsdlType(spec);
				returnval = this.VimServiceProxy.StartProgramInGuest(new StartProgramInGuestRequest(startProgramInGuestRequestType)).StartProgramInGuestResponse.returnval;
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return returnval;
		}
		public GuestProcessInfo[] ListProcessesInGuest(ManagedObjectReference vm, GuestAuthentication auth, long[] pids)
		{
			GuestProcessInfo[] result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim50);
				ListProcessesInGuestRequestType listProcessesInGuestRequestType = new ListProcessesInGuestRequestType();
				listProcessesInGuestRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				listProcessesInGuestRequestType.vm = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(vm);
				listProcessesInGuestRequestType.auth = (VimApi_65.GuestAuthentication)VIConvert.ToWsdlType(auth);
				listProcessesInGuestRequestType.pids = pids;
				result = (GuestProcessInfo[])VIConvert.ToVim(this.VimServiceProxy.ListProcessesInGuest(new ListProcessesInGuestRequest(listProcessesInGuestRequestType)).ListProcessesInGuestResponse1);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void TerminateProcessInGuest(ManagedObjectReference vm, GuestAuthentication auth, long pid)
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim50);
				TerminateProcessInGuestRequestType terminateProcessInGuestRequestType = new TerminateProcessInGuestRequestType();
				terminateProcessInGuestRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				terminateProcessInGuestRequestType.vm = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(vm);
				terminateProcessInGuestRequestType.auth = (VimApi_65.GuestAuthentication)VIConvert.ToWsdlType(auth);
				terminateProcessInGuestRequestType.pid = pid;
				this.VimServiceProxy.TerminateProcessInGuest(new TerminateProcessInGuestRequest(terminateProcessInGuestRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public string[] ReadEnvironmentVariableInGuest(ManagedObjectReference vm, GuestAuthentication auth, string[] names)
		{
			string[] readEnvironmentVariableInGuestResponse;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim50);
				ReadEnvironmentVariableInGuestRequestType readEnvironmentVariableInGuestRequestType = new ReadEnvironmentVariableInGuestRequestType();
				readEnvironmentVariableInGuestRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				readEnvironmentVariableInGuestRequestType.vm = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(vm);
				readEnvironmentVariableInGuestRequestType.auth = (VimApi_65.GuestAuthentication)VIConvert.ToWsdlType(auth);
				readEnvironmentVariableInGuestRequestType.names = names;
				readEnvironmentVariableInGuestResponse = this.VimServiceProxy.ReadEnvironmentVariableInGuest(new ReadEnvironmentVariableInGuestRequest(readEnvironmentVariableInGuestRequestType)).ReadEnvironmentVariableInGuestResponse1;
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return readEnvironmentVariableInGuestResponse;
		}
	}
}
