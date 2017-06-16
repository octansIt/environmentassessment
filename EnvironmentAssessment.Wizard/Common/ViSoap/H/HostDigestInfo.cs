namespace EnvironmentAssessment.Common.VISoap
{
    public class HostDigestInfo : DynamicData
	{
		protected string _digestMethod;
		protected sbyte[] _digestValue;
		protected string _objectName;
		public string DigestMethod
		{
			get
			{
				return this._digestMethod;
			}
			set
			{
				this._digestMethod = value;
			}
		}
		public sbyte[] DigestValue
		{
			get
			{
				return this._digestValue;
			}
			set
			{
				this._digestValue = value;
			}
		}
		public string ObjectName
		{
			get
			{
				return this._objectName;
			}
			set
			{
				this._objectName = value;
			}
		}
	}
}
