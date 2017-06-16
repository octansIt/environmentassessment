namespace EnvironmentAssessment.Common.VISoap
{
    public class HostPortGroupPort : DynamicData
	{
		protected string _key;
		protected string[] _mac;
		protected string _type;
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
		public string[] Mac
		{
			get
			{
				return this._mac;
			}
			set
			{
				this._mac = value;
			}
		}
		public string Type
		{
			get
			{
				return this._type;
			}
			set
			{
				this._type = value;
			}
		}
	}
}
