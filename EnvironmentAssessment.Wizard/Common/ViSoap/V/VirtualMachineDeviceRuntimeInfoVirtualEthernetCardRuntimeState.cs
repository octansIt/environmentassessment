namespace EnvironmentAssessment.Common.VISoap
{
    public class VirtualMachineDeviceRuntimeInfoVirtualEthernetCardRuntimeState : VirtualMachineDeviceRuntimeInfoDeviceRuntimeState
	{
		protected bool _vmDirectPathGen2Active;
		protected string[] _vmDirectPathGen2InactiveReasonVm;
		protected string[] _vmDirectPathGen2InactiveReasonOther;
		protected string _vmDirectPathGen2InactiveReasonExtended;
		protected string _reservationStatus;
		public bool VmDirectPathGen2Active
		{
			get
			{
				return this._vmDirectPathGen2Active;
			}
			set
			{
				this._vmDirectPathGen2Active = value;
			}
		}
		public string[] VmDirectPathGen2InactiveReasonVm
		{
			get
			{
				return this._vmDirectPathGen2InactiveReasonVm;
			}
			set
			{
				this._vmDirectPathGen2InactiveReasonVm = value;
			}
		}
		public string[] VmDirectPathGen2InactiveReasonOther
		{
			get
			{
				return this._vmDirectPathGen2InactiveReasonOther;
			}
			set
			{
				this._vmDirectPathGen2InactiveReasonOther = value;
			}
		}
		public string VmDirectPathGen2InactiveReasonExtended
		{
			get
			{
				return this._vmDirectPathGen2InactiveReasonExtended;
			}
			set
			{
				this._vmDirectPathGen2InactiveReasonExtended = value;
			}
		}
		public string ReservationStatus
		{
			get
			{
				return this._reservationStatus;
			}
			set
			{
				this._reservationStatus = value;
			}
		}
	}
}
