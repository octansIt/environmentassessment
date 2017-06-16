using System.Web.Services.Protocols;
using VimApi_60;
namespace EnvironmentAssessment.Common.VISoap
{
    public class CustomizationSpecManager : ViewBase
	{
		protected CustomizationSpecInfo[] _info;
		protected sbyte[] _encryptionKey;
		public CustomizationSpecInfo[] Info
		{
			get
			{
				return this._info;
			}
		}
		public sbyte[] EncryptionKey
		{
			get
			{
				return this._encryptionKey;
			}
		}
		public CustomizationSpecManager(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public bool DoesCustomizationSpecExist(string name)
		{
			bool result;
			try
			{
				result = ((VimService)this.Client.VimService).DoesCustomizationSpecExist((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), name);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public CustomizationSpecItem GetCustomizationSpec(string name)
		{
			CustomizationSpecItem result;
			try
			{
				result = (CustomizationSpecItem)VIConvert.ToVim(((VimService)this.Client.VimService).GetCustomizationSpec((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), name));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public void CreateCustomizationSpec(CustomizationSpecItem item)
		{
			try
			{
				((VimService)this.Client.VimService).CreateCustomizationSpec((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.CustomizationSpecItem)VIConvert.ToWsdlType(item));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public void OverwriteCustomizationSpec(CustomizationSpecItem item)
		{
			try
			{
				((VimService)this.Client.VimService).OverwriteCustomizationSpec((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.CustomizationSpecItem)VIConvert.ToWsdlType(item));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public void DeleteCustomizationSpec(string name)
		{
			try
			{
				((VimService)this.Client.VimService).DeleteCustomizationSpec((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), name);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public void DuplicateCustomizationSpec(string name, string newName)
		{
			try
			{
				((VimService)this.Client.VimService).DuplicateCustomizationSpec((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), name, newName);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public void RenameCustomizationSpec(string name, string newName)
		{
			try
			{
				((VimService)this.Client.VimService).RenameCustomizationSpec((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), name, newName);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public string CustomizationSpecItemToXml(CustomizationSpecItem item)
		{
			string result;
			try
			{
				result = ((VimService)this.Client.VimService).CustomizationSpecItemToXml((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.CustomizationSpecItem)VIConvert.ToWsdlType(item));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public CustomizationSpecItem XmlToCustomizationSpecItem(string specItemXml)
		{
			CustomizationSpecItem result;
			try
			{
				result = (CustomizationSpecItem)VIConvert.ToVim(((VimService)this.Client.VimService).XmlToCustomizationSpecItem((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), specItemXml));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public void CheckCustomizationResources(string guestOs)
		{
			try
			{
				((VimService)this.Client.VimService).CheckCustomizationResources((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), guestOs);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
	}
}
