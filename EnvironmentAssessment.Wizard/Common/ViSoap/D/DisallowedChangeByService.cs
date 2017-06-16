namespace EnvironmentAssessment.Common.VISoap
{
    public class DisallowedChangeByService : RuntimeFault
	{
		protected string _serviceName;
		protected string _disallowedChange;
		public string ServiceName
		{
			get
			{
				return this._serviceName;
			}
			set
			{
				this._serviceName = value;
			}
		}
		public string DisallowedChange
		{
			get
			{
				return this._disallowedChange;
			}
			set
			{
				this._disallowedChange = value;
			}
		}
	}
}
