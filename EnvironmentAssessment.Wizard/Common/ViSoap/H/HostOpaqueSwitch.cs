namespace EnvironmentAssessment.Common.VISoap
{
    public class HostOpaqueSwitch : DynamicData
	{
		protected string _key;
		protected string _name;
		protected string[] _pnic;
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
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				this._name = value;
			}
		}
		public string[] Pnic
		{
			get
			{
				return this._pnic;
			}
			set
			{
				this._pnic = value;
			}
		}
	}
}
