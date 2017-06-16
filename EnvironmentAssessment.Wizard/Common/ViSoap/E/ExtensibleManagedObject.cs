using System.Web.Services.Protocols;
using VimApi_60;
namespace EnvironmentAssessment.Common.VISoap
{
    public class ExtensibleManagedObject : ViewBase
	{
		protected CustomFieldValue[] _value;
		protected CustomFieldDef[] _availableField;
		public CustomFieldValue[] Value
		{
			get
			{
				return this._value;
			}
		}
		public CustomFieldDef[] AvailableField
		{
			get
			{
				return this._availableField;
			}
		}
		public ExtensibleManagedObject(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public void setCustomValue(string key, string value)
		{
			try
			{
				((VimService)this.Client.VimService).setCustomValue((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), key, value);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
	}
}
