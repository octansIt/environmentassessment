
using System.ServiceModel;
using VimApi_65;namespace EnvironmentAssessment.Common.VimApi
{
	public class CustomFieldsManager : ViewBase
	{
		protected CustomFieldDef[] _field;
		public CustomFieldDef[] Field
		{
			get
			{
				return this._field;
			}
		}
		public CustomFieldsManager(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public CustomFieldDef AddCustomFieldDef(string name, string moType, PrivilegePolicyDef fieldDefPolicy, PrivilegePolicyDef fieldPolicy)
		{
			CustomFieldDef result;
			try
			{
				AddCustomFieldDefRequestType addCustomFieldDefRequestType = new AddCustomFieldDefRequestType();
				addCustomFieldDefRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				addCustomFieldDefRequestType.name = name;
				addCustomFieldDefRequestType.moType = moType;
				addCustomFieldDefRequestType.fieldDefPolicy = (VimApi_65.PrivilegePolicyDef)VIConvert.ToWsdlType(fieldDefPolicy);
				addCustomFieldDefRequestType.fieldPolicy = (VimApi_65.PrivilegePolicyDef)VIConvert.ToWsdlType(fieldPolicy);
				result = (CustomFieldDef)VIConvert.ToVim(this.VimServiceProxy.AddCustomFieldDef(new AddCustomFieldDefRequest(addCustomFieldDefRequestType)).AddCustomFieldDefResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void RemoveCustomFieldDef(int key)
		{
			try
			{
				RemoveCustomFieldDefRequestType removeCustomFieldDefRequestType = new RemoveCustomFieldDefRequestType();
				removeCustomFieldDefRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				removeCustomFieldDefRequestType.key = key;
				this.VimServiceProxy.RemoveCustomFieldDef(new RemoveCustomFieldDefRequest(removeCustomFieldDefRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void RenameCustomFieldDef(int key, string name)
		{
			try
			{
				RenameCustomFieldDefRequestType renameCustomFieldDefRequestType = new RenameCustomFieldDefRequestType();
				renameCustomFieldDefRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				renameCustomFieldDefRequestType.key = key;
				renameCustomFieldDefRequestType.name = name;
				this.VimServiceProxy.RenameCustomFieldDef(new RenameCustomFieldDefRequest(renameCustomFieldDefRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void SetField(ManagedObjectReference entity, int key, string value)
		{
			try
			{
				SetFieldRequestType setFieldRequestType = new SetFieldRequestType();
				setFieldRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				setFieldRequestType.entity = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(entity);
				setFieldRequestType.key = key;
				setFieldRequestType.value = value;
				this.VimServiceProxy.SetField(new SetFieldRequest(setFieldRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
	}
}
