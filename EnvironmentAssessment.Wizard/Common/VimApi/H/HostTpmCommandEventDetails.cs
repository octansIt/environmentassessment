namespace EnvironmentAssessment.Common.VimApi
{
	public class HostTpmCommandEventDetails : HostTpmEventDetails
	{
		protected string _commandLine;
		public string CommandLine
		{
			get
			{
				return this._commandLine;
			}
			set
			{
				this._commandLine = value;
			}
		}
	}
}
