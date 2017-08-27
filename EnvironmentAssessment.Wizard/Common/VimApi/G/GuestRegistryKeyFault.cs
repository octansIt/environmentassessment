namespace EnvironmentAssessment.Common.VimApi
{
	public class GuestRegistryKeyFault : GuestRegistryFault
	{
		protected string _keyName;
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
	}
}
