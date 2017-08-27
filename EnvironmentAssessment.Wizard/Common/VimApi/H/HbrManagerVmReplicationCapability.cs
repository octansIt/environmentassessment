namespace EnvironmentAssessment.Common.VimApi
{
	public class HbrManagerVmReplicationCapability : DynamicData
	{
		protected ManagedObjectReference _vm;
		protected string _supportedQuiesceMode;
		protected bool _compressionSupported;
		protected long _maxSupportedSourceDiskCapacity;
		protected long? _minRpo;
		protected LocalizedMethodFault _fault;
		protected HbrManagerVmReplicationCapability_LinkedView _linkedView;
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
		public string SupportedQuiesceMode
		{
			get
			{
				return this._supportedQuiesceMode;
			}
			set
			{
				this._supportedQuiesceMode = value;
			}
		}
		public bool CompressionSupported
		{
			get
			{
				return this._compressionSupported;
			}
			set
			{
				this._compressionSupported = value;
			}
		}
		public long MaxSupportedSourceDiskCapacity
		{
			get
			{
				return this._maxSupportedSourceDiskCapacity;
			}
			set
			{
				this._maxSupportedSourceDiskCapacity = value;
			}
		}
		public long? MinRpo
		{
			get
			{
				return this._minRpo;
			}
			set
			{
				this._minRpo = value;
			}
		}
		public LocalizedMethodFault Fault
		{
			get
			{
				return this._fault;
			}
			set
			{
				this._fault = value;
			}
		}
		public HbrManagerVmReplicationCapability_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
