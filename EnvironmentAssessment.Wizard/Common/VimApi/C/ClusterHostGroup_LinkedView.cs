namespace EnvironmentAssessment.Common.VimApi
{
	public class ClusterHostGroup_LinkedView
	{
		protected HostSystem[] _host;
		public HostSystem[] Host
		{
			get
			{
				return this._host;
			}
			set
			{
				this._host = value;
			}
		}
	}
}
