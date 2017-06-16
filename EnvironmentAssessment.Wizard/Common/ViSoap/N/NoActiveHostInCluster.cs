namespace EnvironmentAssessment.Common.VISoap
{
    public class NoActiveHostInCluster : InvalidState
	{
		protected ManagedObjectReference _computeResource;
		protected NoActiveHostInCluster_LinkedView _linkedView;
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
		public NoActiveHostInCluster_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
