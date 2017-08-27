using System;

namespace EnvironmentAssessment.Common.VimApi
{
	public class SoftwarePackage : DynamicData
	{
		protected string _name;
		protected string _version;
		protected string _type;
		protected string _vendor;
		protected string _acceptanceLevel;
		protected string _summary;
		protected string _description;
		protected string[] _referenceURL;
		protected DateTime? _creationDate;
		protected Relation[] _depends;
		protected Relation[] _conflicts;
		protected Relation[] _replaces;
		protected string[] _provides;
		protected bool? _maintenanceModeRequired;
		protected string[] _hardwarePlatformsRequired;
		protected SoftwarePackageCapability _capability;
		protected string[] _tag;
		protected string[] _payload;
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
		public string Version
		{
			get
			{
				return this._version;
			}
			set
			{
				this._version = value;
			}
		}
		public string Type
		{
			get
			{
				return this._type;
			}
			set
			{
				this._type = value;
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
		public string AcceptanceLevel
		{
			get
			{
				return this._acceptanceLevel;
			}
			set
			{
				this._acceptanceLevel = value;
			}
		}
		public string Summary
		{
			get
			{
				return this._summary;
			}
			set
			{
				this._summary = value;
			}
		}
		public string Description
		{
			get
			{
				return this._description;
			}
			set
			{
				this._description = value;
			}
		}
		public string[] ReferenceURL
		{
			get
			{
				return this._referenceURL;
			}
			set
			{
				this._referenceURL = value;
			}
		}
		public DateTime? CreationDate
		{
			get
			{
				return this._creationDate;
			}
			set
			{
				this._creationDate = value;
			}
		}
		public Relation[] Depends
		{
			get
			{
				return this._depends;
			}
			set
			{
				this._depends = value;
			}
		}
		public Relation[] Conflicts
		{
			get
			{
				return this._conflicts;
			}
			set
			{
				this._conflicts = value;
			}
		}
		public Relation[] Replaces
		{
			get
			{
				return this._replaces;
			}
			set
			{
				this._replaces = value;
			}
		}
		public string[] Provides
		{
			get
			{
				return this._provides;
			}
			set
			{
				this._provides = value;
			}
		}
		public bool? MaintenanceModeRequired
		{
			get
			{
				return this._maintenanceModeRequired;
			}
			set
			{
				this._maintenanceModeRequired = value;
			}
		}
		public string[] HardwarePlatformsRequired
		{
			get
			{
				return this._hardwarePlatformsRequired;
			}
			set
			{
				this._hardwarePlatformsRequired = value;
			}
		}
		public SoftwarePackageCapability Capability
		{
			get
			{
				return this._capability;
			}
			set
			{
				this._capability = value;
			}
		}
		public string[] Tag
		{
			get
			{
				return this._tag;
			}
			set
			{
				this._tag = value;
			}
		}
		public string[] Payload
		{
			get
			{
				return this._payload;
			}
			set
			{
				this._payload = value;
			}
		}
	}
}
