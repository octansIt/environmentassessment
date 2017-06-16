namespace EnvironmentAssessment.Common.VISoap
{
    public class ApplyProfile : DynamicData
	{
		protected bool _enabled;
		protected ProfilePolicy[] _policy;
		protected string _profileTypeName;
		protected string _profileVersion;
		protected ProfileApplyProfileProperty[] _property;
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
	}
}
