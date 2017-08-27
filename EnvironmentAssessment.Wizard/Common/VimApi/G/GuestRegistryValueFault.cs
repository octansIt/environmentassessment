namespace EnvironmentAssessment.Common.VimApi
{
	public class GuestRegistryValueFault : GuestRegistryFault
	{
		protected string _keyName;
		protected string _valueName;
		public string KeyName
		{
			get
			{
				return this._keyName;
			}
			set
			{
				this._keyName = value;
			}
		}
		public string ValueName
		{
			get
			{
				return this._valueName;
			}
			set
			{
				this._valueName = value;
			}
		}
	}
}
