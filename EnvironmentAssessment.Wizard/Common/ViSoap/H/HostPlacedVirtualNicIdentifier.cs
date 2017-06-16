namespace EnvironmentAssessment.Common.VISoap
{
    public class HostPlacedVirtualNicIdentifier : DynamicData
	{
		protected ManagedObjectReference _vm;
		protected string _vnicKey;
		protected int? _reservation;
		protected HostPlacedVirtualNicIdentifier_LinkedView _linkedView;
		public ManagedObjectReference Vm
		{
			get
			{
				return this._vm;
			}
			set
			{
				this._vm = value;
			}
		}
		public string VnicKey
		{
			get
			{
				return this._vnicKey;
			}
			set
			{
				this._vnicKey = value;
			}
		}
		public int? Reservation
		{
			get
			{
				return this._reservation;
			}
			set
			{
				this._reservation = value;
			}
		}
		public HostPlacedVirtualNicIdentifier_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
