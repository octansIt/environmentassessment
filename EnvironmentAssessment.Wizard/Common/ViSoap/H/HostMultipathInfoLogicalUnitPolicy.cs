namespace EnvironmentAssessment.Common.VISoap
{
    public class HostMultipathInfoLogicalUnitPolicy : DynamicData
	{
		protected string _policy;
		public string Policy
		{
			get
			{
				return this._policy;
			}
			set
			{
				this._policy = value;
			}
		}
	}
}
