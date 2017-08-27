namespace EnvironmentAssessment.Common.VimApi
{
	public class HostVsanInternalSystemVsanObjectOperationResult : DynamicData
	{
		protected string _uuid;
		protected LocalizableMessage[] _failureReason;
		public string Uuid
		{
			get
			{
				return this._uuid;
			}
			set
			{
				this._uuid = value;
			}
		}
		public LocalizableMessage[] FailureReason
		{
			get
			{
				return this._failureReason;
			}
			set
			{
				this._failureReason = value;
			}
		}
	}
}
