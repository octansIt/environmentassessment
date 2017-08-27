namespace EnvironmentAssessment.Common.VimApi
{
	public class OvfNetworkMapping : DynamicData
	{
		protected string _name;
		protected ManagedObjectReference _network;
		protected OvfNetworkMapping_LinkedView _linkedView;
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				this._name = value;
			}
		}
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
		public OvfNetworkMapping_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
