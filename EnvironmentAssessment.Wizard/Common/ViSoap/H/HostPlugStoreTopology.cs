namespace EnvironmentAssessment.Common.VISoap
{
    public class HostPlugStoreTopology : DynamicData
	{
		protected HostPlugStoreTopologyAdapter[] _adapter;
		protected HostPlugStoreTopologyPath[] _path;
		protected HostPlugStoreTopologyTarget[] _target;
		protected HostPlugStoreTopologyDevice[] _device;
		protected HostPlugStoreTopologyPlugin[] _plugin;
		public HostPlugStoreTopologyAdapter[] Adapter
		{
			get
			{
				return this._adapter;
			}
			set
			{
				this._adapter = value;
			}
		}
		public HostPlugStoreTopologyPath[] Path
		{
			get
			{
				return this._path;
			}
			set
			{
				this._path = value;
			}
		}
		public HostPlugStoreTopologyTarget[] Target
		{
			get
			{
				return this._target;
			}
			set
			{
				this._target = value;
			}
		}
		public HostPlugStoreTopologyDevice[] Device
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
		public HostPlugStoreTopologyPlugin[] Plugin
		{
			get
			{
				return this._plugin;
			}
			set
			{
				this._plugin = value;
			}
		}
	}
}
