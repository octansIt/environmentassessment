namespace EnvironmentAssessment.Common.VimApi
{
	public class HostLowLevelProvisioningManagerDiskLayoutSpec : DynamicData
	{
		protected string _controllerType;
		protected int _busNumber;
		protected int _unitNumber;
		protected string _srcFilename;
		protected string _dstFilename;
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
		public int BusNumber
		{
			get
			{
				return this._busNumber;
			}
			set
			{
				this._busNumber = value;
			}
		}
		public int UnitNumber
		{
			get
			{
				return this._unitNumber;
			}
			set
			{
				this._unitNumber = value;
			}
		}
		public string SrcFilename
		{
			get
			{
				return this._srcFilename;
			}
			set
			{
				this._srcFilename = value;
			}
		}
		public string DstFilename
		{
			get
			{
				return this._dstFilename;
			}
			set
			{
				this._dstFilename = value;
			}
		}
	}
}
