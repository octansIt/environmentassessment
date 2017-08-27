namespace EnvironmentAssessment.Common.VimApi
{
	public class MethodFault
	{
		protected LocalizedMethodFault _faultCause;
		protected LocalizableMessage[] _faultMessage;
		public LocalizedMethodFault FaultCause
		{
			get
			{
				return this._faultCause;
			}
			set
			{
				this._faultCause = value;
			}
		}
		public LocalizableMessage[] FaultMessage
		{
			get
			{
				return this._faultMessage;
			}
			set
			{
				this._faultMessage = value;
			}
		}
	}
}
