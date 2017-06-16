namespace EnvironmentAssessment.Common.VISoap
{
    public class VmfsDatastoreInfoScsiLunInfo : DynamicData
	{
		protected string _key;
		protected string _canonicalName;
		protected string _uuid;
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
		public string CanonicalName
		{
			get
			{
				return this._canonicalName;
			}
			set
			{
				this._canonicalName = value;
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
	}
}
