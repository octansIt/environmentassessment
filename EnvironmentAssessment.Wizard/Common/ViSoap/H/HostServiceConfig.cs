namespace EnvironmentAssessment.Common.VISoap
{
    public class HostServiceConfig : DynamicData
	{
		protected string _serviceId;
		protected string _startupPolicy;
		public string ServiceId
		{
			get
			{
				return this._serviceId;
			}
			set
			{
				this._serviceId = value;
			}
		}
		public string StartupPolicy
		{
			get
			{
				return this._startupPolicy;
			}
			set
			{
				this._startupPolicy = value;
			}
		}
	}
}
