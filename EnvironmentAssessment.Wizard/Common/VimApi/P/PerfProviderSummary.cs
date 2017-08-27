namespace EnvironmentAssessment.Common.VimApi
{
	public class PerfProviderSummary : DynamicData
	{
		protected ManagedObjectReference _entity;
		protected bool _currentSupported;
		protected bool _summarySupported;
		protected int? _refreshRate;
		public ManagedObjectReference Entity
		{
			get
			{
				return this._entity;
			}
			set
			{
				this._entity = value;
			}
		}
		public bool CurrentSupported
		{
			get
			{
				return this._currentSupported;
			}
			set
			{
				this._currentSupported = value;
			}
		}
		public bool SummarySupported
		{
			get
			{
				return this._summarySupported;
			}
			set
			{
				this._summarySupported = value;
			}
		}
		public int? RefreshRate
		{
			get
			{
				return this._refreshRate;
			}
			set
			{
				this._refreshRate = value;
			}
		}
	}
}
