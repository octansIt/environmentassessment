namespace EnvironmentAssessment.Common.VimApi
{
	public class HostVsanInternalSystemDeleteVsanObjectsResult : DynamicData
	{
		protected string _uuid;
		protected bool _success;
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
		public bool Success
		{
			get
			{
				return this._success;
			}
			set
			{
				this._success = value;
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
