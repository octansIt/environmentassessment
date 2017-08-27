using System.ServiceModel;
using VimApi_65;
namespace EnvironmentAssessment.Common.VimApi
{
	public class HostSpecificationManager : ViewBase
	{
		public HostSpecificationManager(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public void UpdateHostSpecification(ManagedObjectReference host, HostSpecification hostSpec)
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim65);
				UpdateHostSpecificationRequestType updateHostSpecificationRequestType = new UpdateHostSpecificationRequestType();
				updateHostSpecificationRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				updateHostSpecificationRequestType.host = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(host);
				updateHostSpecificationRequestType.hostSpec = (VimApi_65.HostSpecification)VIConvert.ToWsdlType(hostSpec);
				this.VimServiceProxy.UpdateHostSpecification(new UpdateHostSpecificationRequest(updateHostSpecificationRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void UpdateHostSubSpecification(ManagedObjectReference host, HostSubSpecification hostSubSpec)
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim65);
				UpdateHostSubSpecificationRequestType updateHostSubSpecificationRequestType = new UpdateHostSubSpecificationRequestType();
				updateHostSubSpecificationRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				updateHostSubSpecificationRequestType.host = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(host);
				updateHostSubSpecificationRequestType.hostSubSpec = (VimApi_65.HostSubSpecification)VIConvert.ToWsdlType(hostSubSpec);
				this.VimServiceProxy.UpdateHostSubSpecification(new UpdateHostSubSpecificationRequest(updateHostSubSpecificationRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public HostSpecification RetrieveHostSpecification(ManagedObjectReference host, bool fromHost)
		{
			HostSpecification result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim65);
				RetrieveHostSpecificationRequestType retrieveHostSpecificationRequestType = new RetrieveHostSpecificationRequestType();
				retrieveHostSpecificationRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				retrieveHostSpecificationRequestType.host = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(host);
				retrieveHostSpecificationRequestType.fromHost = fromHost;
				result = (HostSpecification)VIConvert.ToVim(this.VimServiceProxy.RetrieveHostSpecification(new RetrieveHostSpecificationRequest(retrieveHostSpecificationRequestType)).RetrieveHostSpecificationResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void DeleteHostSubSpecification(ManagedObjectReference host, string subSpecName)
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim65);
				DeleteHostSubSpecificationRequestType deleteHostSubSpecificationRequestType = new DeleteHostSubSpecificationRequestType();
				deleteHostSubSpecificationRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				deleteHostSubSpecificationRequestType.host = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(host);
				deleteHostSubSpecificationRequestType.subSpecName = subSpecName;
				this.VimServiceProxy.DeleteHostSubSpecification(new DeleteHostSubSpecificationRequest(deleteHostSubSpecificationRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void DeleteHostSpecification(ManagedObjectReference host)
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim65);
				DeleteHostSpecificationRequestType deleteHostSpecificationRequestType = new DeleteHostSpecificationRequestType();
				deleteHostSpecificationRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				deleteHostSpecificationRequestType.host = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(host);
				this.VimServiceProxy.DeleteHostSpecification(new DeleteHostSpecificationRequest(deleteHostSpecificationRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public ManagedObjectReference[] HostSpecGetUpdatedHosts(string startChangeID, string endChangeID)
		{
			ManagedObjectReference[] result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim65);
				HostSpecGetUpdatedHostsRequestType hostSpecGetUpdatedHostsRequestType = new HostSpecGetUpdatedHostsRequestType();
				hostSpecGetUpdatedHostsRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				hostSpecGetUpdatedHostsRequestType.startChangeID = startChangeID;
				hostSpecGetUpdatedHostsRequestType.endChangeID = endChangeID;
				result = (ManagedObjectReference[])VIConvert.ToVim(this.VimServiceProxy.HostSpecGetUpdatedHosts(new HostSpecGetUpdatedHostsRequest(hostSpecGetUpdatedHostsRequestType)).HostSpecGetUpdatedHostsResponse1);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
	}
}
