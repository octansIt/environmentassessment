namespace EnvironmentAssessment.Common.VISoap
{
    public class HostMultipathInfoFixedLogicalUnitPolicy : HostMultipathInfoLogicalUnitPolicy
	{
		protected string _prefer;
		public string Prefer
		{
			get
			{
				return this._prefer;
			}
			set
			{
				this._prefer = value;
			}
		}
	}
}
