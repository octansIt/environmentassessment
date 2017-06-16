namespace EnvironmentAssessment.Common.VISoap
{
    public class VirtualCdromRemotePassthroughBackingInfo : VirtualDeviceRemoteDeviceBackingInfo
	{
		protected bool _exclusive;
		public bool Exclusive
		{
			get
			{
				return this._exclusive;
			}
			set
			{
				this._exclusive = value;
			}
		}
	}
}
