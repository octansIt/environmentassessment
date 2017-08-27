namespace EnvironmentAssessment.Common.VimApi
{
	public class ClusterNetworkConfigSpec : DynamicData
	{
		protected ManagedObjectReference _networkPortGroup;
		protected CustomizationIPSettings _ipSettings;
		protected ClusterNetworkConfigSpec_LinkedView _linkedView;
		public ManagedObjectReference NetworkPortGroup
		{
			get
			{
				return this._networkPortGroup;
			}
			set
			{
				this._networkPortGroup = value;
			}
		}
		public CustomizationIPSettings IpSettings
		{
			get
			{
				return this._ipSettings;
			}
			set
			{
				this._ipSettings = value;
			}
		}
		public ClusterNetworkConfigSpec_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
