namespace EnvironmentAssessment.Common.VimApi
{
	public class ClusterDasFdmHostState_LinkedView
	{
		protected HostSystem _stateReporter;
		public HostSystem StateReporter
		{
			get
			{
				return this._stateReporter;
			}
			set
			{
				this._stateReporter = value;
			}
		}
	}
}
