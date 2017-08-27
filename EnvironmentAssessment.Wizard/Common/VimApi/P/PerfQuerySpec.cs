using System;

namespace EnvironmentAssessment.Common.VimApi
{
	public class PerfQuerySpec : DynamicData
	{
		protected ManagedObjectReference _entity;
		protected DateTime? _startTime;
		protected DateTime? _endTime;
		protected int? _maxSample;
		protected PerfMetricId[] _metricId;
		protected int? _intervalId;
		protected string _format;
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
		public DateTime? StartTime
		{
			get
			{
				return this._startTime;
			}
			set
			{
				this._startTime = value;
			}
		}
		public DateTime? EndTime
		{
			get
			{
				return this._endTime;
			}
			set
			{
				this._endTime = value;
			}
		}
		public int? MaxSample
		{
			get
			{
				return this._maxSample;
			}
			set
			{
				this._maxSample = value;
			}
		}
		public PerfMetricId[] MetricId
		{
			get
			{
				return this._metricId;
			}
			set
			{
				this._metricId = value;
			}
		}
		public int? IntervalId
		{
			get
			{
				return this._intervalId;
			}
			set
			{
				this._intervalId = value;
			}
		}
		public string Format
		{
			get
			{
				return this._format;
			}
			set
			{
				this._format = value;
			}
		}
	}
}
