namespace EnvironmentAssessment.Common.VimApi
{
    public class ModeInfo : DynamicData
	{
		protected string _browse;
		protected string _read;
		protected string _modify;
		protected string _use;
		protected string _admin;
		protected string _full;
		public string Browse
		{
			get
			{
				return this._browse;
			}
			set
			{
				this._browse = value;
			}
		}
		public string Read
		{
			get
			{
				return this._read;
			}
			set
			{
				this._read = value;
			}
		}
		public string Modify
		{
			get
			{
				return this._modify;
			}
			set
			{
				this._modify = value;
			}
		}
		public string Use
		{
			get
			{
				return this._use;
			}
			set
			{
				this._use = value;
			}
		}
		public string Admin
		{
			get
			{
				return this._admin;
			}
			set
			{
				this._admin = value;
			}
		}
		public string Full
		{
			get
			{
				return this._full;
			}
			set
			{
				this._full = value;
			}
		}
	}
}
