namespace EnvironmentAssessment.Common.VISoap
{
    public class HostSystemInfo : DynamicData
	{
		protected string _vendor;
		protected string _model;
		protected string _uuid;
		protected HostSystemIdentificationInfo[] _otherIdentifyingInfo;
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
		public HostSystemIdentificationInfo[] OtherIdentifyingInfo
		{
			get
			{
				return this._otherIdentifyingInfo;
			}
			set
			{
				this._otherIdentifyingInfo = value;
			}
		}
	}
}
