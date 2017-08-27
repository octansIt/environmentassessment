namespace EnvironmentAssessment.Common.VimApi
{
	public class ClusterNetworkConfigSpec_LinkedView
	{
		protected Network _networkPortGroup;
		public Network NetworkPortGroup
		{
			get
			{
				return this._networkPortGroup;
			}
			set
			{
				this._networkPortGroup = value;
			}
		}
	}
}
