namespace EnvironmentAssessment.Common.VimApi
{
	public class VMotionInterfaceIssue_LinkedView
	{
		protected HostSystem _failedHostEntity;
		public HostSystem FailedHostEntity
		{
			get
			{
				return this._failedHostEntity;
			}
			set
			{
				this._failedHostEntity = value;
			}
		}
	}
}
