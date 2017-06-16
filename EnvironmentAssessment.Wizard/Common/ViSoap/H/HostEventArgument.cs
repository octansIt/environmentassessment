namespace EnvironmentAssessment.Common.VISoap
{
    public class HostEventArgument : EntityEventArgument
	{
		protected ManagedObjectReference _host;
		protected HostEventArgument_LinkedView _linkedView;
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
		public HostEventArgument_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
