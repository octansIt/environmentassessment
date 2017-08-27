namespace EnvironmentAssessment.Common.VimApi
{
	public class VsanHostDiskResult : DynamicData
	{
		protected HostScsiDisk _disk;
		protected string _state;
		protected string _vsanUuid;
		protected LocalizedMethodFault _error;
		protected bool? _degraded;
		public HostScsiDisk Disk
		{
			get
			{
				return this._disk;
			}
			set
			{
				this._disk = value;
			}
		}
		public string State
		{
			get
			{
				return this._state;
			}
			set
			{
				this._state = value;
			}
		}
		public string VsanUuid
		{
			get
			{
				return this._vsanUuid;
			}
			set
			{
				this._vsanUuid = value;
			}
		}
		public LocalizedMethodFault Error
		{
			get
			{
				return this._error;
			}
			set
			{
				this._error = value;
			}
		}
		public bool? Degraded
		{
			get
			{
				return this._degraded;
			}
			set
			{
				this._degraded = value;
			}
		}
	}
}
