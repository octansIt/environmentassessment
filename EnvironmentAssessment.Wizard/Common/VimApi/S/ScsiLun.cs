namespace EnvironmentAssessment.Common.VimApi
{
	public class ScsiLun : HostDevice
	{
		protected string _key;
		protected string _uuid;
		protected ScsiLunDescriptor[] _descriptor;
		protected string _canonicalName;
		protected string _displayName;
		protected string _lunType;
		protected string _vendor;
		protected string _model;
		protected string _revision;
		protected int? _scsiLevel;
		protected string _serialNumber;
		protected ScsiLunDurableName _durableName;
		protected ScsiLunDurableName[] _alternateName;
		protected sbyte[] _standardInquiry;
		protected int? _queueDepth;
		protected string[] _operationalState;
		protected ScsiLunCapabilities _capabilities;
		protected string _vStorageSupport;
		protected bool? _protocolEndpoint;
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
		public string Uuid
		{
			get
			{
				return this._uuid;
			}
			set
			{
				this._uuid = value;
			}
		}
		public ScsiLunDescriptor[] Descriptor
		{
			get
			{
				return this._descriptor;
			}
			set
			{
				this._descriptor = value;
			}
		}
		public string CanonicalName
		{
			get
			{
				return this._canonicalName;
			}
			set
			{
				this._canonicalName = value;
			}
		}
		public string DisplayName
		{
			get
			{
				return this._displayName;
			}
			set
			{
				this._displayName = value;
			}
		}
		public string LunType
		{
			get
			{
				return this._lunType;
			}
			set
			{
				this._lunType = value;
			}
		}
		public string Vendor
		{
			get
			{
				return this._vendor;
			}
			set
			{
				this._vendor = value;
			}
		}
		public string Model
		{
			get
			{
				return this._model;
			}
			set
			{
				this._model = value;
			}
		}
		public string Revision
		{
			get
			{
				return this._revision;
			}
			set
			{
				this._revision = value;
			}
		}
		public int? ScsiLevel
		{
			get
			{
				return this._scsiLevel;
			}
			set
			{
				this._scsiLevel = value;
			}
		}
		public string SerialNumber
		{
			get
			{
				return this._serialNumber;
			}
			set
			{
				this._serialNumber = value;
			}
		}
		public ScsiLunDurableName DurableName
		{
			get
			{
				return this._durableName;
			}
			set
			{
				this._durableName = value;
			}
		}
		public ScsiLunDurableName[] AlternateName
		{
			get
			{
				return this._alternateName;
			}
			set
			{
				this._alternateName = value;
			}
		}
		public sbyte[] StandardInquiry
		{
			get
			{
				return this._standardInquiry;
			}
			set
			{
				this._standardInquiry = value;
			}
		}
		public int? QueueDepth
		{
			get
			{
				return this._queueDepth;
			}
			set
			{
				this._queueDepth = value;
			}
		}
		public string[] OperationalState
		{
			get
			{
				return this._operationalState;
			}
			set
			{
				this._operationalState = value;
			}
		}
		public ScsiLunCapabilities Capabilities
		{
			get
			{
				return this._capabilities;
			}
			set
			{
				this._capabilities = value;
			}
		}
		public string VStorageSupport
		{
			get
			{
				return this._vStorageSupport;
			}
			set
			{
				this._vStorageSupport = value;
			}
		}
		public bool? ProtocolEndpoint
		{
			get
			{
				return this._protocolEndpoint;
			}
			set
			{
				this._protocolEndpoint = value;
			}
		}
	}
}
