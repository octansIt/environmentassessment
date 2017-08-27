namespace EnvironmentAssessment.Common.VimApi
{
	public class VirtualMachineScsiPassthroughInfo : VirtualMachineTargetInfo
	{
		protected string _scsiClass;
		protected string _vendor;
		protected int _physicalUnitNumber;
		public string ScsiClass
		{
			get
			{
				return this._scsiClass;
			}
			set
			{
				this._scsiClass = value;
			}
		}
		public string Vendor
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
		public int PhysicalUnitNumber
		{
			get
			{
				return this._physicalUnitNumber;
			}
			set
			{
				this._physicalUnitNumber = value;
			}
		}
	}
}
