namespace EnvironmentAssessment.Common.VimApi
{
	public class VirtualAppSummary : ResourcePoolSummary
	{
		protected VAppProductInfo _product;
		protected VirtualAppVAppState? _vAppState;
		protected bool? _suspended;
		protected bool? _installBootRequired;
		protected string _instanceUuid;
		public VAppProductInfo Product
		{
			get
			{
				return this._product;
			}
			set
			{
				this._product = value;
			}
		}
		public VirtualAppVAppState? VAppState
		{
			get
			{
				return this._vAppState;
			}
			set
			{
				this._vAppState = value;
			}
		}
		public bool? Suspended
		{
			get
			{
				return this._suspended;
			}
			set
			{
				this._suspended = value;
			}
		}
		public bool? InstallBootRequired
		{
			get
			{
				return this._installBootRequired;
			}
			set
			{
				this._installBootRequired = value;
			}
		}
		public string InstanceUuid
		{
			get
			{
				return this._instanceUuid;
			}
			set
			{
				this._instanceUuid = value;
			}
		}
	}
}
