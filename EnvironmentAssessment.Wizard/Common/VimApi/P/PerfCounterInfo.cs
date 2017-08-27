namespace EnvironmentAssessment.Common.VimApi
{
	public class PerfCounterInfo : DynamicData
	{
		protected int _key;
		protected ElementDescription _nameInfo;
		protected ElementDescription _groupInfo;
		protected ElementDescription _unitInfo;
		protected PerfSummaryType _rollupType;
		protected PerfStatsType _statsType;
		protected int? _level;
		protected int? _perDeviceLevel;
		protected int[] _associatedCounterId;
		public int Key
		{
			get
			{
				return this._key;
			}
			set
			{
				this._key = value;
			}
		}
		public ElementDescription NameInfo
		{
			get
			{
				return this._nameInfo;
			}
			set
			{
				this._nameInfo = value;
			}
		}
		public ElementDescription GroupInfo
		{
			get
			{
				return this._groupInfo;
			}
			set
			{
				this._groupInfo = value;
			}
		}
		public ElementDescription UnitInfo
		{
			get
			{
				return this._unitInfo;
			}
			set
			{
				this._unitInfo = value;
			}
		}
		public PerfSummaryType RollupType
		{
			get
			{
				return this._rollupType;
			}
			set
			{
				this._rollupType = value;
			}
		}
		public PerfStatsType StatsType
		{
			get
			{
				return this._statsType;
			}
			set
			{
				this._statsType = value;
			}
		}
		public int? Level
		{
			get
			{
				return this._level;
			}
			set
			{
				this._level = value;
			}
		}
		public int? PerDeviceLevel
		{
			get
			{
				return this._perDeviceLevel;
			}
			set
			{
				this._perDeviceLevel = value;
			}
		}
		public int[] AssociatedCounterId
		{
			get
			{
				return this._associatedCounterId;
			}
			set
			{
				this._associatedCounterId = value;
			}
		}
	}
}
