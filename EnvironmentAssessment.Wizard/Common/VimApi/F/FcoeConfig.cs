namespace EnvironmentAssessment.Common.VimApi
{
	public class FcoeConfig : DynamicData
	{
		protected int _priorityClass;
		protected string _sourceMac;
		protected FcoeConfigVlanRange[] _vlanRange;
		protected FcoeConfigFcoeCapabilities _capabilities;
		protected bool _fcoeActive;
		public int PriorityClass
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
		public FcoeConfigFcoeCapabilities Capabilities
		{
			get
			{
				return this._capabilities;
			}
			set
			{
				this._capabilities = value;
			}
		}
		public bool FcoeActive
		{
			get
			{
				return this._fcoeActive;
			}
			set
			{
				this._fcoeActive = value;
			}
		}
	}
}
