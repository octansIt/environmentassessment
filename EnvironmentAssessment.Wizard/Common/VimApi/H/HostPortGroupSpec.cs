namespace EnvironmentAssessment.Common.VimApi
{
	public class HostPortGroupSpec : DynamicData
	{
		protected string _name;
		protected int _vlanId;
		protected string _vswitchName;
		protected HostNetworkPolicy _policy;
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				this._name = value;
			}
		}
		public int VlanId
		{
			get
			{
				return this._vlanId;
			}
			set
			{
				this._vlanId = value;
			}
		}
		public string VswitchName
		{
			get
			{
				return this._vswitchName;
			}
			set
			{
				this._vswitchName = value;
			}
		}
		public HostNetworkPolicy Policy
		{
			get
			{
				return this._policy;
			}
			set
			{
				this._policy = value;
			}
		}
	}
}
