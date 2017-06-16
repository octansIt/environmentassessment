namespace EnvironmentAssessment.Common.VISoap
{
    public class HostSystemReconnectSpec : DynamicData
	{
		protected bool? _syncState;
		public bool? SyncState
		{
			get
			{
				return this._syncState;
			}
			set
			{
				this._syncState = value;
			}
		}
	}
}
