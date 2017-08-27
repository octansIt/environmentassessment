namespace EnvironmentAssessment.Common.VimApi
{
	public class ReplicationInfoDiskSettings : DynamicData
	{
		protected int _key;
		protected string _diskReplicationId;
		public int Key
		{
			get
			{
				return this._key;
			}
			set
			{
				this._key = value;
			}
		}
		public string DiskReplicationId
		{
			get
			{
				return this._diskReplicationId;
			}
			set
			{
				this._diskReplicationId = value;
			}
		}
	}
}
