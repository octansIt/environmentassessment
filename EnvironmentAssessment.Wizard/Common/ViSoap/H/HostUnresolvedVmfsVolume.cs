namespace EnvironmentAssessment.Common.VISoap
{
    public class HostUnresolvedVmfsVolume : DynamicData
	{
		protected HostUnresolvedVmfsExtent[] _extent;
		protected string _vmfsLabel;
		protected string _vmfsUuid;
		protected int _totalBlocks;
		protected HostUnresolvedVmfsVolumeResolveStatus _resolveStatus;
		public HostUnresolvedVmfsExtent[] Extent
		{
			get
			{
				return this._extent;
			}
			set
			{
				this._extent = value;
			}
		}
		public string VmfsLabel
		{
			get
			{
				return this._vmfsLabel;
			}
			set
			{
				this._vmfsLabel = value;
			}
		}
		public string VmfsUuid
		{
			get
			{
				return this._vmfsUuid;
			}
			set
			{
				this._vmfsUuid = value;
			}
		}
		public int TotalBlocks
		{
			get
			{
				return this._totalBlocks;
			}
			set
			{
				this._totalBlocks = value;
			}
		}
		public HostUnresolvedVmfsVolumeResolveStatus ResolveStatus
		{
			get
			{
				return this._resolveStatus;
			}
			set
			{
				this._resolveStatus = value;
			}
		}
	}
}
