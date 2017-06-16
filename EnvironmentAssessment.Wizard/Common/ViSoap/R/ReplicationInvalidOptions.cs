namespace EnvironmentAssessment.Common.VISoap
{
    public class ReplicationInvalidOptions : ReplicationFault
	{
		protected string _options;
		protected ManagedObjectReference _entity;
		protected ReplicationInvalidOptions_LinkedView _linkedView;
		public string Options
		{
			get
			{
				return this._options;
			}
			set
			{
				this._options = value;
			}
		}
		public ManagedObjectReference Entity
		{
			get
			{
				return this._entity;
			}
			set
			{
				this._entity = value;
			}
		}
		public ReplicationInvalidOptions_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
