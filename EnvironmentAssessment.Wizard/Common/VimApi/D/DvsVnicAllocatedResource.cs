namespace EnvironmentAssessment.Common.VimApi
{
	public class DvsVnicAllocatedResource : DynamicData
	{
		protected ManagedObjectReference _vm;
		protected string _vnicKey;
		protected long? _reservation;
		protected DvsVnicAllocatedResource_LinkedView _linkedView;
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
		public long? Reservation
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
		public DvsVnicAllocatedResource_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
