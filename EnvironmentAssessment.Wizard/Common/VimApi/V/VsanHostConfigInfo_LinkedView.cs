namespace EnvironmentAssessment.Common.VimApi
{
	public class VsanHostConfigInfo_LinkedView
	{
		protected HostSystem _hostSystem;
		public HostSystem HostSystem
		{
			get
			{
				return this._hostSystem;
			}
			set
			{
				this._hostSystem = value;
			}
		}
	}
}
