namespace EnvironmentAssessment.Common.VISoap
{
    public class PatchInstallFailed : PlatformConfigFault
	{
		protected bool _rolledBack;
		public bool RolledBack
		{
			get
			{
				return this._rolledBack;
			}
			set
			{
				this._rolledBack = value;
			}
		}
	}
}
