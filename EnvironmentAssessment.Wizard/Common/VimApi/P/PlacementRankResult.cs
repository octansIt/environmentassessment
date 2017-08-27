namespace EnvironmentAssessment.Common.VimApi
{
	public class PlacementRankResult : DynamicData
	{
		protected string _key;
		protected ManagedObjectReference _candidate;
		protected long _reservedSpaceMB;
		protected long _usedSpaceMB;
		protected long _totalSpaceMB;
		protected double _utilization;
		protected LocalizedMethodFault[] _faults;
		protected PlacementRankResult_LinkedView _linkedView;
		public string Key
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
		public ManagedObjectReference Candidate
		{
			get
			{
				return this._candidate;
			}
			set
			{
				this._candidate = value;
			}
		}
		public long ReservedSpaceMB
		{
			get
			{
				return this._reservedSpaceMB;
			}
			set
			{
				this._reservedSpaceMB = value;
			}
		}
		public long UsedSpaceMB
		{
			get
			{
				return this._usedSpaceMB;
			}
			set
			{
				this._usedSpaceMB = value;
			}
		}
		public long TotalSpaceMB
		{
			get
			{
				return this._totalSpaceMB;
			}
			set
			{
				this._totalSpaceMB = value;
			}
		}
		public double Utilization
		{
			get
			{
				return this._utilization;
			}
			set
			{
				this._utilization = value;
			}
		}
		public LocalizedMethodFault[] Faults
		{
			get
			{
				return this._faults;
			}
			set
			{
				this._faults = value;
			}
		}
		public PlacementRankResult_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
