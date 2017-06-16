namespace EnvironmentAssessment.Common.VISoap
{
    public class StoragePlacementSpec_LinkedView
	{
		protected VirtualMachine _vm;
		protected ResourcePool _resourcePool;
		protected HostSystem _host;
		protected Folder _folder;
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
		public ResourcePool ResourcePool
		{
			get
			{
				return this._resourcePool;
			}
			set
			{
				this._resourcePool = value;
			}
		}
		public HostSystem Host
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
		public Folder Folder
		{
			get
			{
				return this._folder;
			}
			set
			{
				this._folder = value;
			}
		}
	}
}
