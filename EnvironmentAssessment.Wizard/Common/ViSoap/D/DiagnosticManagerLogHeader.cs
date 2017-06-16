namespace EnvironmentAssessment.Common.VISoap
{
    public class DiagnosticManagerLogHeader : DynamicData
	{
		protected int _lineStart;
		protected int _lineEnd;
		protected string[] _lineText;
		public int LineStart
		{
			get
			{
				return this._lineStart;
			}
			set
			{
				this._lineStart = value;
			}
		}
		public int LineEnd
		{
			get
			{
				return this._lineEnd;
			}
			set
			{
				this._lineEnd = value;
			}
		}
		public string[] LineText
		{
			get
			{
				return this._lineText;
			}
			set
			{
				this._lineText = value;
			}
		}
	}
}
