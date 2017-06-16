using System.Web.Services.Protocols;
using VimApi_60;
namespace EnvironmentAssessment.Common.VISoap
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
				result = (OptionValue[])VIConvert.ToVim(((VimService)this.Client.VimService).QueryOptions((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), name));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public void UpdateOptions(OptionValue[] changedValue)
		{
			try
			{
				((VimService)this.Client.VimService).UpdateOptions((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.OptionValue[])VIConvert.ToWsdlType(changedValue));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
	}
}
