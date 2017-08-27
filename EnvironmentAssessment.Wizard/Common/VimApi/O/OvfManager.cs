using System.ServiceModel;
using VimApi_65;
namespace EnvironmentAssessment.Common.VimApi
{
	public class OvfManager : ViewBase
	{
		protected OvfOptionInfo[] _ovfImportOption;
		protected OvfOptionInfo[] _ovfExportOption;
		public OvfOptionInfo[] OvfImportOption
		{
			get
			{
				return this._ovfImportOption;
			}
		}
		public OvfOptionInfo[] OvfExportOption
		{
			get
			{
				return this._ovfExportOption;
			}
		}
		public OvfManager(IVimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public OvfValidateHostResult ValidateHost(string ovfDescriptor, ManagedObjectReference host, OvfValidateHostParams vhp)
		{
			OvfValidateHostResult result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				ValidateHostRequestType validateHostRequestType = new ValidateHostRequestType();
				validateHostRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				validateHostRequestType.ovfDescriptor = ovfDescriptor;
				validateHostRequestType.host = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(host);
				validateHostRequestType.vhp = (VimApi_65.OvfValidateHostParams)VIConvert.ToWsdlType(vhp);
				result = (OvfValidateHostResult)VIConvert.ToVim(this.VimServiceProxy.ValidateHost(new ValidateHostRequest(validateHostRequestType)).ValidateHostResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public OvfParseDescriptorResult ParseDescriptor(string ovfDescriptor, OvfParseDescriptorParams pdp)
		{
			OvfParseDescriptorResult result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				ParseDescriptorRequestType parseDescriptorRequestType = new ParseDescriptorRequestType();
				parseDescriptorRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				parseDescriptorRequestType.ovfDescriptor = ovfDescriptor;
				parseDescriptorRequestType.pdp = (VimApi_65.OvfParseDescriptorParams)VIConvert.ToWsdlType(pdp);
				result = (OvfParseDescriptorResult)VIConvert.ToVim(this.VimServiceProxy.ParseDescriptor(new ParseDescriptorRequest(parseDescriptorRequestType)).ParseDescriptorResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public OvfCreateImportSpecResult CreateImportSpec(string ovfDescriptor, ManagedObjectReference resourcePool, ManagedObjectReference datastore, OvfCreateImportSpecParams cisp)
		{
			OvfCreateImportSpecResult result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				CreateImportSpecRequestType createImportSpecRequestType = new CreateImportSpecRequestType();
				createImportSpecRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				createImportSpecRequestType.ovfDescriptor = ovfDescriptor;
				createImportSpecRequestType.resourcePool = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(resourcePool);
				createImportSpecRequestType.datastore = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(datastore);
				createImportSpecRequestType.cisp = (VimApi_65.OvfCreateImportSpecParams)VIConvert.ToWsdlType(cisp);
				result = (OvfCreateImportSpecResult)VIConvert.ToVim(this.VimServiceProxy.CreateImportSpec(new CreateImportSpecRequest(createImportSpecRequestType)).CreateImportSpecResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public OvfCreateDescriptorResult CreateDescriptor(ManagedObjectReference obj, OvfCreateDescriptorParams cdp)
		{
			OvfCreateDescriptorResult result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				CreateDescriptorRequestType createDescriptorRequestType = new CreateDescriptorRequestType();
				createDescriptorRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				createDescriptorRequestType.obj = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(obj);
				createDescriptorRequestType.cdp = (VimApi_65.OvfCreateDescriptorParams)VIConvert.ToWsdlType(cdp);
				result = (OvfCreateDescriptorResult)VIConvert.ToVim(this.VimServiceProxy.CreateDescriptor(new CreateDescriptorRequest(createDescriptorRequestType)).CreateDescriptorResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
	}
}
