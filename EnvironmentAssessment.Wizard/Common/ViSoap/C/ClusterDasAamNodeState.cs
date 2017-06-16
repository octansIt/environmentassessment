namespace EnvironmentAssessment.Common.VISoap
{
    public class ClusterDasAamNodeState : DynamicData
	{
		protected ManagedObjectReference _host;
		protected string _name;
		protected string _configState;
		protected string _runtimeState;
		protected ClusterDasAamNodeState_LinkedView _linkedView;
		public ManagedObjectReference Host
		{
			get
			{
				return this._host;
			}
			set
			{
				this._host = value;
			}
		}
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				this._name = value;
			}
		}
		public string ConfigState
		{
			get
			{
				return this._configState;
			}
			set
			{
				this._configState = value;
			}
		}
		public string RuntimeState
		{
			get
			{
				return this._runtimeState;
			}
			set
			{
				this._runtimeState = value;
			}
		}
		public ClusterDasAamNodeState_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
