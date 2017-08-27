namespace EnvironmentAssessment.Common.VimApi
{
	public class HostHasComponentFailure : VimFault
	{
		protected string _hostName;
		protected string _componentType;
		protected string _componentName;
		public string HostName
		{
			get
			{
				return this._hostName;
			}
			set
			{
				this._hostName = value;
			}
		}
		public string ComponentType
		{
			get
			{
				return this._componentType;
			}
			set
			{
				this._componentType = value;
			}
		}
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
	}
}
