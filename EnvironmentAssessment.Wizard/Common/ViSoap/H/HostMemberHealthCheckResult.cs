namespace EnvironmentAssessment.Common.VISoap
{
    public class HostMemberHealthCheckResult : DynamicData
	{
		protected string _summary;
		public string Summary
		{
			get
			{
				return this._summary;
			}
			set
			{
				this._summary = value;
			}
		}
	}
}
