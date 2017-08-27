namespace EnvironmentAssessment.Common.VimApi
{
	public class DistributedVirtualSwitchInfo : DynamicData
	{
		protected string _switchName;
		protected string _switchUuid;
		protected ManagedObjectReference _distributedVirtualSwitch;
		protected bool? _networkReservationSupported;
		protected DistributedVirtualSwitchInfo_LinkedView _linkedView;
		public string SwitchName
		{
			get
			{
				return this._switchName;
			}
			set
			{
				this._switchName = value;
			}
		}
		public string SwitchUuid
		{
			get
			{
				return this._switchUuid;
			}
			set
			{
				this._switchUuid = value;
			}
		}
		public ManagedObjectReference DistributedVirtualSwitch
		{
			get
			{
				return this._distributedVirtualSwitch;
			}
			set
			{
				this._distributedVirtualSwitch = value;
			}
		}
		public bool? NetworkReservationSupported
		{
			get
			{
				return this._networkReservationSupported;
			}
			set
			{
				this._networkReservationSupported = value;
			}
		}
		public DistributedVirtualSwitchInfo_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
