namespace EnvironmentAssessment.Common.VimApi
{
	public class NetDhcpConfigInfoDhcpOptions : DynamicData
	{
		protected bool _enable;
		protected KeyValue[] _config;
		public bool Enable
		{
			get
			{
				return this._enable;
			}
			set
			{
				this._enable = value;
			}
		}
		public KeyValue[] Config
		{
			get
			{
				return this._config;
			}
			set
			{
				this._config = value;
			}
		}
	}
}
