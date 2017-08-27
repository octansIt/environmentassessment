using System.ServiceModel;
using VimApi_65;
namespace EnvironmentAssessment.Common.VimApi
{
	public class GuestAliasManager : ViewBase
	{
		public GuestAliasManager(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public void AddGuestAlias(ManagedObjectReference vm, GuestAuthentication auth, string username, bool mapCert, string base64Cert, GuestAuthAliasInfo aliasInfo)
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim60);
				AddGuestAliasRequestType addGuestAliasRequestType = new AddGuestAliasRequestType();
				addGuestAliasRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				addGuestAliasRequestType.vm = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(vm);
				addGuestAliasRequestType.auth = (VimApi_65.GuestAuthentication)VIConvert.ToWsdlType(auth);
				addGuestAliasRequestType.username = username;
				addGuestAliasRequestType.mapCert = mapCert;
				addGuestAliasRequestType.base64Cert = base64Cert;
				addGuestAliasRequestType.aliasInfo = (VimApi_65.GuestAuthAliasInfo)VIConvert.ToWsdlType(aliasInfo);
				this.VimServiceProxy.AddGuestAlias(new AddGuestAliasRequest(addGuestAliasRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void RemoveGuestAlias(ManagedObjectReference vm, GuestAuthentication auth, string username, string base64Cert, GuestAuthSubject subject)
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim60);
				RemoveGuestAliasRequestType removeGuestAliasRequestType = new RemoveGuestAliasRequestType();
				removeGuestAliasRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				removeGuestAliasRequestType.vm = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(vm);
				removeGuestAliasRequestType.auth = (VimApi_65.GuestAuthentication)VIConvert.ToWsdlType(auth);
				removeGuestAliasRequestType.username = username;
				removeGuestAliasRequestType.base64Cert = base64Cert;
				removeGuestAliasRequestType.subject = (VimApi_65.GuestAuthSubject)VIConvert.ToWsdlType(subject);
				this.VimServiceProxy.RemoveGuestAlias(new RemoveGuestAliasRequest(removeGuestAliasRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void RemoveGuestAliasByCert(ManagedObjectReference vm, GuestAuthentication auth, string username, string base64Cert)
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim60);
				RemoveGuestAliasByCertRequestType removeGuestAliasByCertRequestType = new RemoveGuestAliasByCertRequestType();
				removeGuestAliasByCertRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				removeGuestAliasByCertRequestType.vm = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(vm);
				removeGuestAliasByCertRequestType.auth = (VimApi_65.GuestAuthentication)VIConvert.ToWsdlType(auth);
				removeGuestAliasByCertRequestType.username = username;
				removeGuestAliasByCertRequestType.base64Cert = base64Cert;
				this.VimServiceProxy.RemoveGuestAliasByCert(new RemoveGuestAliasByCertRequest(removeGuestAliasByCertRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public GuestAliases[] ListGuestAliases(ManagedObjectReference vm, GuestAuthentication auth, string username)
		{
			GuestAliases[] result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim60);
				ListGuestAliasesRequestType listGuestAliasesRequestType = new ListGuestAliasesRequestType();
				listGuestAliasesRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				listGuestAliasesRequestType.vm = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(vm);
				listGuestAliasesRequestType.auth = (VimApi_65.GuestAuthentication)VIConvert.ToWsdlType(auth);
				listGuestAliasesRequestType.username = username;
				result = (GuestAliases[])VIConvert.ToVim(this.VimServiceProxy.ListGuestAliases(new ListGuestAliasesRequest(listGuestAliasesRequestType)).ListGuestAliasesResponse1);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public GuestMappedAliases[] ListGuestMappedAliases(ManagedObjectReference vm, GuestAuthentication auth)
		{
			GuestMappedAliases[] result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim60);
				ListGuestMappedAliasesRequestType listGuestMappedAliasesRequestType = new ListGuestMappedAliasesRequestType();
				listGuestMappedAliasesRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				listGuestMappedAliasesRequestType.vm = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(vm);
				listGuestMappedAliasesRequestType.auth = (VimApi_65.GuestAuthentication)VIConvert.ToWsdlType(auth);
				result = (GuestMappedAliases[])VIConvert.ToVim(this.VimServiceProxy.ListGuestMappedAliases(new ListGuestMappedAliasesRequest(listGuestMappedAliasesRequestType)).ListGuestMappedAliasesResponse1);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
	}
}
