namespace EnvironmentAssessment.Common.VimApi
{
	public class NumVirtualCpusExceedsLimit : InsufficientResourcesFault
	{
		protected int _maxSupportedVcpus;
		public int MaxSupportedVcpus
		{
			get
			{
				return this._maxSupportedVcpus;
			}
			set
			{
				this._maxSupportedVcpus = value;
			}
		}
	}
}
