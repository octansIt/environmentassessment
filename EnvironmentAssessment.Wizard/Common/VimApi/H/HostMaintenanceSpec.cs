namespace EnvironmentAssessment.Common.VimApi
{
	public class HostMaintenanceSpec : DynamicData
	{
		protected VsanHostDecommissionMode _vsanMode;
		public VsanHostDecommissionMode VsanMode
		{
			get
			{
				return this._vsanMode;
			}
			set
			{
				this._vsanMode = value;
			}
		}
	}
}
