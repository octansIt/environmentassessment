namespace EnvironmentAssessment.Common.VimApi
{
	public class HostAccessControlEntry : DynamicData
	{
		protected string _principal;
		protected bool _group;
		protected HostAccessMode _accessMode;
		public string Principal
		{
			get
			{
				return this._principal;
			}
			set
			{
				this._principal = value;
			}
		}
		public bool Group
		{
			get
			{
				return this._group;
			}
			set
			{
				this._group = value;
			}
		}
		public HostAccessMode AccessMode
		{
			get
			{
				return this._accessMode;
			}
			set
			{
				this._accessMode = value;
			}
		}
	}
}
