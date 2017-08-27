namespace EnvironmentAssessment.Common.VimApi
{
	public class HostInternetScsiHbaDigestCapabilities : DynamicData
	{
		protected bool? _headerDigestSettable;
		protected bool? _dataDigestSettable;
		protected bool? _targetHeaderDigestSettable;
		protected bool? _targetDataDigestSettable;
		public bool? HeaderDigestSettable
		{
			get
			{
				return this._headerDigestSettable;
			}
			set
			{
				this._headerDigestSettable = value;
			}
		}
		public bool? DataDigestSettable
		{
			get
			{
				return this._dataDigestSettable;
			}
			set
			{
				this._dataDigestSettable = value;
			}
		}
		public bool? TargetHeaderDigestSettable
		{
			get
			{
				return this._targetHeaderDigestSettable;
			}
			set
			{
				this._targetHeaderDigestSettable = value;
			}
		}
		public bool? TargetDataDigestSettable
		{
			get
			{
				return this._targetDataDigestSettable;
			}
			set
			{
				this._targetDataDigestSettable = value;
			}
		}
	}
}
