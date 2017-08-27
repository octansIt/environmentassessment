namespace EnvironmentAssessment.Common.VimApi
{
	public class VirtualDeviceBackingOption : DynamicData
	{
		protected string _type;
		public string Type
		{
			get
			{
				return this._type;
			}
			set
			{
				this._type = value;
			}
		}
	}
}
