namespace EnvironmentAssessment.Common.VimApi
{
	public class OvfConsumerFault : OvfConsumerCallbackFault
	{
		protected string _errorKey;
		protected string _message;
		protected KeyValue[] _params;
		public string ErrorKey
		{
			get
			{
				return this._errorKey;
			}
			set
			{
				this._errorKey = value;
			}
		}
		public string Message
		{
			get
			{
				return this._message;
			}
			set
			{
				this._message = value;
			}
		}
		public KeyValue[] Params
		{
			get
			{
				return this._params;
			}
			set
			{
				this._params = value;
			}
		}
	}
}
