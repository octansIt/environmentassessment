namespace EnvironmentAssessment.Common.VISoap
{
    public class ServiceManagerServiceInfo : DynamicData
	{
		protected string _serviceName;
		protected string[] _location;
		protected ManagedObjectReference _service;
		protected string _description;
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
		public string[] Location
		{
			get
			{
				return this._location;
			}
			set
			{
				this._location = value;
			}
		}
		public ManagedObjectReference Service
		{
			get
			{
				return this._service;
			}
			set
			{
				this._service = value;
			}
		}
		public string Description
		{
			get
			{
				return this._description;
			}
			set
			{
				this._description = value;
			}
		}
	}
}
