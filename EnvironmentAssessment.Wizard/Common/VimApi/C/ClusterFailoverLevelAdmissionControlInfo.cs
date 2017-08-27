namespace EnvironmentAssessment.Common.VimApi
{
	public class ClusterFailoverLevelAdmissionControlInfo : ClusterDasAdmissionControlInfo
	{
		protected int _currentFailoverLevel;
		public int CurrentFailoverLevel
		{
			get
			{
				return this._currentFailoverLevel;
			}
			set
			{
				this._currentFailoverLevel = value;
			}
		}
	}
}
