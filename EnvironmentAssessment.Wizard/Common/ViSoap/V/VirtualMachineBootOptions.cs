namespace EnvironmentAssessment.Common.VISoap
{
    public class VirtualMachineBootOptions : DynamicData
	{
		protected long? _bootDelay;
		protected bool? _enterBIOSSetup;
		protected bool? _bootRetryEnabled;
		protected long? _bootRetryDelay;
		protected VirtualMachineBootOptionsBootableDevice[] _bootOrder;
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
	}
}
