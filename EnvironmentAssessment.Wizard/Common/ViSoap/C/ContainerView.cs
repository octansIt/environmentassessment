namespace EnvironmentAssessment.Common.VISoap
{
    public class ContainerView : ManagedObjectView
	{
		protected ManagedObjectReference _container;
		protected string[] _type;
		protected bool _recursive;
		protected ContainerView_LinkedView _linkedView;
		public ManagedObjectReference Container
		{
			get
			{
				return this._container;
			}
		}
		public string[] Type
		{
			get
			{
				return this._type;
			}
		}
		public bool Recursive
		{
			get
			{
				return this._recursive;
			}
		}
		public ContainerView_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
		public ContainerView(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
	}
}
