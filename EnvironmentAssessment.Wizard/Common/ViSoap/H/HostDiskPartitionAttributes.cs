namespace EnvironmentAssessment.Common.VISoap
{
    public class HostDiskPartitionAttributes : DynamicData
	{
		protected int _partition;
		protected long _startSector;
		protected long _endSector;
		protected string _type;
		protected string _guid;
		protected bool _logical;
		protected sbyte _attributes;
		protected long? _partitionAlignment;
		public int Partition
		{
			get
			{
				return this._partition;
			}
			set
			{
				this._partition = value;
			}
		}
		public long StartSector
		{
			get
			{
				return this._startSector;
			}
			set
			{
				this._startSector = value;
			}
		}
		public long EndSector
		{
			get
			{
				return this._endSector;
			}
			set
			{
				this._endSector = value;
			}
		}
		public string Type
		{
			get
			{
				return this._type;
			}
			set
			{
				this._type = value;
			}
		}
		public string Guid
		{
			get
			{
				return this._guid;
			}
			set
			{
				this._guid = value;
			}
		}
		public bool Logical
		{
			get
			{
				return this._logical;
			}
			set
			{
				this._logical = value;
			}
		}
		public sbyte Attributes
		{
			get
			{
				return this._attributes;
			}
			set
			{
				this._attributes = value;
			}
		}
		public long? PartitionAlignment
		{
			get
			{
				return this._partitionAlignment;
			}
			set
			{
				this._partitionAlignment = value;
			}
		}
	}
}
