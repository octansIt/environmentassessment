namespace EnvironmentAssessment.Common.VISoap
{
    public class InsufficientHostCapacityFault : InsufficientResourcesFault
	{
		protected ManagedObjectReference _host;
		protected InsufficientHostCapacityFault_LinkedView _linkedView;
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
		public InsufficientHostCapacityFault_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
