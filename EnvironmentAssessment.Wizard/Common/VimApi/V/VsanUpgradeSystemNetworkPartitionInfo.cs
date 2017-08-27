namespace EnvironmentAssessment.Common.VimApi
{
	public class VsanUpgradeSystemNetworkPartitionInfo : DynamicData
	{
		protected ManagedObjectReference[] _hosts;
		protected VsanUpgradeSystemNetworkPartitionInfo_LinkedView _linkedView;
		public ManagedObjectReference[] Hosts
		{
			get
			{
				return this._hosts;
			}
			set
			{
				this._hosts = value;
			}
		}
		public VsanUpgradeSystemNetworkPartitionInfo_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
