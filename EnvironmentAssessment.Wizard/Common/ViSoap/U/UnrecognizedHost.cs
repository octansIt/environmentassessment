namespace EnvironmentAssessment.Common.VISoap
{
    public class UnrecognizedHost : VimFault
	{
		protected string _hostName;
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
	}
}
