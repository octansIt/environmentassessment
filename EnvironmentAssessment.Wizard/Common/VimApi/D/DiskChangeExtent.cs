namespace EnvironmentAssessment.Common.VimApi
{
	public class DiskChangeExtent : DynamicData
	{
		protected long _start;
		protected long _length;
		public long Start
		{
			get
			{
				return this._start;
			}
			set
			{
				this._start = value;
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
	}
}
