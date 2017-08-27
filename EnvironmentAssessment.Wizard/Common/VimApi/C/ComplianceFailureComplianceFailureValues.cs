namespace EnvironmentAssessment.Common.VimApi
{
	public class ComplianceFailureComplianceFailureValues : DynamicData
	{
		protected string _comparisonIdentifier;
		protected string _profileInstance;
		protected object _hostValue;
		protected object _profileValue;
		public string ComparisonIdentifier
		{
			get
			{
				return this._comparisonIdentifier;
			}
			set
			{
				this._comparisonIdentifier = value;
			}
		}
		public string ProfileInstance
		{
			get
			{
				return this._profileInstance;
			}
			set
			{
				this._profileInstance = value;
			}
		}
		public object HostValue
		{
			get
			{
				return this._hostValue;
			}
			set
			{
				this._hostValue = value;
			}
		}
		public object ProfileValue
		{
			get
			{
				return this._profileValue;
			}
			set
			{
				this._profileValue = value;
			}
		}
	}
}
