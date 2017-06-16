namespace EnvironmentAssessment.Common.VISoap
{
    public class ClusterDasFailoverLevelAdvancedRuntimeInfoHostSlots : DynamicData
	{
		protected ManagedObjectReference _host;
		protected int _slots;
		protected ClusterDasFailoverLevelAdvancedRuntimeInfoHostSlots_LinkedView _linkedView;
		public ManagedObjectReference Host
		{
			get
			{
				return this._host;
			}
			set
			{
				this._host = value;
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
		public ClusterDasFailoverLevelAdvancedRuntimeInfoHostSlots_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
