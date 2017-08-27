namespace EnvironmentAssessment.Common.VimApi
{
	public class VirtualMachineBootOptions : DynamicData
	{
		protected long? _bootDelay;
		protected bool? _enterBIOSSetup;
		protected bool? _efiSecureBootEnabled;
		protected bool? _bootRetryEnabled;
		protected long? _bootRetryDelay;
		protected VirtualMachineBootOptionsBootableDevice[] _bootOrder;
		protected string _networkBootProtocol;
		public long? BootDelay
		{
			get
			{
				return this._bootDelay;
			}
			set
			{
				this._bootDelay = value;
			}
		}
		public bool? EnterBIOSSetup
		{
			get
			{
				return this._enterBIOSSetup;
			}
			set
			{
				this._enterBIOSSetup = value;
			}
		}
		public bool? EfiSecureBootEnabled
		{
			get
			{
				return this._efiSecureBootEnabled;
			}
			set
			{
				this._efiSecureBootEnabled = value;
			}
		}
		public bool? BootRetryEnabled
		{
			get
			{
				return this._bootRetryEnabled;
			}
			set
			{
				this._bootRetryEnabled = value;
			}
		}
		public long? BootRetryDelay
		{
			get
			{
				return this._bootRetryDelay;
			}
			set
			{
				this._bootRetryDelay = value;
			}
		}
		public VirtualMachineBootOptionsBootableDevice[] BootOrder
		{
			get
			{
				return this._bootOrder;
			}
			set
			{
				this._bootOrder = value;
			}
		}
		public string NetworkBootProtocol
		{
			get
			{
				return this._networkBootProtocol;
			}
			set
			{
				this._networkBootProtocol = value;
			}
		}
	}
}
