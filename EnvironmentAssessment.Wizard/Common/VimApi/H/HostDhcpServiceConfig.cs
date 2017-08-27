namespace EnvironmentAssessment.Common.VimApi
{
	public class HostDhcpServiceConfig : DynamicData
	{
		protected string _changeOperation;
		protected string _key;
		protected HostDhcpServiceSpec _spec;
		public string ChangeOperation
		{
			get
			{
				return this._changeOperation;
			}
			set
			{
				this._changeOperation = value;
			}
		}
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
