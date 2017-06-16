using System;
using System.Web.Services.Protocols;
using VimApi_60;
namespace EnvironmentAssessment.Common.VISoap
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
		public OvfManager(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public OvfValidateHostResult ValidateHost(string ovfDescriptor, ManagedObjectReference host, OvfValidateHostParams vhp)
		{
			OvfValidateHostResult result;
			try
			{
				if (this.Client.Version == VimVersion.Vim25)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				result = (OvfValidateHostResult)VIConvert.ToVim(((VimService)this.Client.VimService).ValidateHost((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), ovfDescriptor, (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(host), (VimApi_60.OvfValidateHostParams)VIConvert.ToWsdlType(vhp)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public OvfParseDescriptorResult ParseDescriptor(string ovfDescriptor, OvfParseDescriptorParams pdp)
		{
			OvfParseDescriptorResult result;
			try
			{
				if (this.Client.Version == VimVersion.Vim25)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				result = (OvfParseDescriptorResult)VIConvert.ToVim(((VimService)this.Client.VimService).ParseDescriptor((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), ovfDescriptor, (VimApi_60.OvfParseDescriptorParams)VIConvert.ToWsdlType(pdp)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public OvfCreateImportSpecResult CreateImportSpec(string ovfDescriptor, ManagedObjectReference resourcePool, ManagedObjectReference datastore, OvfCreateImportSpecParams cisp)
		{
			OvfCreateImportSpecResult result;
			try
			{
				if (this.Client.Version == VimVersion.Vim25)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				result = (OvfCreateImportSpecResult)VIConvert.ToVim(((VimService)this.Client.VimService).CreateImportSpec((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), ovfDescriptor, (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(resourcePool), (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(datastore), (VimApi_60.OvfCreateImportSpecParams)VIConvert.ToWsdlType(cisp)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public OvfCreateDescriptorResult CreateDescriptor(ManagedObjectReference obj, OvfCreateDescriptorParams cdp)
		{
			OvfCreateDescriptorResult result;
			try
			{
				if (this.Client.Version == VimVersion.Vim25)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				result = (OvfCreateDescriptorResult)VIConvert.ToVim(((VimService)this.Client.VimService).CreateDescriptor((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(obj), (VimApi_60.OvfCreateDescriptorParams)VIConvert.ToWsdlType(cdp)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
	}
}
