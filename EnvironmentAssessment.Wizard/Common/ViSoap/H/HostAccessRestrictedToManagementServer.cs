namespace EnvironmentAssessment.Common.VISoap
{
    public class HostAccessRestrictedToManagementServer : NotSupported
	{
		protected string _managementServer;
		public string ManagementServer
		{
			get
			{
				return this._managementServer;
			}
			set
			{
				this._managementServer = value;
			}
		}
	}
}
