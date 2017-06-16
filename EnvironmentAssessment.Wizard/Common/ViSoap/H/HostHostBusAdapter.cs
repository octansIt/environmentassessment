namespace EnvironmentAssessment.Common.VISoap
{
    public class HostHostBusAdapter : DynamicData
	{
		protected string _key;
		protected string _device;
		protected int _bus;
		protected string _status;
		protected string _model;
		protected string _driver;
		protected string _pci;
		public string Key
		{
			get
			{
				return this._key;
			}
			set
			{
				this._key = value;
			}
		}
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
		public int Bus
		{
			get
			{
				return this._bus;
			}
			set
			{
				this._bus = value;
			}
		}
		public string Status
		{
			get
			{
				return this._status;
			}
			set
			{
				this._status = value;
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
		public string Driver
		{
			get
			{
				return this._driver;
			}
			set
			{
				this._driver = value;
			}
		}
		public string Pci
		{
			get
			{
				return this._pci;
			}
			set
			{
				this._pci = value;
			}
		}
	}
}
