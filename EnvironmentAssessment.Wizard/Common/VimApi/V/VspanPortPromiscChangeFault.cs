namespace EnvironmentAssessment.Common.VimApi
{
	public class VspanPortPromiscChangeFault : DvsFault
	{
		protected string _portKey;
		public string PortKey
		{
			get
			{
				return this._portKey;
			}
			set
			{
				this._portKey = value;
			}
		}
	}
}
