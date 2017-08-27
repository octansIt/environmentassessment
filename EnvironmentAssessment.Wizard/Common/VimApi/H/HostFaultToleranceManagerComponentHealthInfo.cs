namespace EnvironmentAssessment.Common.VimApi
{
	public class HostFaultToleranceManagerComponentHealthInfo : DynamicData
	{
		protected bool _isStorageHealthy;
		protected bool _isNetworkHealthy;
		public bool IsStorageHealthy
		{
			get
			{
				return this._isStorageHealthy;
			}
			set
			{
				this._isStorageHealthy = value;
			}
		}
		public bool IsNetworkHealthy
		{
			get
			{
				return this._isNetworkHealthy;
			}
			set
			{
				this._isNetworkHealthy = value;
			}
		}
	}
}
