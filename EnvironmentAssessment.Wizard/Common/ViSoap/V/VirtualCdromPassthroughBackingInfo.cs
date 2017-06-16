namespace EnvironmentAssessment.Common.VISoap
{
    public class VirtualCdromPassthroughBackingInfo : VirtualDeviceDeviceBackingInfo
	{
		protected bool _exclusive;
		protected string _description;
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
		public string Description
		{
			get
			{
				return this._description;
			}
			set
			{
				this._description = value;
			}
		}
	}
}
