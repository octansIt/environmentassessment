using System.ServiceModel;
using VimApi_65;
namespace EnvironmentAssessment.Common.VimApi
{
	public class OptionManager : ViewBase
	{
		protected OptionDef[] _supportedOption;
		protected OptionValue[] _setting;
		public OptionDef[] SupportedOption
		{
			get
			{
				return this._supportedOption;
			}
		}
		public OptionValue[] Setting
		{
			get
			{
				return this._setting;
			}
		}
		public OptionManager(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public OptionValue[] QueryOptions(string name)
		{
			OptionValue[] result;
			try
			{
				QueryOptionsRequestType queryOptionsRequestType = new QueryOptionsRequestType();
				queryOptionsRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				queryOptionsRequestType.name = name;
				result = (OptionValue[])VIConvert.ToVim(this.VimServiceProxy.QueryOptions(new QueryOptionsRequest(queryOptionsRequestType)).QueryOptionsResponse1);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void UpdateOptions(OptionValue[] changedValue)
		{
			try
			{
				UpdateOptionsRequestType updateOptionsRequestType = new UpdateOptionsRequestType();
				updateOptionsRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				updateOptionsRequestType.changedValue = (VimApi_65.OptionValue[])VIConvert.ToWsdlType(changedValue);
				this.VimServiceProxy.UpdateOptions(new UpdateOptionsRequest(updateOptionsRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
	}
}
