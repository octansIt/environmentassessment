namespace EnvironmentAssessment.Common.VimApi
{
	public class FcoeConfigFcoeSpecification : DynamicData
	{
		protected string _underlyingPnic;
		protected int? _priorityClass;
		protected string _sourceMac;
		protected FcoeConfigVlanRange[] _vlanRange;
		public string UnderlyingPnic
		{
			get
			{
				return this._underlyingPnic;
			}
			set
			{
				this._underlyingPnic = value;
			}
		}
		public int? PriorityClass
		{
			get
			{
				return this._priorityClass;
			}
			set
			{
				this._priorityClass = value;
			}
		}
		public string SourceMac
		{
			get
			{
				return this._sourceMac;
			}
			set
			{
				this._sourceMac = value;
			}
		}
		public FcoeConfigVlanRange[] VlanRange
		{
			get
			{
				return this._vlanRange;
			}
			set
			{
				this._vlanRange = value;
			}
		}
	}
}
