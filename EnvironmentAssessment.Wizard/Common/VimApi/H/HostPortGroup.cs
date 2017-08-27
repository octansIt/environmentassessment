namespace EnvironmentAssessment.Common.VimApi
{
	public class HostPortGroup : DynamicData
	{
		protected string _key;
		protected HostPortGroupPort[] _port;
		protected string _vswitch;
		protected HostNetworkPolicy _computedPolicy;
		protected HostPortGroupSpec _spec;
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
		public HostPortGroupPort[] Port
		{
			get
			{
				return this._port;
			}
			set
			{
				this._port = value;
			}
		}
		public string Vswitch
		{
			get
			{
				return this._vswitch;
			}
			set
			{
				this._vswitch = value;
			}
		}
		public HostNetworkPolicy ComputedPolicy
		{
			get
			{
				return this._computedPolicy;
			}
			set
			{
				this._computedPolicy = value;
			}
		}
		public HostPortGroupSpec Spec
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
