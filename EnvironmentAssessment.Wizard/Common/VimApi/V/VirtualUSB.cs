namespace EnvironmentAssessment.Common.VimApi
{
	public class VirtualUSB : VirtualDevice
	{
		protected bool _connected;
		protected int? _vendor;
		protected int? _product;
		protected string[] _family;
		protected string[] _speed;
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
		public int? Vendor
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
		public int? Product
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
		public string[] Family
		{
			get
			{
				return this._family;
			}
			set
			{
				this._family = value;
			}
		}
		public string[] Speed
		{
			get
			{
				return this._speed;
			}
			set
			{
				this._speed = value;
			}
		}
	}
}
