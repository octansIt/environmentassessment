namespace EnvironmentAssessment.Common.VimApi
{
	public class VsanHostDiskMapInfo : DynamicData
	{
		protected VsanHostDiskMapping _mapping;
		protected bool _mounted;
		public VsanHostDiskMapping Mapping
		{
			get
			{
				return this._mapping;
			}
			set
			{
				this._mapping = value;
			}
		}
		public bool Mounted
		{
			get
			{
				return this._mounted;
			}
			set
			{
				this._mounted = value;
			}
		}
	}
}
