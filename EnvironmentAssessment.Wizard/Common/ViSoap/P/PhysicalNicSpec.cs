namespace EnvironmentAssessment.Common.VISoap
{
    public class PhysicalNicSpec : DynamicData
	{
		protected HostIpConfig _ip;
		protected PhysicalNicLinkInfo _linkSpeed;
		public HostIpConfig Ip
		{
			get
			{
				return this._ip;
			}
			set
			{
				this._ip = value;
			}
		}
		public PhysicalNicLinkInfo LinkSpeed
		{
			get
			{
				return this._linkSpeed;
			}
			set
			{
				this._linkSpeed = value;
			}
		}
	}
}
