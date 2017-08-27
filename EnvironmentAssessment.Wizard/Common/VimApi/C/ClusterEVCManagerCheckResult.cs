namespace EnvironmentAssessment.Common.VimApi
{
	public class ClusterEVCManagerCheckResult : DynamicData
	{
		protected string _evcModeKey;
		protected LocalizedMethodFault _error;
		protected ManagedObjectReference[] _host;
		protected ClusterEVCManagerCheckResult_LinkedView _linkedView;
		public string EvcModeKey
		{
			get
			{
				return this._evcModeKey;
			}
			set
			{
				this._evcModeKey = value;
			}
		}
		public LocalizedMethodFault Error
		{
			get
			{
				return this._error;
			}
			set
			{
				this._error = value;
			}
		}
		public ManagedObjectReference[] Host
		{
			get
			{
				return this._host;
			}
			set
			{
				this._host = value;
			}
		}
		public ClusterEVCManagerCheckResult_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
