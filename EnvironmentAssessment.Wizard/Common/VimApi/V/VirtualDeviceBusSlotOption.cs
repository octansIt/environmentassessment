namespace EnvironmentAssessment.Common.VimApi
{
	public class VirtualDeviceBusSlotOption : DynamicData
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
