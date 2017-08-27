namespace EnvironmentAssessment.Common.VimApi
{
	public class ApplyProfile : DynamicData
	{
		protected bool _enabled;
		protected ProfilePolicy[] _policy;
		protected string _profileTypeName;
		protected string _profileVersion;
		protected ProfileApplyProfileProperty[] _property;
		protected bool? _favorite;
		protected bool? _toBeMerged;
		protected bool? _toReplaceWith;
		protected bool? _toBeDeleted;
		protected bool? _copyEnableStatus;
		public bool Enabled
		{
			get
			{
				return this._enabled;
			}
			set
			{
				this._enabled = value;
			}
		}
		public ProfilePolicy[] Policy
		{
			get
			{
				return this._policy;
			}
			set
			{
				this._policy = value;
			}
		}
		public string ProfileTypeName
		{
			get
			{
				return this._profileTypeName;
			}
			set
			{
				this._profileTypeName = value;
			}
		}
		public string ProfileVersion
		{
			get
			{
				return this._profileVersion;
			}
			set
			{
				this._profileVersion = value;
			}
		}
		public ProfileApplyProfileProperty[] Property
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
		public bool? Favorite
		{
			get
			{
				return this._favorite;
			}
			set
			{
				this._favorite = value;
			}
		}
		public bool? ToBeMerged
		{
			get
			{
				return this._toBeMerged;
			}
			set
			{
				this._toBeMerged = value;
			}
		}
		public bool? ToReplaceWith
		{
			get
			{
				return this._toReplaceWith;
			}
			set
			{
				this._toReplaceWith = value;
			}
		}
		public bool? ToBeDeleted
		{
			get
			{
				return this._toBeDeleted;
			}
			set
			{
				this._toBeDeleted = value;
			}
		}
		public bool? CopyEnableStatus
		{
			get
			{
				return this._copyEnableStatus;
			}
			set
			{
				this._copyEnableStatus = value;
			}
		}
	}
}
