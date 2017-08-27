namespace EnvironmentAssessment.Common.VimApi
{
	public class VmDiskFileQueryFlags : DynamicData
	{
		protected bool _diskType;
		protected bool _capacityKb;
		protected bool _hardwareVersion;
		protected bool? _controllerType;
		protected bool? _diskExtents;
		protected bool? _thin;
		protected bool? _encryption;
		public bool DiskType
		{
			get
			{
				return this._diskType;
			}
			set
			{
				this._diskType = value;
			}
		}
		public bool CapacityKb
		{
			get
			{
				return this._capacityKb;
			}
			set
			{
				this._capacityKb = value;
			}
		}
		public bool HardwareVersion
		{
			get
			{
				return this._hardwareVersion;
			}
			set
			{
				this._hardwareVersion = value;
			}
		}
		public bool? ControllerType
		{
			get
			{
				return this._controllerType;
			}
			set
			{
				this._controllerType = value;
			}
		}
		public bool? DiskExtents
		{
			get
			{
				return this._diskExtents;
			}
			set
			{
				this._diskExtents = value;
			}
		}
		public bool? Thin
		{
			get
			{
				return this._thin;
			}
			set
			{
				this._thin = value;
			}
		}
		public bool? Encryption
		{
			get
			{
				return this._encryption;
			}
			set
			{
				this._encryption = value;
			}
		}
	}
}
