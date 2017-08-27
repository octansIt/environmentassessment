namespace EnvironmentAssessment.Common.VimApi
{
	public class VmfsConfigOption : DynamicData
	{
		protected int _blockSizeOption;
		protected int[] _unmapGranularityOption;
		public int BlockSizeOption
		{
			get
			{
				return this._blockSizeOption;
			}
			set
			{
				this._blockSizeOption = value;
			}
		}
		public int[] UnmapGranularityOption
		{
			get
			{
				return this._unmapGranularityOption;
			}
			set
			{
				this._unmapGranularityOption = value;
			}
		}
	}
}
