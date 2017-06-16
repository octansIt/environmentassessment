namespace EnvironmentAssessment.Common.VISoap
{
    public class HostVMotionInfo : DynamicData
	{
		protected HostVMotionNetConfig _netConfig;
		protected HostIpConfig _ipConfig;
		public HostVMotionNetConfig NetConfig
		{
			get
			{
				return this._netConfig;
			}
			set
			{
				this._netConfig = value;
			}
		}
		public HostIpConfig IpConfig
		{
			get
			{
				return this._ipConfig;
			}
			set
			{
				this._ipConfig = value;
			}
		}
	}
}
