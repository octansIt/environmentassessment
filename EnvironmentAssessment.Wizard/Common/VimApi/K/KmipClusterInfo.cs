namespace EnvironmentAssessment.Common.VimApi
{
	public class KmipClusterInfo : DynamicData
	{
		protected KeyProviderId _clusterId;
		protected KmipServerInfo[] _servers;
		protected bool _useAsDefault;
		public KeyProviderId ClusterId
		{
			get
			{
				return this._clusterId;
			}
			set
			{
				this._clusterId = value;
			}
		}
		public KmipServerInfo[] Servers
		{
			get
			{
				return this._servers;
			}
			set
			{
				this._servers = value;
			}
		}
		public bool UseAsDefault
		{
			get
			{
				return this._useAsDefault;
			}
			set
			{
				this._useAsDefault = value;
			}
		}
	}
}
