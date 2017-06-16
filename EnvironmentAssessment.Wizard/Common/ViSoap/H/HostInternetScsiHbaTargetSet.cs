namespace EnvironmentAssessment.Common.VISoap
{
    public class HostInternetScsiHbaTargetSet : DynamicData
	{
		protected HostInternetScsiHbaStaticTarget[] _staticTargets;
		protected HostInternetScsiHbaSendTarget[] _sendTargets;
		public HostInternetScsiHbaStaticTarget[] StaticTargets
		{
			get
			{
				return this._staticTargets;
			}
			set
			{
				this._staticTargets = value;
			}
		}
		public HostInternetScsiHbaSendTarget[] SendTargets
		{
			get
			{
				return this._sendTargets;
			}
			set
			{
				this._sendTargets = value;
			}
		}
	}
}
