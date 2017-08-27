namespace EnvironmentAssessment.Common.VimApi
{
	public class VirtualSCSIController : VirtualController
	{
		protected bool? _hotAddRemove;
		protected VirtualSCSISharing _sharedBus;
		protected int? _scsiCtlrUnitNumber;
		public bool? HotAddRemove
		{
			get
			{
				return this._hotAddRemove;
			}
			set
			{
				this._hotAddRemove = value;
			}
		}
		public VirtualSCSISharing SharedBus
		{
			get
			{
				return this._sharedBus;
			}
			set
			{
				this._sharedBus = value;
			}
		}
		public int? ScsiCtlrUnitNumber
		{
			get
			{
				return this._scsiCtlrUnitNumber;
			}
			set
			{
				this._scsiCtlrUnitNumber = value;
			}
		}
	}
}
