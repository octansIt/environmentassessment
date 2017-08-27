namespace EnvironmentAssessment.Common.VimApi
{
	public class HostProtocolEndpoint_LinkedView
	{
		protected HostSystem[] _hostKey;
		public HostSystem[] HostKey
		{
			get
			{
				return this._hostKey;
			}
			set
			{
				this._hostKey = value;
			}
		}
	}
}
