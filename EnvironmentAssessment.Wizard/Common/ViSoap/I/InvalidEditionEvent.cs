namespace EnvironmentAssessment.Common.VISoap
{
    public class InvalidEditionEvent : LicenseEvent
	{
		protected string _feature;
		public string Feature
		{
			get
			{
				return this._feature;
			}
			set
			{
				this._feature = value;
			}
		}
	}
}
