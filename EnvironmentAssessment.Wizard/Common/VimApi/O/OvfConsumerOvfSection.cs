namespace EnvironmentAssessment.Common.VimApi
{
	public class OvfConsumerOvfSection : DynamicData
	{
		protected int _lineNumber;
		protected string _xml;
		public int LineNumber
		{
			get
			{
				return this._lineNumber;
			}
			set
			{
				this._lineNumber = value;
			}
		}
		public string Xml
		{
			get
			{
				return this._xml;
			}
			set
			{
				this._xml = value;
			}
		}
	}
}
