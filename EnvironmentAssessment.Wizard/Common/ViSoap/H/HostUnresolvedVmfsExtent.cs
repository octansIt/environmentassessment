namespace EnvironmentAssessment.Common.VISoap
{
    public class HostUnresolvedVmfsExtent : DynamicData
	{
		protected HostScsiDiskPartition _device;
		protected string _devicePath;
		protected string _vmfsUuid;
		protected bool _isHeadExtent;
		protected int _ordinal;
		protected int _startBlock;
		protected int _endBlock;
		protected string _reason;
		public HostScsiDiskPartition Device
		{
			get
			{
				return this._device;
			}
			set
			{
				this._device = value;
			}
		}
		public string DevicePath
		{
			get
			{
				return this._devicePath;
			}
			set
			{
				this._devicePath = value;
			}
		}
		public string VmfsUuid
		{
			get
			{
				return this._vmfsUuid;
			}
			set
			{
				this._vmfsUuid = value;
			}
		}
		public bool IsHeadExtent
		{
			get
			{
				return this._isHeadExtent;
			}
			set
			{
				this._isHeadExtent = value;
			}
		}
		public int Ordinal
		{
			get
			{
				return this._ordinal;
			}
			set
			{
				this._ordinal = value;
			}
		}
		public int StartBlock
		{
			get
			{
				return this._startBlock;
			}
			set
			{
				this._startBlock = value;
			}
		}
		public int EndBlock
		{
			get
			{
				return this._endBlock;
			}
			set
			{
				this._endBlock = value;
			}
		}
		public string Reason
		{
			get
			{
				return this._reason;
			}
			set
			{
				this._reason = value;
			}
		}
	}
}
