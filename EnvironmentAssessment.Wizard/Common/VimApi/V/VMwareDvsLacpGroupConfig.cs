namespace EnvironmentAssessment.Common.VimApi
{
	public class VMwareDvsLacpGroupConfig : DynamicData
	{
		protected string _key;
		protected string _name;
		protected string _mode;
		protected int? _uplinkNum;
		protected string _loadbalanceAlgorithm;
		protected VMwareDvsLagVlanConfig _vlan;
		protected VMwareDvsLagIpfixConfig _ipfix;
		protected string[] _uplinkName;
		protected string[] _uplinkPortKey;
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
		public string Mode
		{
			get
			{
				return this._mode;
			}
			set
			{
				this._mode = value;
			}
		}
		public int? UplinkNum
		{
			get
			{
				return this._uplinkNum;
			}
			set
			{
				this._uplinkNum = value;
			}
		}
		public string LoadbalanceAlgorithm
		{
			get
			{
				return this._loadbalanceAlgorithm;
			}
			set
			{
				this._loadbalanceAlgorithm = value;
			}
		}
		public VMwareDvsLagVlanConfig Vlan
		{
			get
			{
				return this._vlan;
			}
			set
			{
				this._vlan = value;
			}
		}
		public VMwareDvsLagIpfixConfig Ipfix
		{
			get
			{
				return this._ipfix;
			}
			set
			{
				this._ipfix = value;
			}
		}
		public string[] UplinkName
		{
			get
			{
				return this._uplinkName;
			}
			set
			{
				this._uplinkName = value;
			}
		}
		public string[] UplinkPortKey
		{
			get
			{
				return this._uplinkPortKey;
			}
			set
			{
				this._uplinkPortKey = value;
			}
		}
	}
}
