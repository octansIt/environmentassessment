namespace EnvironmentAssessment.Common.VISoap
{
    public class DvsOutOfSyncHostArgument : DynamicData
	{
		protected HostEventArgument _outOfSyncHost;
		protected string[] _configParamters;
		public HostEventArgument OutOfSyncHost
		{
			get
			{
				return this._outOfSyncHost;
			}
			set
			{
				this._outOfSyncHost = value;
			}
		}
		public string[] ConfigParamters
		{
			get
			{
				return this._configParamters;
			}
			set
			{
				this._configParamters = value;
			}
		}
	}
}
