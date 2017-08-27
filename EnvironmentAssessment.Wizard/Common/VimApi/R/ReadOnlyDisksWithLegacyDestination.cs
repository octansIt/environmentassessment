namespace EnvironmentAssessment.Common.VimApi
{
	public class ReadOnlyDisksWithLegacyDestination : MigrationFault
	{
		protected int _roDiskCount;
		protected bool _timeoutDanger;
		public int RoDiskCount
		{
			get
			{
				return this._roDiskCount;
			}
			set
			{
				this._roDiskCount = value;
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
