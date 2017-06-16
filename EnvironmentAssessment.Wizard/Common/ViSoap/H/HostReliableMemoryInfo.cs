namespace EnvironmentAssessment.Common.VISoap
{
    public class HostReliableMemoryInfo : DynamicData
	{
		protected long _memorySize;
		public long MemorySize
		{
			get
			{
				return this._memorySize;
			}
			set
			{
				this._memorySize = value;
			}
		}
	}
}
