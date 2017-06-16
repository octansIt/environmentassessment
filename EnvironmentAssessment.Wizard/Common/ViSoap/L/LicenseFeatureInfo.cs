using System;
namespace EnvironmentAssessment.Common.VISoap
{
	public class LicenseFeatureInfo : DynamicData
	{
		protected string _key;
		protected string _featureName;
		protected string _featureDescription;
		protected LicenseFeatureInfoState? _state;
		protected string _costUnit;
		protected string _sourceRestriction;
		protected string[] _dependentKey;
		protected bool? _edition;
		protected DateTime? _expiresOn;
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
		public string FeatureName
		{
			get
			{
				return this._featureName;
			}
			set
			{
				this._featureName = value;
			}
		}
		public string FeatureDescription
		{
			get
			{
				return this._featureDescription;
			}
			set
			{
				this._featureDescription = value;
			}
		}
		public LicenseFeatureInfoState? State
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
		public string CostUnit
		{
			get
			{
				return this._costUnit;
			}
			set
			{
				this._costUnit = value;
			}
		}
		public string SourceRestriction
		{
			get
			{
				return this._sourceRestriction;
			}
			set
			{
				this._sourceRestriction = value;
			}
		}
		public string[] DependentKey
		{
			get
			{
				return this._dependentKey;
			}
			set
			{
				this._dependentKey = value;
			}
		}
		public bool? Edition
		{
			get
			{
				return this._edition;
			}
			set
			{
				this._edition = value;
			}
		}
		public DateTime? ExpiresOn
		{
			get
			{
				return this._expiresOn;
			}
			set
			{
				this._expiresOn = value;
			}
		}
	}
}
