namespace EnvironmentAssessment.Common.VimApi
{
	public class OvfConsumerInvalidSection : OvfConsumerCallbackFault
	{
		protected int _lineNumber;
		protected string _description;
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
		public string Description
		{
			get
			{
				return this._description;
			}
			set
			{
				this._description = value;
			}
		}
	}
}
