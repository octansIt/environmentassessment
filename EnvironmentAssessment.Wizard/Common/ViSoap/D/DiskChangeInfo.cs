namespace EnvironmentAssessment.Common.VISoap
{
    public class DiskChangeInfo : DynamicData
	{
		protected long _startOffset;
		protected long _length;
		protected DiskChangeExtent[] _changedArea;
		public long StartOffset
		{
			get
			{
				return this._startOffset;
			}
			set
			{
				this._startOffset = value;
			}
		}
		public long Length
		{
			get
			{
				return this._length;
			}
			set
			{
				this._length = value;
			}
		}
		public DiskChangeExtent[] ChangedArea
		{
			get
			{
				return this._changedArea;
			}
			set
			{
				this._changedArea = value;
			}
		}
	}
}
