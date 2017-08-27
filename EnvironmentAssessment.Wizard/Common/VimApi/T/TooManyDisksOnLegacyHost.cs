namespace EnvironmentAssessment.Common.VimApi
{
	public class TooManyDisksOnLegacyHost : MigrationFault
	{
		protected int _diskCount;
		protected bool _timeoutDanger;
		public int DiskCount
		{
			get
			{
				return this._diskCount;
			}
			set
			{
				this._diskCount = value;
			}
		}
		public bool TimeoutDanger
		{
			get
			{
				return this._timeoutDanger;
			}
			set
			{
				this._timeoutDanger = value;
			}
		}
	}
}
