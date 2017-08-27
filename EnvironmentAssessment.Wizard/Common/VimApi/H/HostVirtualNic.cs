namespace EnvironmentAssessment.Common.VimApi
{
	public class HostVirtualNic : DynamicData
	{
		protected string _device;
		protected string _key;
		protected string _portgroup;
		protected HostVirtualNicSpec _spec;
		protected string _port;
		public string Device
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
		public string Portgroup
		{
			get
			{
				return this._portgroup;
			}
			set
			{
				this._portgroup = value;
			}
		}
		public HostVirtualNicSpec Spec
		{
			get
			{
				return this._spec;
			}
			set
			{
				this._spec = value;
			}
		}
		public string Port
		{
			get
			{
				return this._port;
			}
			set
			{
				this._port = value;
			}
		}
	}
}
