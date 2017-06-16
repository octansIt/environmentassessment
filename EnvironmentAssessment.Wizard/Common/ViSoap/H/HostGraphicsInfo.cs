namespace EnvironmentAssessment.Common.VISoap
{
    public class HostGraphicsInfo : DynamicData
	{
		protected string _deviceName;
		protected string _vendorName;
		protected string _pciId;
		protected string _graphicsType;
		protected long _memorySizeInKB;
		protected ManagedObjectReference[] _vm;
		protected HostGraphicsInfo_LinkedView _linkedView;
		public string DeviceName
		{
			get
			{
				return this._deviceName;
			}
			set
			{
				this._deviceName = value;
			}
		}
		public string VendorName
		{
			get
			{
				return this._vendorName;
			}
			set
			{
				this._vendorName = value;
			}
		}
		public string PciId
		{
			get
			{
				return this._pciId;
			}
			set
			{
				this._pciId = value;
			}
		}
		public string GraphicsType
		{
			get
			{
				return this._graphicsType;
			}
			set
			{
				this._graphicsType = value;
			}
		}
		public long MemorySizeInKB
		{
			get
			{
				return this._memorySizeInKB;
			}
			set
			{
				this._memorySizeInKB = value;
			}
		}
		public ManagedObjectReference[] Vm
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
		public HostGraphicsInfo_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
