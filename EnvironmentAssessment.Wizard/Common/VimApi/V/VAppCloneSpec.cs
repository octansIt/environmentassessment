namespace EnvironmentAssessment.Common.VimApi
{
	public class VAppCloneSpec : DynamicData
	{
		protected ManagedObjectReference _location;
		protected ManagedObjectReference _host;
		protected ResourceConfigSpec _resourceSpec;
		protected ManagedObjectReference _vmFolder;
		protected VAppCloneSpecNetworkMappingPair[] _networkMapping;
		protected KeyValue[] _property;
		protected VAppCloneSpecResourceMap[] _resourceMapping;
		protected string _provisioning;
		protected VAppCloneSpec_LinkedView _linkedView;
		public ManagedObjectReference Location
		{
			get
			{
				return this._location;
			}
			set
			{
				this._location = value;
			}
		}
		public ManagedObjectReference Host
		{
			get
			{
				return this._host;
			}
			set
			{
				this._host = value;
			}
		}
		public ResourceConfigSpec ResourceSpec
		{
			get
			{
				return this._resourceSpec;
			}
			set
			{
				this._resourceSpec = value;
			}
		}
		public ManagedObjectReference VmFolder
		{
			get
			{
				return this._vmFolder;
			}
			set
			{
				this._vmFolder = value;
			}
		}
		public VAppCloneSpecNetworkMappingPair[] NetworkMapping
		{
			get
			{
				return this._networkMapping;
			}
			set
			{
				this._networkMapping = value;
			}
		}
		public KeyValue[] Property
		{
			get
			{
				return this._property;
			}
			set
			{
				this._property = value;
			}
		}
		public VAppCloneSpecResourceMap[] ResourceMapping
		{
			get
			{
				return this._resourceMapping;
			}
			set
			{
				this._resourceMapping = value;
			}
		}
		public string Provisioning
		{
			get
			{
				return this._provisioning;
			}
			set
			{
				this._provisioning = value;
			}
		}
		public VAppCloneSpec_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
