namespace EnvironmentAssessment.Common.VimApi
{
	public class CannotUseNetwork : VmConfigFault
	{
		protected string _device;
		protected string _backing;
		protected bool _connected;
		protected string _reason;
		protected ManagedObjectReference _network;
		protected CannotUseNetwork_LinkedView _linkedView;
		public string Device
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
		public string Backing
		{
			get
			{
				return this._backing;
			}
			set
			{
				this._backing = value;
			}
		}
		public bool Connected
		{
			get
			{
				return this._connected;
			}
			set
			{
				this._connected = value;
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
		public ManagedObjectReference Network
		{
			get
			{
				return this._network;
			}
			set
			{
				this._network = value;
			}
		}
		public CannotUseNetwork_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
