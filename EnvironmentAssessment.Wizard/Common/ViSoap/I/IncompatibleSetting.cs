namespace EnvironmentAssessment.Common.VISoap
{
    public class IncompatibleSetting : InvalidArgument
	{
		protected string _conflictingProperty;
		public string ConflictingProperty
		{
			get
			{
				return this._conflictingProperty;
			}
			set
			{
				this._conflictingProperty = value;
			}
		}
	}
}
