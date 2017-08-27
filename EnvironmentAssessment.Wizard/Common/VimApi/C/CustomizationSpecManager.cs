
using System.ServiceModel;
using VimApi_65;namespace EnvironmentAssessment.Common.VimApi
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
			bool returnval;
			try
			{
				DoesCustomizationSpecExistRequestType doesCustomizationSpecExistRequestType = new DoesCustomizationSpecExistRequestType();
				doesCustomizationSpecExistRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				doesCustomizationSpecExistRequestType.name = name;
				returnval = this.VimServiceProxy.DoesCustomizationSpecExist(new DoesCustomizationSpecExistRequest(doesCustomizationSpecExistRequestType)).DoesCustomizationSpecExistResponse.returnval;
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return returnval;
		}
		public CustomizationSpecItem GetCustomizationSpec(string name)
		{
			CustomizationSpecItem result;
			try
			{
				GetCustomizationSpecRequestType getCustomizationSpecRequestType = new GetCustomizationSpecRequestType();
				getCustomizationSpecRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				getCustomizationSpecRequestType.name = name;
				result = (CustomizationSpecItem)VIConvert.ToVim(this.VimServiceProxy.GetCustomizationSpec(new GetCustomizationSpecRequest(getCustomizationSpecRequestType)).GetCustomizationSpecResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void CreateCustomizationSpec(CustomizationSpecItem item)
		{
			try
			{
				CreateCustomizationSpecRequestType createCustomizationSpecRequestType = new CreateCustomizationSpecRequestType();
				createCustomizationSpecRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				createCustomizationSpecRequestType.item = (VimApi_65.CustomizationSpecItem)VIConvert.ToWsdlType(item);
				this.VimServiceProxy.CreateCustomizationSpec(new CreateCustomizationSpecRequest(createCustomizationSpecRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void OverwriteCustomizationSpec(CustomizationSpecItem item)
		{
			try
			{
				OverwriteCustomizationSpecRequestType overwriteCustomizationSpecRequestType = new OverwriteCustomizationSpecRequestType();
				overwriteCustomizationSpecRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				overwriteCustomizationSpecRequestType.item = (VimApi_65.CustomizationSpecItem)VIConvert.ToWsdlType(item);
				this.VimServiceProxy.OverwriteCustomizationSpec(new OverwriteCustomizationSpecRequest(overwriteCustomizationSpecRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void DeleteCustomizationSpec(string name)
		{
			try
			{
				DeleteCustomizationSpecRequestType deleteCustomizationSpecRequestType = new DeleteCustomizationSpecRequestType();
				deleteCustomizationSpecRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				deleteCustomizationSpecRequestType.name = name;
				this.VimServiceProxy.DeleteCustomizationSpec(new DeleteCustomizationSpecRequest(deleteCustomizationSpecRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void DuplicateCustomizationSpec(string name, string newName)
		{
			try
			{
				DuplicateCustomizationSpecRequestType duplicateCustomizationSpecRequestType = new DuplicateCustomizationSpecRequestType();
				duplicateCustomizationSpecRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				duplicateCustomizationSpecRequestType.name = name;
				duplicateCustomizationSpecRequestType.newName = newName;
				this.VimServiceProxy.DuplicateCustomizationSpec(new DuplicateCustomizationSpecRequest(duplicateCustomizationSpecRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void RenameCustomizationSpec(string name, string newName)
		{
			try
			{
				RenameCustomizationSpecRequestType renameCustomizationSpecRequestType = new RenameCustomizationSpecRequestType();
				renameCustomizationSpecRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				renameCustomizationSpecRequestType.name = name;
				renameCustomizationSpecRequestType.newName = newName;
				this.VimServiceProxy.RenameCustomizationSpec(new RenameCustomizationSpecRequest(renameCustomizationSpecRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public string CustomizationSpecItemToXml(CustomizationSpecItem item)
		{
			string returnval;
			try
			{
				CustomizationSpecItemToXmlRequestType customizationSpecItemToXmlRequestType = new CustomizationSpecItemToXmlRequestType();
				customizationSpecItemToXmlRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				customizationSpecItemToXmlRequestType.item = (VimApi_65.CustomizationSpecItem)VIConvert.ToWsdlType(item);
				returnval = this.VimServiceProxy.CustomizationSpecItemToXml(new CustomizationSpecItemToXmlRequest(customizationSpecItemToXmlRequestType)).CustomizationSpecItemToXmlResponse.returnval;
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return returnval;
		}
		public CustomizationSpecItem XmlToCustomizationSpecItem(string specItemXml)
		{
			CustomizationSpecItem result;
			try
			{
				XmlToCustomizationSpecItemRequestType xmlToCustomizationSpecItemRequestType = new XmlToCustomizationSpecItemRequestType();
				xmlToCustomizationSpecItemRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				xmlToCustomizationSpecItemRequestType.specItemXml = specItemXml;
				result = (CustomizationSpecItem)VIConvert.ToVim(this.VimServiceProxy.XmlToCustomizationSpecItem(new XmlToCustomizationSpecItemRequest(xmlToCustomizationSpecItemRequestType)).XmlToCustomizationSpecItemResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void CheckCustomizationResources(string guestOs)
		{
			try
			{
				CheckCustomizationResourcesRequestType checkCustomizationResourcesRequestType = new CheckCustomizationResourcesRequestType();
				checkCustomizationResourcesRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				checkCustomizationResourcesRequestType.guestOs = guestOs;
				this.VimServiceProxy.CheckCustomizationResources(new CheckCustomizationResourcesRequest(checkCustomizationResourcesRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
	}
}
