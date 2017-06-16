namespace EnvironmentAssessment.Common.VISoap
{
    public class ClusterDasFailoverLevelAdvancedRuntimeInfo : ClusterDasAdvancedRuntimeInfo
	{
		protected ClusterDasFailoverLevelAdvancedRuntimeInfoSlotInfo _slotInfo;
		protected int _totalSlots;
		protected int _usedSlots;
		protected int _unreservedSlots;
		protected int _totalVms;
		protected int _totalHosts;
		protected int _totalGoodHosts;
		protected ClusterDasFailoverLevelAdvancedRuntimeInfoHostSlots[] _hostSlots;
		protected ClusterDasFailoverLevelAdvancedRuntimeInfoVmSlots[] _vmsRequiringMultipleSlots;
		public ClusterDasFailoverLevelAdvancedRuntimeInfoSlotInfo SlotInfo
		{
			get
			{
				return this._slotInfo;
			}
			set
			{
				this._slotInfo = value;
			}
		}
		public int TotalSlots
		{
			get
			{
				return this._totalSlots;
			}
			set
			{
				this._totalSlots = value;
			}
		}
		public int UsedSlots
		{
			get
			{
				return this._usedSlots;
			}
			set
			{
				this._usedSlots = value;
			}
		}
		public int UnreservedSlots
		{
			get
			{
				return this._unreservedSlots;
			}
			set
			{
				this._unreservedSlots = value;
			}
		}
		public int TotalVms
		{
			get
			{
				return this._totalVms;
			}
			set
			{
				this._totalVms = value;
			}
		}
		public int TotalHosts
		{
			get
			{
				return this._totalHosts;
			}
			set
			{
				this._totalHosts = value;
			}
		}
		public int TotalGoodHosts
		{
			get
			{
				return this._totalGoodHosts;
			}
			set
			{
				this._totalGoodHosts = value;
			}
		}
		public ClusterDasFailoverLevelAdvancedRuntimeInfoHostSlots[] HostSlots
		{
			get
			{
				return this._hostSlots;
			}
			set
			{
				this._hostSlots = value;
			}
		}
		public ClusterDasFailoverLevelAdvancedRuntimeInfoVmSlots[] VmsRequiringMultipleSlots
		{
			get
			{
				return this._vmsRequiringMultipleSlots;
			}
			set
			{
				this._vmsRequiringMultipleSlots = value;
			}
		}
	}
}
