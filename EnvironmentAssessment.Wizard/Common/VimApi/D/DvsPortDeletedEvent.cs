namespace EnvironmentAssessment.Common.VimApi
{
	public class DvsPortDeletedEvent : DvsEvent
	{
		protected string[] _portKey;
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
	}
}
