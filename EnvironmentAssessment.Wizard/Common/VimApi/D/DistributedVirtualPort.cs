using System;

namespace EnvironmentAssessment.Common.VimApi
{
	public class DistributedVirtualPort : DynamicData
	{
		protected string _key;
		protected DVPortConfigInfo _config;
		protected string _dvsUuid;
		protected string _portgroupKey;
		protected ManagedObjectReference _proxyHost;
		protected DistributedVirtualSwitchPortConnectee _connectee;
		protected bool _conflict;
		protected string _conflictPortKey;
		protected DVPortState _state;
		protected int? _connectionCookie;
		protected DateTime _lastStatusChange;
		protected bool? _hostLocalPort;
		protected DistributedVirtualPort_LinkedView _linkedView;
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
		public DVPortConfigInfo Config
		{
			get
			{
				return this._config;
			}
			set
			{
				this._config = value;
			}
		}
		public string DvsUuid
		{
			get
			{
				return this._dvsUuid;
			}
			set
			{
				this._dvsUuid = value;
			}
		}
		public string PortgroupKey
		{
			get
			{
				return this._portgroupKey;
			}
			set
			{
				this._portgroupKey = value;
			}
		}
		public ManagedObjectReference ProxyHost
		{
			get
			{
				return this._proxyHost;
			}
			set
			{
				this._proxyHost = value;
			}
		}
		public DistributedVirtualSwitchPortConnectee Connectee
		{
			get
			{
				return this._connectee;
			}
			set
			{
				this._connectee = value;
			}
		}
		public bool Conflict
		{
			get
			{
				return this._conflict;
			}
			set
			{
				this._conflict = value;
			}
		}
		public string ConflictPortKey
		{
			get
			{
				return this._conflictPortKey;
			}
			set
			{
				this._conflictPortKey = value;
			}
		}
		public DVPortState State
		{
			get
			{
				return this._state;
			}
			set
			{
				this._state = value;
			}
		}
		public int? ConnectionCookie
		{
			get
			{
				return this._connectionCookie;
			}
			set
			{
				this._connectionCookie = value;
			}
		}
		public DateTime LastStatusChange
		{
			get
			{
				return this._lastStatusChange;
			}
			set
			{
				this._lastStatusChange = value;
			}
		}
		public bool? HostLocalPort
		{
			get
			{
				return this._hostLocalPort;
			}
			set
			{
				this._hostLocalPort = value;
			}
		}
		public DistributedVirtualPort_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
