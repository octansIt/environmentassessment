namespace EnvironmentAssessment.Common.VimApi
{
	public class DistributedVirtualSwitchPortStatistics : DynamicData
	{
		protected long _packetsInMulticast;
		protected long _packetsOutMulticast;
		protected long _bytesInMulticast;
		protected long _bytesOutMulticast;
		protected long _packetsInUnicast;
		protected long _packetsOutUnicast;
		protected long _bytesInUnicast;
		protected long _bytesOutUnicast;
		protected long _packetsInBroadcast;
		protected long _packetsOutBroadcast;
		protected long _bytesInBroadcast;
		protected long _bytesOutBroadcast;
		protected long _packetsInDropped;
		protected long _packetsOutDropped;
		protected long _packetsInException;
		protected long _packetsOutException;
		protected long? _bytesInFromPnic;
		protected long? _bytesOutToPnic;
		public long PacketsInMulticast
		{
			get
			{
				return this._packetsInMulticast;
			}
			set
			{
				this._packetsInMulticast = value;
			}
		}
		public long PacketsOutMulticast
		{
			get
			{
				return this._packetsOutMulticast;
			}
			set
			{
				this._packetsOutMulticast = value;
			}
		}
		public long BytesInMulticast
		{
			get
			{
				return this._bytesInMulticast;
			}
			set
			{
				this._bytesInMulticast = value;
			}
		}
		public long BytesOutMulticast
		{
			get
			{
				return this._bytesOutMulticast;
			}
			set
			{
				this._bytesOutMulticast = value;
			}
		}
		public long PacketsInUnicast
		{
			get
			{
				return this._packetsInUnicast;
			}
			set
			{
				this._packetsInUnicast = value;
			}
		}
		public long PacketsOutUnicast
		{
			get
			{
				return this._packetsOutUnicast;
			}
			set
			{
				this._packetsOutUnicast = value;
			}
		}
		public long BytesInUnicast
		{
			get
			{
				return this._bytesInUnicast;
			}
			set
			{
				this._bytesInUnicast = value;
			}
		}
		public long BytesOutUnicast
		{
			get
			{
				return this._bytesOutUnicast;
			}
			set
			{
				this._bytesOutUnicast = value;
			}
		}
		public long PacketsInBroadcast
		{
			get
			{
				return this._packetsInBroadcast;
			}
			set
			{
				this._packetsInBroadcast = value;
			}
		}
		public long PacketsOutBroadcast
		{
			get
			{
				return this._packetsOutBroadcast;
			}
			set
			{
				this._packetsOutBroadcast = value;
			}
		}
		public long BytesInBroadcast
		{
			get
			{
				return this._bytesInBroadcast;
			}
			set
			{
				this._bytesInBroadcast = value;
			}
		}
		public long BytesOutBroadcast
		{
			get
			{
				return this._bytesOutBroadcast;
			}
			set
			{
				this._bytesOutBroadcast = value;
			}
		}
		public long PacketsInDropped
		{
			get
			{
				return this._packetsInDropped;
			}
			set
			{
				this._packetsInDropped = value;
			}
		}
		public long PacketsOutDropped
		{
			get
			{
				return this._packetsOutDropped;
			}
			set
			{
				this._packetsOutDropped = value;
			}
		}
		public long PacketsInException
		{
			get
			{
				return this._packetsInException;
			}
			set
			{
				this._packetsInException = value;
			}
		}
		public long PacketsOutException
		{
			get
			{
				return this._packetsOutException;
			}
			set
			{
				this._packetsOutException = value;
			}
		}
		public long? BytesInFromPnic
		{
			get
			{
				return this._bytesInFromPnic;
			}
			set
			{
				this._bytesInFromPnic = value;
			}
		}
		public long? BytesOutToPnic
		{
			get
			{
				return this._bytesOutToPnic;
			}
			set
			{
				this._bytesOutToPnic = value;
			}
		}
	}
}
