namespace EnvironmentAssessment.Common.VimApi
{
	public class OvfUnsupportedPackage : OvfFault
	{
		protected int? _lineNumber;
		public int? LineNumber
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
	}
}
