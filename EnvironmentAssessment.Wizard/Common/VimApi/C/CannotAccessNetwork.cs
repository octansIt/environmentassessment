namespace EnvironmentAssessment.Common.VimApi
{
	public class CannotAccessNetwork : CannotAccessVmDevice
	{
		protected ManagedObjectReference _network;
		protected CannotAccessNetwork_LinkedView _linkedView;
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
		public CannotAccessNetwork_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
