namespace EnvironmentAssessment.Common.VimApi
{
	public class DvsPortReconfiguredEvent : DvsEvent
	{
		protected string[] _portKey;
		protected ChangesInfoEventArgument[] _configChanges;
		public string[] PortKey
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
		public ChangesInfoEventArgument[] ConfigChanges
		{
			get
			{
				return this._configChanges;
			}
			set
			{
				this._configChanges = value;
			}
		}
	}
}
