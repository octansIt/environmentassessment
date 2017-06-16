namespace EnvironmentAssessment.Common.VISoap
{
    public class ClusterDasFdmHostState : DynamicData
	{
		protected string _state;
		protected ManagedObjectReference _stateReporter;
		protected ClusterDasFdmHostState_LinkedView _linkedView;
		public string State
		{
			get
			{
				return this._state;
			}
			set
			{
				this._state = value;
			}
		}
		public ManagedObjectReference StateReporter
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
		public ClusterDasFdmHostState_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
