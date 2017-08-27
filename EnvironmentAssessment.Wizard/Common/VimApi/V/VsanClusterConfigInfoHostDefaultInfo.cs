namespace EnvironmentAssessment.Common.VimApi
{
	public class VsanClusterConfigInfoHostDefaultInfo : DynamicData
	{
		protected string _uuid;
		protected bool? _autoClaimStorage;
		protected bool? _checksumEnabled;
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
		public bool? AutoClaimStorage
		{
			get
			{
				return this._autoClaimStorage;
			}
			set
			{
				this._autoClaimStorage = value;
			}
		}
		public bool? ChecksumEnabled
		{
			get
			{
				return this._checksumEnabled;
			}
			set
			{
				this._checksumEnabled = value;
			}
		}
	}
}
