namespace EnvironmentAssessment.Common.VISoap
{
    public class VsanHostDiskMapping : DynamicData
	{
		protected HostScsiDisk _ssd;
		protected HostScsiDisk[] _nonSsd;
		public HostScsiDisk Ssd
		{
			get
			{
				return this._ssd;
			}
			set
			{
				this._ssd = value;
			}
		}
		public HostScsiDisk[] NonSsd
		{
			get
			{
				return this._nonSsd;
			}
			set
			{
				this._nonSsd = value;
			}
		}
	}
}
