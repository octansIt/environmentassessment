using System.ServiceModel;
using VimApi_65;
namespace EnvironmentAssessment.Common.VimApi
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
		public ExtensibleManagedObject(IVimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public void setCustomValue(string key, string value)
		{
			try
			{
				setCustomValueRequestType setCustomValueRequestType = new setCustomValueRequestType();
				setCustomValueRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				setCustomValueRequestType.key = key;
				setCustomValueRequestType.value = value;
				this.VimServiceProxy.setCustomValue(new setCustomValueRequest(setCustomValueRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
	}
}
