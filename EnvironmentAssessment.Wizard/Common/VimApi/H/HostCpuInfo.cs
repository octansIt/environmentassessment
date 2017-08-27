namespace EnvironmentAssessment.Common.VimApi
{
	public class HostCpuInfo : DynamicData
	{
		protected short _numCpuPackages;
		protected short _numCpuCores;
		protected short _numCpuThreads;
		protected long _hz;
		public short NumCpuPackages
		{
			get
			{
				return this._numCpuPackages;
			}
			set
			{
				this._numCpuPackages = value;
			}
		}
		public short NumCpuCores
		{
			get
			{
				return this._numCpuCores;
			}
			set
			{
				this._numCpuCores = value;
			}
		}
		public short NumCpuThreads
		{
			get
			{
				return this._numCpuThreads;
			}
			set
			{
				this._numCpuThreads = value;
			}
		}
		public long Hz
		{
			get
			{
				return this._hz;
			}
			set
			{
				this._hz = value;
			}
		}
	}
}
