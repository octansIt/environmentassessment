namespace EnvironmentAssessment.Common.VISoap
{
    public class HostPlugStoreTopologyPlugin : DynamicData
	{
		protected string _key;
		protected string _name;
		protected string[] _device;
		protected string[] _claimedPath;
		public string Key
		{
			get
			{
				return this._key;
			}
			set
			{
				this._key = value;
			}
		}
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
		public string[] Device
		{
			get
			{
				return this._device;
			}
			set
			{
				this._device = value;
			}
		}
		public string[] ClaimedPath
		{
			get
			{
				return this._claimedPath;
			}
			set
			{
				this._claimedPath = value;
			}
		}
	}
}
