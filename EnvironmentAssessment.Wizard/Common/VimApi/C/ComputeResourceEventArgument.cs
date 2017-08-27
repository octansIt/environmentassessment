namespace EnvironmentAssessment.Common.VimApi
{
	public class ComputeResourceEventArgument : EntityEventArgument
	{
		protected ManagedObjectReference _computeResource;
		protected ComputeResourceEventArgument_LinkedView _linkedView;
		public ManagedObjectReference ComputeResource
		{
			get
			{
				return this._computeResource;
			}
			set
			{
				this._computeResource = value;
			}
		}
		public ComputeResourceEventArgument_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
