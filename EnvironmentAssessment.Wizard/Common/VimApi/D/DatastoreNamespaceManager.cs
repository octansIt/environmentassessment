using System.ServiceModel;
using VimApi_65;
namespace EnvironmentAssessment.Common.VimApi
{
	public class DatastoreNamespaceManager : ViewBase
	{
		public DatastoreNamespaceManager(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public string CreateDirectory(ManagedObjectReference datastore, string displayName, string policy)
		{
			string returnval;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim60);
				CreateDirectoryRequestType createDirectoryRequestType = new CreateDirectoryRequestType();
				createDirectoryRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				createDirectoryRequestType.datastore = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(datastore);
				createDirectoryRequestType.displayName = displayName;
				createDirectoryRequestType.policy = policy;
				returnval = this.VimServiceProxy.CreateDirectory(new CreateDirectoryRequest(createDirectoryRequestType)).CreateDirectoryResponse.returnval;
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return returnval;
		}
		public void DeleteDirectory(ManagedObjectReference datacenter, string datastorePath)
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim60);
				DeleteDirectoryRequestType deleteDirectoryRequestType = new DeleteDirectoryRequestType();
				deleteDirectoryRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				deleteDirectoryRequestType.datacenter = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(datacenter);
				deleteDirectoryRequestType.datastorePath = datastorePath;
				this.VimServiceProxy.DeleteDirectory(new DeleteDirectoryRequest(deleteDirectoryRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public string ConvertNamespacePathToUuidPath(ManagedObjectReference datacenter, string namespaceUrl)
		{
			string returnval;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim65);
				ConvertNamespacePathToUuidPathRequestType convertNamespacePathToUuidPathRequestType = new ConvertNamespacePathToUuidPathRequestType();
				convertNamespacePathToUuidPathRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				convertNamespacePathToUuidPathRequestType.datacenter = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(datacenter);
				convertNamespacePathToUuidPathRequestType.namespaceUrl = namespaceUrl;
				returnval = this.VimServiceProxy.ConvertNamespacePathToUuidPath(new ConvertNamespacePathToUuidPathRequest(convertNamespacePathToUuidPathRequestType)).ConvertNamespacePathToUuidPathResponse.returnval;
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return returnval;
		}
	}
}
