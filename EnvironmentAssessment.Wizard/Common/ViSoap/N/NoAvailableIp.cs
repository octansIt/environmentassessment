namespace EnvironmentAssessment.Common.VISoap
{
    public class NoAvailableIp : VAppPropertyFault
	{
		protected ManagedObjectReference _network;
		protected NoAvailableIp_LinkedView _linkedView;
		public ManagedObjectReference Network
		{
			get
			{
				return this._network;
			}
			set
			{
				this._network = value;
			}
		}
		public NoAvailableIp_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
