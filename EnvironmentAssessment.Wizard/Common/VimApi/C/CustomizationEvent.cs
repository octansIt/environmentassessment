namespace EnvironmentAssessment.Common.VimApi
{
	public class CustomizationEvent : VmEvent
	{
		protected string _logLocation;
		public string LogLocation
		{
			get
			{
				return this._logLocation;
			}
			set
			{
				this._logLocation = value;
			}
		}
	}
}
