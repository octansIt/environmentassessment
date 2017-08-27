using System;

namespace EnvironmentAssessment.Common.VimApi
{
	public class ClusterDrsMigration : DynamicData
	{
		protected string _key;
		protected DateTime _time;
		protected ManagedObjectReference _vm;
		protected int? _cpuLoad;
		protected long? _memoryLoad;
		protected ManagedObjectReference _source;
		protected int? _sourceCpuLoad;
		protected long? _sourceMemoryLoad;
		protected ManagedObjectReference _destination;
		protected int? _destinationCpuLoad;
		protected long? _destinationMemoryLoad;
		protected ClusterDrsMigration_LinkedView _linkedView;
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
		public DateTime Time
		{
			get
			{
				return this._time;
			}
			set
			{
				this._time = value;
			}
		}
		public ManagedObjectReference Vm
		{
			get
			{
				return this._vm;
			}
			set
			{
				this._vm = value;
			}
		}
		public int? CpuLoad
		{
			get
			{
				return this._cpuLoad;
			}
			set
			{
				this._cpuLoad = value;
			}
		}
		public long? MemoryLoad
		{
			get
			{
				return this._memoryLoad;
			}
			set
			{
				this._memoryLoad = value;
			}
		}
		public ManagedObjectReference Source
		{
			get
			{
				return this._source;
			}
			set
			{
				this._source = value;
			}
		}
		public int? SourceCpuLoad
		{
			get
			{
				return this._sourceCpuLoad;
			}
			set
			{
				this._sourceCpuLoad = value;
			}
		}
		public long? SourceMemoryLoad
		{
			get
			{
				return this._sourceMemoryLoad;
			}
			set
			{
				this._sourceMemoryLoad = value;
			}
		}
		public ManagedObjectReference Destination
		{
			get
			{
				return this._destination;
			}
			set
			{
				this._destination = value;
			}
		}
		public int? DestinationCpuLoad
		{
			get
			{
				return this._destinationCpuLoad;
			}
			set
			{
				this._destinationCpuLoad = value;
			}
		}
		public long? DestinationMemoryLoad
		{
			get
			{
				return this._destinationMemoryLoad;
			}
			set
			{
				this._destinationMemoryLoad = value;
			}
		}
		public ClusterDrsMigration_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
