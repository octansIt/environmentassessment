namespace EnvironmentAssessment.Common.VISoap
{
    public class HostNetworkPolicy : DynamicData
	{
		protected HostNetworkSecurityPolicy _security;
		protected HostNicTeamingPolicy _nicTeaming;
		protected HostNetOffloadCapabilities _offloadPolicy;
		protected HostNetworkTrafficShapingPolicy _shapingPolicy;
		public HostNetworkSecurityPolicy Security
		{
			get
			{
				return this._security;
			}
			set
			{
				this._security = value;
			}
		}
		public HostNicTeamingPolicy NicTeaming
		{
			get
			{
				return this._nicTeaming;
			}
			set
			{
				this._nicTeaming = value;
			}
		}
		public HostNetOffloadCapabilities OffloadPolicy
		{
			get
			{
				return this._offloadPolicy;
			}
			set
			{
				this._offloadPolicy = value;
			}
		}
		public HostNetworkTrafficShapingPolicy ShapingPolicy
		{
			get
			{
				return this._shapingPolicy;
			}
			set
			{
				this._shapingPolicy = value;
			}
		}
	}
}
