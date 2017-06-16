namespace EnvironmentAssessment.Common.VISoap
{
    public class MemorySizeNotRecommended : VirtualHardwareCompatibilityIssue
	{
		protected int _memorySizeMB;
		protected int _minMemorySizeMB;
		protected int _maxMemorySizeMB;
		public int MemorySizeMB
		{
			get
			{
				return this._memorySizeMB;
			}
			set
			{
				this._memorySizeMB = value;
			}
		}
		public int MinMemorySizeMB
		{
			get
			{
				return this._minMemorySizeMB;
			}
			set
			{
				this._minMemorySizeMB = value;
			}
		}
		public int MaxMemorySizeMB
		{
			get
			{
				return this._maxMemorySizeMB;
			}
			set
			{
				this._maxMemorySizeMB = value;
			}
		}
	}
}
