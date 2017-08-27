namespace EnvironmentAssessment.Common.VimApi
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
