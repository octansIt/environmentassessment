namespace EnvironmentAssessment.Common.VISoap
{
    public class DistributedVirtualSwitchManagerHostContainer : DynamicData
	{
		protected ManagedObjectReference _container;
		protected bool _recursive;
		protected DistributedVirtualSwitchManagerHostContainer_LinkedView _linkedView;
		public ManagedObjectReference Container
		{
			get
			{
				return this._container;
			}
			set
			{
				this._container = value;
			}
		}
		public bool Recursive
		{
			get
			{
				return this._recursive;
			}
			set
			{
				this._recursive = value;
			}
		}
		public DistributedVirtualSwitchManagerHostContainer_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
