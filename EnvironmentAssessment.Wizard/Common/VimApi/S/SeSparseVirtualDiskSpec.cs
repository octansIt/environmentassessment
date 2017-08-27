namespace EnvironmentAssessment.Common.VimApi
{
	public class SeSparseVirtualDiskSpec : FileBackedVirtualDiskSpec
	{
		protected int? _grainSizeKb;
		public int? GrainSizeKb
		{
			get
			{
				return this._grainSizeKb;
			}
			set
			{
				this._grainSizeKb = value;
			}
		}
	}
}
