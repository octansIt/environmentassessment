namespace EnvironmentAssessment.Common.VimApi
{
	public class HostProxySwitchConfig : DynamicData
	{
		protected string _changeOperation;
		protected string _uuid;
		protected HostProxySwitchSpec _spec;
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
		public string Uuid
		{
			get
			{
				return this._uuid;
			}
			set
			{
				this._uuid = value;
			}
		}
		public HostProxySwitchSpec Spec
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
