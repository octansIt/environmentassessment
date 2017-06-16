using System.Web.Services.Protocols;
using VimApi_60;
namespace EnvironmentAssessment.Common.VISoap
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
				result = (CustomFieldDef)VIConvert.ToVim(((VimService)this.Client.VimService).AddCustomFieldDef((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), name, moType, (VimApi_60.PrivilegePolicyDef)VIConvert.ToWsdlType(fieldDefPolicy), (VimApi_60.PrivilegePolicyDef)VIConvert.ToWsdlType(fieldPolicy)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public void RemoveCustomFieldDef(int key)
		{
			try
			{
				((VimService)this.Client.VimService).RemoveCustomFieldDef((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), key);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public void RenameCustomFieldDef(int key, string name)
		{
			try
			{
				((VimService)this.Client.VimService).RenameCustomFieldDef((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), key, name);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public void SetField(ManagedObjectReference entity, int key, string value)
		{
			try
			{
				((VimService)this.Client.VimService).SetField((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(entity), key, value);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
	}
}
