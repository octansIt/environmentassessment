namespace EnvironmentAssessment.Common.VISoap
{
    public class HostInternetScsiHbaDigestProperties : DynamicData
	{
		protected string _headerDigestType;
		protected bool? _headerDigestInherited;
		protected string _dataDigestType;
		protected bool? _dataDigestInherited;
		public string HeaderDigestType
		{
			get
			{
				return this._headerDigestType;
			}
			set
			{
				this._headerDigestType = value;
			}
		}
		public bool? HeaderDigestInherited
		{
			get
			{
				return this._headerDigestInherited;
			}
			set
			{
				this._headerDigestInherited = value;
			}
		}
		public string DataDigestType
		{
			get
			{
				return this._dataDigestType;
			}
			set
			{
				this._dataDigestType = value;
			}
		}
		public bool? DataDigestInherited
		{
			get
			{
				return this._dataDigestInherited;
			}
			set
			{
				this._dataDigestInherited = value;
			}
		}
	}
}
