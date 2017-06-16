namespace EnvironmentAssessment.Common.VISoap
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
