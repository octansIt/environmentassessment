namespace EnvironmentAssessment.Common.VimApi
{
	public class VirtualCdromRemotePassthroughBackingOption : VirtualDeviceRemoteDeviceBackingOption
	{
		protected BoolOption _exclusive;
		public BoolOption Exclusive
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
