namespace EnvironmentAssessment.Common.VISoap
{
    public class HostCpuPackage : DynamicData
	{
		protected short _index;
		protected string _vendor;
		protected long _hz;
		protected long _busHz;
		protected string _description;
		protected short[] _threadId;
		protected HostCpuIdInfo[] _cpuFeature;
		public short Index
		{
			get
			{
				return this._index;
			}
			set
			{
				this._index = value;
			}
		}
		public string Vendor
		{
			get
			{
				return this._vendor;
			}
			set
			{
				this._vendor = value;
			}
		}
		public long Hz
		{
			get
			{
				return this._hz;
			}
			set
			{
				this._hz = value;
			}
		}
		public long BusHz
		{
			get
			{
				return this._busHz;
			}
			set
			{
				this._busHz = value;
			}
		}
		public string Description
		{
			get
			{
				return this._description;
			}
			set
			{
				this._description = value;
			}
		}
		public short[] ThreadId
		{
			get
			{
				return this._threadId;
			}
			set
			{
				this._threadId = value;
			}
		}
		public HostCpuIdInfo[] CpuFeature
		{
			get
			{
				return this._cpuFeature;
			}
			set
			{
				this._cpuFeature = value;
			}
		}
	}
}
