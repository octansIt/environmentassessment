namespace EnvironmentAssessment.Common.VimApi
{
	public class PlacementSpec_LinkedView
	{
		protected VirtualMachine _vm;
		protected HostSystem[] _hosts;
		protected Datastore[] _datastores;
		protected StoragePod[] _storagePods;
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
		public HostSystem[] Hosts
		{
			get
			{
				return this._hosts;
			}
			set
			{
				this._hosts = value;
			}
		}
		public Datastore[] Datastores
		{
			get
			{
				return this._datastores;
			}
			set
			{
				this._datastores = value;
			}
		}
		public StoragePod[] StoragePods
		{
			get
			{
				return this._storagePods;
			}
			set
			{
				this._storagePods = value;
			}
		}
	}
}
