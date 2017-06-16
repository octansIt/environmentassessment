namespace EnvironmentAssessment.Common.VISoap
{
    public class DistributedVirtualSwitchManagerHostArrayFilter : DistributedVirtualSwitchManagerHostDvsFilterSpec
	{
		protected ManagedObjectReference[] _host;
		protected DistributedVirtualSwitchManagerHostArrayFilter_LinkedView _linkedView;
		public ManagedObjectReference[] Host
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
		public DistributedVirtualSwitchManagerHostArrayFilter_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
