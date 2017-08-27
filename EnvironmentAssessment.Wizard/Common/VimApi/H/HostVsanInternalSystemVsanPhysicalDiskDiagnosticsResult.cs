namespace EnvironmentAssessment.Common.VimApi
{
	public class HostVsanInternalSystemVsanPhysicalDiskDiagnosticsResult : DynamicData
	{
		protected string _diskUuid;
		protected bool _success;
		protected string _failureReason;
		public string DiskUuid
		{
			get
			{
				return this._diskUuid;
			}
			set
			{
				this._diskUuid = value;
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
		public string FailureReason
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
