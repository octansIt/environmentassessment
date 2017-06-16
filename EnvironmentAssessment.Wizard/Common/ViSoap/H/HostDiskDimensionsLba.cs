namespace EnvironmentAssessment.Common.VISoap
{
    public class HostDiskDimensionsLba : DynamicData
	{
		protected int _blockSize;
		protected long _block;
		public int BlockSize
		{
			get
			{
				return this._blockSize;
			}
			set
			{
				this._blockSize = value;
			}
		}
		public long Block
		{
			get
			{
				return this._block;
			}
			set
			{
				this._block = value;
			}
		}
	}
}
