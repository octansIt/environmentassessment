namespace EnvironmentAssessment.Common.VimApi
{
	public class DvsProfile : ApplyProfile
	{
		protected string _key;
		protected string _name;
		protected PnicUplinkProfile[] _uplink;
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
		public PnicUplinkProfile[] Uplink
		{
			get
			{
				return this._uplink;
			}
			set
			{
				this._uplink = value;
			}
		}
	}
}
