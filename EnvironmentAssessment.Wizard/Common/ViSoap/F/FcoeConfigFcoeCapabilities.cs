namespace EnvironmentAssessment.Common.VISoap
{
    public class FcoeConfigFcoeCapabilities : DynamicData
	{
		protected bool _priorityClass;
		protected bool _sourceMacAddress;
		protected bool _vlanRange;
		public bool PriorityClass
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
		public bool SourceMacAddress
		{
			get
			{
				return this._sourceMacAddress;
			}
			set
			{
				this._sourceMacAddress = value;
			}
		}
		public bool VlanRange
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
