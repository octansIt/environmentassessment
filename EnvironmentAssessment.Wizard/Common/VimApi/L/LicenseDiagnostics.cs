using System;

namespace EnvironmentAssessment.Common.VimApi
{
	public class LicenseDiagnostics : DynamicData
	{
		protected DateTime _sourceLastChanged;
		protected string _sourceLost;
		protected float _sourceLatency;
		protected string _licenseRequests;
		protected string _licenseRequestFailures;
		protected string _licenseFeatureUnknowns;
		protected LicenseManagerState _opState;
		protected DateTime _lastStatusUpdate;
		protected string _opFailureMessage;
		public DateTime SourceLastChanged
		{
			get
			{
				return this._sourceLastChanged;
			}
			set
			{
				this._sourceLastChanged = value;
			}
		}
		public string SourceLost
		{
			get
			{
				return this._sourceLost;
			}
			set
			{
				this._sourceLost = value;
			}
		}
		public float SourceLatency
		{
			get
			{
				return this._sourceLatency;
			}
			set
			{
				this._sourceLatency = value;
			}
		}
		public string LicenseRequests
		{
			get
			{
				return this._licenseRequests;
			}
			set
			{
				this._licenseRequests = value;
			}
		}
		public string LicenseRequestFailures
		{
			get
			{
				return this._licenseRequestFailures;
			}
			set
			{
				this._licenseRequestFailures = value;
			}
		}
		public string LicenseFeatureUnknowns
		{
			get
			{
				return this._licenseFeatureUnknowns;
			}
			set
			{
				this._licenseFeatureUnknowns = value;
			}
		}
		public LicenseManagerState OpState
		{
			get
			{
				return this._opState;
			}
			set
			{
				this._opState = value;
			}
		}
		public DateTime LastStatusUpdate
		{
			get
			{
				return this._lastStatusUpdate;
			}
			set
			{
				this._lastStatusUpdate = value;
			}
		}
		public string OpFailureMessage
		{
			get
			{
				return this._opFailureMessage;
			}
			set
			{
				this._opFailureMessage = value;
			}
		}
	}
}
