namespace EnvironmentAssessment.Common.VISoap
{
    public class VirtualApp_LinkedView : ResourcePool_LinkedView
	{
		protected Folder _parentFolder;
		protected Datastore[] _datastore;
		protected Network[] _network;
		protected ManagedEntity _parentVApp;
		public Folder ParentFolder
		{
			get
			{
				return this._parentFolder;
			}
		}
		public Datastore[] Datastore
		{
			get
			{
				return this._datastore;
			}
		}
		public Network[] Network
		{
			get
			{
				return this._network;
			}
		}
		public ManagedEntity ParentVApp
		{
			get
			{
				return this._parentVApp;
			}
		}
	}
}
