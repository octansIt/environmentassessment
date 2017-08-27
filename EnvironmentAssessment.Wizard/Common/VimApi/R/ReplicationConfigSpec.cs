namespace EnvironmentAssessment.Common.VimApi
{
	public class ReplicationConfigSpec : DynamicData
	{
		protected long _generation;
		protected string _vmReplicationId;
		protected string _destination;
		protected int _port;
		protected long _rpo;
		protected bool _quiesceGuestEnabled;
		protected bool _paused;
		protected bool _oppUpdatesEnabled;
		protected bool? _netCompressionEnabled;
		protected ReplicationInfoDiskSettings[] _disk;
		public long Generation
		{
			get
			{
				return this._generation;
			}
			set
			{
				this._generation = value;
			}
		}
		public string VmReplicationId
		{
			get
			{
				return this._vmReplicationId;
			}
			set
			{
				this._vmReplicationId = value;
			}
		}
		public string Destination
		{
			get
			{
				return this._destination;
			}
			set
			{
				this._destination = value;
			}
		}
		public int Port
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
		public long Rpo
		{
			get
			{
				return this._rpo;
			}
			set
			{
				this._rpo = value;
			}
		}
		public bool QuiesceGuestEnabled
		{
			get
			{
				return this._quiesceGuestEnabled;
			}
			set
			{
				this._quiesceGuestEnabled = value;
			}
		}
		public bool Paused
		{
			get
			{
				return this._paused;
			}
			set
			{
				this._paused = value;
			}
		}
		public bool OppUpdatesEnabled
		{
			get
			{
				return this._oppUpdatesEnabled;
			}
			set
			{
				this._oppUpdatesEnabled = value;
			}
		}
		public bool? NetCompressionEnabled
		{
			get
			{
				return this._netCompressionEnabled;
			}
			set
			{
				this._netCompressionEnabled = value;
			}
		}
		public ReplicationInfoDiskSettings[] Disk
		{
			get
			{
				return this._disk;
			}
			set
			{
				this._disk = value;
			}
		}
	}
}
