namespace EnvironmentAssessment.Common.VISoap
{
    public class StoragePerformanceSummary : DynamicData
	{
		protected int _interval;
		protected int[] _percentile;
		protected double[] _datastoreReadLatency;
		protected double[] _datastoreWriteLatency;
		protected double[] _datastoreVmLatency;
		protected double[] _datastoreReadIops;
		protected double[] _datastoreWriteIops;
		protected int _siocActivityDuration;
		public int Interval
		{
			get
			{
				return this._interval;
			}
			set
			{
				this._interval = value;
			}
		}
		public int[] Percentile
		{
			get
			{
				return this._percentile;
			}
			set
			{
				this._percentile = value;
			}
		}
		public double[] DatastoreReadLatency
		{
			get
			{
				return this._datastoreReadLatency;
			}
			set
			{
				this._datastoreReadLatency = value;
			}
		}
		public double[] DatastoreWriteLatency
		{
			get
			{
				return this._datastoreWriteLatency;
			}
			set
			{
				this._datastoreWriteLatency = value;
			}
		}
		public double[] DatastoreVmLatency
		{
			get
			{
				return this._datastoreVmLatency;
			}
			set
			{
				this._datastoreVmLatency = value;
			}
		}
		public double[] DatastoreReadIops
		{
			get
			{
				return this._datastoreReadIops;
			}
			set
			{
				this._datastoreReadIops = value;
			}
		}
		public double[] DatastoreWriteIops
		{
			get
			{
				return this._datastoreWriteIops;
			}
			set
			{
				this._datastoreWriteIops = value;
			}
		}
		public int SiocActivityDuration
		{
			get
			{
				return this._siocActivityDuration;
			}
			set
			{
				this._siocActivityDuration = value;
			}
		}
	}
}
