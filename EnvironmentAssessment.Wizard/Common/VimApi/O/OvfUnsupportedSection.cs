namespace EnvironmentAssessment.Common.VimApi
{
	public class OvfUnsupportedSection : OvfUnsupportedElement
	{
		protected string _info;
		public string Info
		{
			get
			{
				return this._info;
			}
			set
			{
				this._info = value;
			}
		}
	}
}
