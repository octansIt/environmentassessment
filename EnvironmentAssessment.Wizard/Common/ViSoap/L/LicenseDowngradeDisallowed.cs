namespace EnvironmentAssessment.Common.VISoap
{
    public class LicenseDowngradeDisallowed : NotEnoughLicenses
	{
		protected string _edition;
		protected string _entityId;
		protected KeyAnyValue[] _features;
		public string Edition
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
		public string EntityId
		{
			get
			{
				return this._entityId;
			}
			set
			{
				this._entityId = value;
			}
		}
		public KeyAnyValue[] Features
		{
			get
			{
				return this._features;
			}
			set
			{
				this._features = value;
			}
		}
	}
}
