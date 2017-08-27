namespace EnvironmentAssessment.Common.VimApi
{
	public class HostTpmSoftwareComponentEventDetails : HostTpmEventDetails
	{
		protected string _componentName;
		protected string _vibName;
		protected string _vibVersion;
		protected string _vibVendor;
		public string ComponentName
		{
			get
			{
				return this._componentName;
			}
			set
			{
				this._componentName = value;
			}
		}
		public string VibName
		{
			get
			{
				return this._vibName;
			}
			set
			{
				this._vibName = value;
			}
		}
		public string VibVersion
		{
			get
			{
				return this._vibVersion;
			}
			set
			{
				this._vibVersion = value;
			}
		}
		public string VibVendor
		{
			get
			{
				return this._vibVendor;
			}
			set
			{
				this._vibVendor = value;
			}
		}
	}
}
