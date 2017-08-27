namespace EnvironmentAssessment.Common.VimApi
{
	public class VirtualMachineRelocateSpec_LinkedView
	{
		protected Folder _folder;
		protected Datastore _datastore;
		protected ResourcePool _pool;
		protected HostSystem _host;
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
		public Datastore Datastore
		{
			get
			{
				return this._datastore;
			}
			set
			{
				this._datastore = value;
			}
		}
		public ResourcePool Pool
		{
			get
			{
				return this._pool;
			}
			set
			{
				this._pool = value;
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
	}
}
