namespace EnvironmentAssessment.Common.VimApi
{
	public class DvsSingleIpPort : DvsIpPort
	{
		protected int _portNumber;
		public int PortNumber
		{
			get
			{
				return this._portNumber;
			}
			set
			{
				this._portNumber = value;
			}
		}
	}
}
