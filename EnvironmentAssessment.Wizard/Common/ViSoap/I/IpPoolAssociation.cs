namespace EnvironmentAssessment.Common.VISoap
{
    public class IpPoolAssociation : DynamicData
	{
		protected ManagedObjectReference _network;
		protected string _networkName;
		protected IpPoolAssociation_LinkedView _linkedView;
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
		public string NetworkName
		{
			get
			{
				return this._networkName;
			}
			set
			{
				this._networkName = value;
			}
		}
		public IpPoolAssociation_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
