namespace EnvironmentAssessment.Common.VimApi
{
	public class VirtualSCSIControllerOption : VirtualControllerOption
	{
		protected IntOption _numSCSIDisks;
		protected IntOption _numSCSICdroms;
		protected IntOption _numSCSIPassthrough;
		protected VirtualSCSISharing[] _sharing;
		protected int _defaultSharedIndex;
		protected BoolOption _hotAddRemove;
		protected int _scsiCtlrUnitNumber;
		public IntOption NumSCSIDisks
		{
			get
			{
				return this._numSCSIDisks;
			}
			set
			{
				this._numSCSIDisks = value;
			}
		}
		public IntOption NumSCSICdroms
		{
			get
			{
				return this._numSCSICdroms;
			}
			set
			{
				this._numSCSICdroms = value;
			}
		}
		public IntOption NumSCSIPassthrough
		{
			get
			{
				return this._numSCSIPassthrough;
			}
			set
			{
				this._numSCSIPassthrough = value;
			}
		}
		public VirtualSCSISharing[] Sharing
		{
			get
			{
				return this._sharing;
			}
			set
			{
				this._sharing = value;
			}
		}
		public int DefaultSharedIndex
		{
			get
			{
				return this._defaultSharedIndex;
			}
			set
			{
				this._defaultSharedIndex = value;
			}
		}
		public BoolOption HotAddRemove
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
		public int ScsiCtlrUnitNumber
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
