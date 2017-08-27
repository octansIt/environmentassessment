namespace EnvironmentAssessment.Common.VimApi
{
	public class DvsIpPortRange : DvsIpPort
	{
		protected int _startPortNumber;
		protected int _endPortNumber;
		public int StartPortNumber
		{
			get
			{
				return this._startPortNumber;
			}
			set
			{
				this._startPortNumber = value;
			}
		}
		public int EndPortNumber
		{
			get
			{
				return this._endPortNumber;
			}
			set
			{
				this._endPortNumber = value;
			}
		}
	}
}
