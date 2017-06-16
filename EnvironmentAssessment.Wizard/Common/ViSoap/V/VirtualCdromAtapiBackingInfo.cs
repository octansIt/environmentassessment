namespace EnvironmentAssessment.Common.VISoap
{
    public class VirtualCdromAtapiBackingInfo : VirtualDeviceDeviceBackingInfo
	{
		protected string _description;
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
