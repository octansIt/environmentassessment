namespace EnvironmentAssessment.Common.VimApi
{
	public class VirtualCdromPassthroughBackingOption : VirtualDeviceDeviceBackingOption
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
