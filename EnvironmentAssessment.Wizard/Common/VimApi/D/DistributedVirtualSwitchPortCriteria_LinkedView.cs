namespace EnvironmentAssessment.Common.VimApi
{
	public class DistributedVirtualSwitchPortCriteria_LinkedView
	{
		protected ManagedEntity _scope;
		protected HostSystem[] _host;
		public ManagedEntity Scope
		{
			get
			{
				return this._scope;
			}
			set
			{
				this._scope = value;
			}
		}
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
