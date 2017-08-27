namespace EnvironmentAssessment.Common.VimApi
{
	public class HostFibreChannelHba : HostHostBusAdapter
	{
		protected long _portWorldWideName;
		protected long _nodeWorldWideName;
		protected FibreChannelPortType _portType;
		protected long _speed;
		public long PortWorldWideName
		{
			get
			{
				return this._portWorldWideName;
			}
			set
			{
				this._portWorldWideName = value;
			}
		}
		public long NodeWorldWideName
		{
			get
			{
				return this._nodeWorldWideName;
			}
			set
			{
				this._nodeWorldWideName = value;
			}
		}
		public FibreChannelPortType PortType
		{
			get
			{
				return this._portType;
			}
			set
			{
				this._portType = value;
			}
		}
		public long Speed
		{
			get
			{
				return this._speed;
			}
			set
			{
				this._speed = value;
			}
		}
	}
}
