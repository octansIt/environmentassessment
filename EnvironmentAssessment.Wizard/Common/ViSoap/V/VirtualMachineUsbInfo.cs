namespace EnvironmentAssessment.Common.VISoap
{
    public class VirtualMachineUsbInfo : VirtualMachineTargetInfo
	{
		protected string _description;
		protected int _vendor;
		protected int _product;
		protected string _physicalPath;
		protected string[] _family;
		protected string[] _speed;
		protected VirtualMachineSummary _summary;
		public string Description
		{
			get
			{
				return this._description;
			}
			set
			{
				this._description = value;
			}
		}
		public int Vendor
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
		public int Product
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
		public string PhysicalPath
		{
			get
			{
				return this._physicalPath;
			}
			set
			{
				this._physicalPath = value;
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
		public VirtualMachineSummary Summary
		{
			get
			{
				return this._summary;
			}
			set
			{
				this._summary = value;
			}
		}
	}
}
