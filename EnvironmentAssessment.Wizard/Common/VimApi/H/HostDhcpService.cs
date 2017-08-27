namespace EnvironmentAssessment.Common.VimApi
{
	public class HostDhcpService : DynamicData
	{
		protected string _key;
		protected HostDhcpServiceSpec _spec;
		public string Key
		{
			get
			{
				return this._key;
			}
			set
			{
				this._key = value;
			}
		}
		public HostDhcpServiceSpec Spec
		{
			get
			{
				return this._spec;
			}
			set
			{
				this._spec = value;
			}
		}
	}
}
