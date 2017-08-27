namespace EnvironmentAssessment.Common.VimApi
{
	public class ImportHostAddFailure : DvsFault
	{
		protected string[] _hostIp;
		public string[] HostIp
		{
			get
			{
				return this._hostIp;
			}
			set
			{
				this._hostIp = value;
			}
		}
	}
}
