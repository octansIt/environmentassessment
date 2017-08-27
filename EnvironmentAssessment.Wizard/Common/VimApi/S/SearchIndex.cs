using System.ServiceModel;
using VimApi_65;
namespace EnvironmentAssessment.Common.VimApi
{
	public class SearchIndex : ViewBase
	{
		public SearchIndex(IVimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public ManagedObjectReference FindByUuid(ManagedObjectReference datacenter, string uuid, bool vmSearch, bool? instanceUuid)
		{
			ManagedObjectReference result;
			try
			{
				FindByUuidRequestType findByUuidRequestType = new FindByUuidRequestType();
				findByUuidRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				findByUuidRequestType.datacenter = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(datacenter);
				findByUuidRequestType.uuid = uuid;
				findByUuidRequestType.vmSearch = vmSearch;
				findByUuidRequestType.instanceUuid = instanceUuid.GetValueOrDefault();
				findByUuidRequestType.instanceUuidSpecified = instanceUuid.HasValue;
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.FindByUuid(new FindByUuidRequest(findByUuidRequestType)).FindByUuidResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference FindByDatastorePath(ManagedObjectReference datacenter, string path)
		{
			ManagedObjectReference result;
			try
			{
				FindByDatastorePathRequestType findByDatastorePathRequestType = new FindByDatastorePathRequestType();
				findByDatastorePathRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				findByDatastorePathRequestType.datacenter = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(datacenter);
				findByDatastorePathRequestType.path = path;
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.FindByDatastorePath(new FindByDatastorePathRequest(findByDatastorePathRequestType)).FindByDatastorePathResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference FindByDnsName(ManagedObjectReference datacenter, string dnsName, bool vmSearch)
		{
			ManagedObjectReference result;
			try
			{
				FindByDnsNameRequestType findByDnsNameRequestType = new FindByDnsNameRequestType();
				findByDnsNameRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				findByDnsNameRequestType.datacenter = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(datacenter);
				findByDnsNameRequestType.dnsName = dnsName;
				findByDnsNameRequestType.vmSearch = vmSearch;
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.FindByDnsName(new FindByDnsNameRequest(findByDnsNameRequestType)).FindByDnsNameResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference FindByIp(ManagedObjectReference datacenter, string ip, bool vmSearch)
		{
			ManagedObjectReference result;
			try
			{
				FindByIpRequestType findByIpRequestType = new FindByIpRequestType();
				findByIpRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				findByIpRequestType.datacenter = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(datacenter);
				findByIpRequestType.ip = ip;
				findByIpRequestType.vmSearch = vmSearch;
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.FindByIp(new FindByIpRequest(findByIpRequestType)).FindByIpResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference FindByInventoryPath(string inventoryPath)
		{
			ManagedObjectReference result;
			try
			{
				FindByInventoryPathRequestType findByInventoryPathRequestType = new FindByInventoryPathRequestType();
				findByInventoryPathRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				findByInventoryPathRequestType.inventoryPath = inventoryPath;
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.FindByInventoryPath(new FindByInventoryPathRequest(findByInventoryPathRequestType)).FindByInventoryPathResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference FindChild(ManagedObjectReference entity, string name)
		{
			ManagedObjectReference result;
			try
			{
				FindChildRequestType findChildRequestType = new FindChildRequestType();
				findChildRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				findChildRequestType.entity = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(entity);
				findChildRequestType.name = name;
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.FindChild(new FindChildRequest(findChildRequestType)).FindChildResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference[] FindAllByUuid(ManagedObjectReference datacenter, string uuid, bool vmSearch, bool? instanceUuid)
		{
			ManagedObjectReference[] result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				FindAllByUuidRequestType findAllByUuidRequestType = new FindAllByUuidRequestType();
				findAllByUuidRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				findAllByUuidRequestType.datacenter = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(datacenter);
				findAllByUuidRequestType.uuid = uuid;
				findAllByUuidRequestType.vmSearch = vmSearch;
				findAllByUuidRequestType.instanceUuid = instanceUuid.GetValueOrDefault();
				findAllByUuidRequestType.instanceUuidSpecified = instanceUuid.HasValue;
				result = (ManagedObjectReference[])VIConvert.ToVim(this.VimServiceProxy.FindAllByUuid(new FindAllByUuidRequest(findAllByUuidRequestType)).FindAllByUuidResponse1);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference[] FindAllByDnsName(ManagedObjectReference datacenter, string dnsName, bool vmSearch)
		{
			ManagedObjectReference[] result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				FindAllByDnsNameRequestType findAllByDnsNameRequestType = new FindAllByDnsNameRequestType();
				findAllByDnsNameRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				findAllByDnsNameRequestType.datacenter = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(datacenter);
				findAllByDnsNameRequestType.dnsName = dnsName;
				findAllByDnsNameRequestType.vmSearch = vmSearch;
				result = (ManagedObjectReference[])VIConvert.ToVim(this.VimServiceProxy.FindAllByDnsName(new FindAllByDnsNameRequest(findAllByDnsNameRequestType)).FindAllByDnsNameResponse1);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference[] FindAllByIp(ManagedObjectReference datacenter, string ip, bool vmSearch)
		{
			ManagedObjectReference[] result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				FindAllByIpRequestType findAllByIpRequestType = new FindAllByIpRequestType();
				findAllByIpRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				findAllByIpRequestType.datacenter = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(datacenter);
				findAllByIpRequestType.ip = ip;
				findAllByIpRequestType.vmSearch = vmSearch;
				result = (ManagedObjectReference[])VIConvert.ToVim(this.VimServiceProxy.FindAllByIp(new FindAllByIpRequest(findAllByIpRequestType)).FindAllByIpResponse1);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
	}
}
