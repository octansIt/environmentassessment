namespace EnvironmentAssessment.Common.VISoap
{
    public class NetworkEventArgument : EntityEventArgument
	{
		protected ManagedObjectReference _network;
		protected NetworkEventArgument_LinkedView _linkedView;
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
		public NetworkEventArgument_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
