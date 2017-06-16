namespace EnvironmentAssessment.Common.VISoap
{
    public class VmDiskFileInfo : FileInfo
	{
		protected string _diskType;
		protected long? _capacityKb;
		protected int? _hardwareVersion;
		protected string _controllerType;
		protected string[] _diskExtents;
		protected bool? _thin;
		public string DiskType
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
		public long? CapacityKb
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
		public int? HardwareVersion
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
		public string ControllerType
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
		public string[] DiskExtents
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
	}
}
