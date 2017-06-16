namespace EnvironmentAssessment.Common.VISoap
{
    public class StorageMigrationAction_LinkedView
	{
		protected VirtualMachine _vm;
		protected Datastore _source;
		protected Datastore _destination;
		public VirtualMachine Vm
		{
			get
			{
				return this._vm;
			}
			set
			{
				this._vm = value;
			}
		}
		public Datastore Source
		{
			get
			{
				return this._source;
			}
			set
			{
				this._source = value;
			}
		}
		public Datastore Destination
		{
			get
			{
				return this._destination;
			}
			set
			{
				this._destination = value;
			}
		}
	}
}
