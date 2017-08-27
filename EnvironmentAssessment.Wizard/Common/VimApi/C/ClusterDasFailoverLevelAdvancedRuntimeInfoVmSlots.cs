namespace EnvironmentAssessment.Common.VimApi
{
	public class ClusterDasFailoverLevelAdvancedRuntimeInfoVmSlots : DynamicData
	{
		protected ManagedObjectReference _vm;
		protected int _slots;
		protected ClusterDasFailoverLevelAdvancedRuntimeInfoVmSlots_LinkedView _linkedView;
		public ManagedObjectReference Vm
		{
			get
			{
				return this._vm;
			}
			set
			{
				this._vm = value;
			}
		}
		public int Slots
		{
			get
			{
				return this._slots;
			}
			set
			{
				this._slots = value;
			}
		}
		public ClusterDasFailoverLevelAdvancedRuntimeInfoVmSlots_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
