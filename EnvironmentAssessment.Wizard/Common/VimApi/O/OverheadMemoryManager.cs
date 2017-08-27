using System.ServiceModel;
using VimApi_65;
namespace EnvironmentAssessment.Common.VimApi
{
	public class OverheadMemoryManager : ViewBase
	{
		public OverheadMemoryManager(IVimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public long LookupVmOverheadMemory(ManagedObjectReference vm, ManagedObjectReference host)
		{
			long returnval;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim60);
				LookupVmOverheadMemoryRequestType lookupVmOverheadMemoryRequestType = new LookupVmOverheadMemoryRequestType();
				lookupVmOverheadMemoryRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				lookupVmOverheadMemoryRequestType.vm = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(vm);
				lookupVmOverheadMemoryRequestType.host = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(host);
				returnval = this.VimServiceProxy.LookupVmOverheadMemory(new LookupVmOverheadMemoryRequest(lookupVmOverheadMemoryRequestType)).LookupVmOverheadMemoryResponse.returnval;
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return returnval;
		}
	}
}
