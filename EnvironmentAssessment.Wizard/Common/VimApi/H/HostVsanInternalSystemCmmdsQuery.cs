namespace EnvironmentAssessment.Common.VimApi
{
	public class HostVsanInternalSystemCmmdsQuery : DynamicData
	{
		protected string _type;
		protected string _uuid;
		protected string _owner;
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
		public string Owner
		{
			get
			{
				return this._owner;
			}
			set
			{
				this._owner = value;
			}
		}
	}
}
