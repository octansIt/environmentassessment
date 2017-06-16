namespace EnvironmentAssessment.Common.VISoap
{
    public class VirtualHardware : DynamicData
	{
		protected int _numCPU;
		protected int? _numCoresPerSocket;
		protected int _memoryMB;
		protected bool? _virtualICH7MPresent;
		protected bool? _virtualSMCPresent;
		protected VirtualDevice[] _device;
		public int NumCPU
		{
			get
			{
				return this._numCPU;
			}
			set
			{
				this._numCPU = value;
			}
		}
		public int? NumCoresPerSocket
		{
			get
			{
				return this._numCoresPerSocket;
			}
			set
			{
				this._numCoresPerSocket = value;
			}
		}
		public int MemoryMB
		{
			get
			{
				return this._memoryMB;
			}
			set
			{
				this._memoryMB = value;
			}
		}
		public bool? VirtualICH7MPresent
		{
			get
			{
				return this._virtualICH7MPresent;
			}
			set
			{
				this._virtualICH7MPresent = value;
			}
		}
		public bool? VirtualSMCPresent
		{
			get
			{
				return this._virtualSMCPresent;
			}
			set
			{
				this._virtualSMCPresent = value;
			}
		}
		public VirtualDevice[] Device
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
	}
}
