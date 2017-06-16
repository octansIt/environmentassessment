namespace EnvironmentAssessment.Common.VISoap
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
