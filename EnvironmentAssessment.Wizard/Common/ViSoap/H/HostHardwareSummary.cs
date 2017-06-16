namespace EnvironmentAssessment.Common.VISoap
{
    public class HostHardwareSummary : DynamicData
	{
		protected string _vendor;
		protected string _model;
		protected string _uuid;
		protected HostSystemIdentificationInfo[] _otherIdentifyingInfo;
		protected long _memorySize;
		protected string _cpuModel;
		protected int _cpuMhz;
		protected short _numCpuPkgs;
		protected short _numCpuCores;
		protected short _numCpuThreads;
		protected int _numNics;
		protected int _numHBAs;
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
		public string Model
		{
			get
			{
				return this._model;
			}
			set
			{
				this._model = value;
			}
		}
		public string Uuid
		{
			get
			{
				return this._uuid;
			}
			set
			{
				this._uuid = value;
			}
		}
		public HostSystemIdentificationInfo[] OtherIdentifyingInfo
		{
			get
			{
				return this._otherIdentifyingInfo;
			}
			set
			{
				this._otherIdentifyingInfo = value;
			}
		}
		public long MemorySize
		{
			get
			{
				return this._memorySize;
			}
			set
			{
				this._memorySize = value;
			}
		}
		public string CpuModel
		{
			get
			{
				return this._cpuModel;
			}
			set
			{
				this._cpuModel = value;
			}
		}
		public int CpuMhz
		{
			get
			{
				return this._cpuMhz;
			}
			set
			{
				this._cpuMhz = value;
			}
		}
		public short NumCpuPkgs
		{
			get
			{
				return this._numCpuPkgs;
			}
			set
			{
				this._numCpuPkgs = value;
			}
		}
		public short NumCpuCores
		{
			get
			{
				return this._numCpuCores;
			}
			set
			{
				this._numCpuCores = value;
			}
		}
		public short NumCpuThreads
		{
			get
			{
				return this._numCpuThreads;
			}
			set
			{
				this._numCpuThreads = value;
			}
		}
		public int NumNics
		{
			get
			{
				return this._numNics;
			}
			set
			{
				this._numNics = value;
			}
		}
		public int NumHBAs
		{
			get
			{
				return this._numHBAs;
			}
			set
			{
				this._numHBAs = value;
			}
		}
	}
}
