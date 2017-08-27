namespace EnvironmentAssessment.Common.VimApi
{
	public class VsanHostVsanDiskInfo : DynamicData
	{
		protected string _vsanUuid;
		protected int _formatVersion;
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
		public int FormatVersion
		{
			get
			{
				return this._formatVersion;
			}
			set
			{
				this._formatVersion = value;
			}
		}
	}
}
