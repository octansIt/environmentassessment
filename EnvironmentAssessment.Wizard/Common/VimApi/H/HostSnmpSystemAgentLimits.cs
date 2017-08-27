namespace EnvironmentAssessment.Common.VimApi
{
	public class HostSnmpSystemAgentLimits : DynamicData
	{
		protected int _maxReadOnlyCommunities;
		protected int _maxTrapDestinations;
		protected int _maxCommunityLength;
		protected int _maxBufferSize;
		protected HostSnmpAgentCapability _capability;
		public int MaxReadOnlyCommunities
		{
			get
			{
				return this._maxReadOnlyCommunities;
			}
			set
			{
				this._maxReadOnlyCommunities = value;
			}
		}
		public int MaxTrapDestinations
		{
			get
			{
				return this._maxTrapDestinations;
			}
			set
			{
				this._maxTrapDestinations = value;
			}
		}
		public int MaxCommunityLength
		{
			get
			{
				return this._maxCommunityLength;
			}
			set
			{
				this._maxCommunityLength = value;
			}
		}
		public int MaxBufferSize
		{
			get
			{
				return this._maxBufferSize;
			}
			set
			{
				this._maxBufferSize = value;
			}
		}
		public HostSnmpAgentCapability Capability
		{
			get
			{
				return this._capability;
			}
			set
			{
				this._capability = value;
			}
		}
	}
}
