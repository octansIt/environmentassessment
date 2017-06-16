namespace EnvironmentAssessment.Common.VISoap
{
    public class HostServiceInfo : DynamicData
	{
		protected HostService[] _service;
		public HostService[] Service
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
	}
}
