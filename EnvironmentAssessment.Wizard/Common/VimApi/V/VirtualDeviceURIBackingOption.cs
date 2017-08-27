namespace EnvironmentAssessment.Common.VimApi
{
	public class VirtualDeviceURIBackingOption : VirtualDeviceBackingOption
	{
		protected ChoiceOption _directions;
		public ChoiceOption Directions
		{
			get
			{
				return this._directions;
			}
			set
			{
				this._directions = value;
			}
		}
	}
}
