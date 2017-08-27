namespace EnvironmentAssessment.Common.VimApi
{
	public class HostFlagInfo : DynamicData
	{
		protected bool? _backgroundSnapshotsEnabled;
		public bool? BackgroundSnapshotsEnabled
		{
			get
			{
				return this._backgroundSnapshotsEnabled;
			}
			set
			{
				this._backgroundSnapshotsEnabled = value;
			}
		}
	}
}
