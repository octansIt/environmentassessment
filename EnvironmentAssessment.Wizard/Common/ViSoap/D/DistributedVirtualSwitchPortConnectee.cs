namespace EnvironmentAssessment.Common.VISoap
{
    public class DistributedVirtualSwitchPortConnectee : DynamicData
	{
		protected ManagedObjectReference _connectedEntity;
		protected string _nicKey;
		protected string _type;
		protected string _addressHint;
		protected DistributedVirtualSwitchPortConnectee_LinkedView _linkedView;
		public ManagedObjectReference ConnectedEntity
		{
			get
			{
				return this._connectedEntity;
			}
			set
			{
				this._connectedEntity = value;
			}
		}
		public string NicKey
		{
			get
			{
				return this._nicKey;
			}
			set
			{
				this._nicKey = value;
			}
		}
		public string Type
		{
			get
			{
				return this._type;
			}
			set
			{
				this._type = value;
			}
		}
		public string AddressHint
		{
			get
			{
				return this._addressHint;
			}
			set
			{
				this._addressHint = value;
			}
		}
		public DistributedVirtualSwitchPortConnectee_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
