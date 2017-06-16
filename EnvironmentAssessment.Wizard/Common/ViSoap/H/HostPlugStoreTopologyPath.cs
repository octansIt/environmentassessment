namespace EnvironmentAssessment.Common.VISoap
{
    public class HostPlugStoreTopologyPath : DynamicData
	{
		protected string _key;
		protected string _name;
		protected int? _channelNumber;
		protected int? _targetNumber;
		protected int? _lunNumber;
		protected string _adapter;
		protected string _target;
		protected string _device;
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
		public int? ChannelNumber
		{
			get
			{
				return this._channelNumber;
			}
			set
			{
				this._channelNumber = value;
			}
		}
		public int? TargetNumber
		{
			get
			{
				return this._targetNumber;
			}
			set
			{
				this._targetNumber = value;
			}
		}
		public int? LunNumber
		{
			get
			{
				return this._lunNumber;
			}
			set
			{
				this._lunNumber = value;
			}
		}
		public string Adapter
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
		public string Target
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
	}
}
