namespace EnvironmentAssessment.Common.VISoap
{
    public class NetDhcpConfigSpecDhcpOptionsSpec : DynamicData
	{
		protected bool? _enable;
		protected KeyValue[] _config;
		protected string _operation;
		public bool? Enable
		{
			get
			{
				return this._enable;
			}
			set
			{
				this._enable = value;
			}
		}
		public KeyValue[] Config
		{
			get
			{
				return this._config;
			}
			set
			{
				this._config = value;
			}
		}
		public string Operation
		{
			get
			{
				return this._operation;
			}
			set
			{
				this._operation = value;
			}
		}
	}
}
