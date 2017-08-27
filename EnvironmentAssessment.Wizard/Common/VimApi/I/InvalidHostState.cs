namespace EnvironmentAssessment.Common.VimApi
{
	public class InvalidHostState : InvalidState
	{
		protected ManagedObjectReference _host;
		protected InvalidHostState_LinkedView _linkedView;
		public ManagedObjectReference Host
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
		public InvalidHostState_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
