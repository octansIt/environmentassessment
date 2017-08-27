namespace EnvironmentAssessment.Common.VimApi
{
	public class StoragePlacementAction_LinkedView
	{
		protected VirtualMachine _vm;
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
