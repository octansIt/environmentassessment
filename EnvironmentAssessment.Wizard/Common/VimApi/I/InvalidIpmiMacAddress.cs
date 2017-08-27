namespace EnvironmentAssessment.Common.VimApi
{
	public class InvalidIpmiMacAddress : VimFault
	{
		protected string _userProvidedMacAddress;
		protected string _observedMacAddress;
		public string UserProvidedMacAddress
		{
			get
			{
				return this._userProvidedMacAddress;
			}
			set
			{
				this._userProvidedMacAddress = value;
			}
		}
		public string ObservedMacAddress
		{
			get
			{
				return this._observedMacAddress;
			}
			set
			{
				this._observedMacAddress = value;
			}
		}
	}
}
