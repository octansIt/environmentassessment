namespace EnvironmentAssessment.Common.VimApi
{
	public class MethodDisabled : RuntimeFault
	{
		protected string _source;
		public string Source
		{
			get
			{
				return this._source;
			}
			set
			{
				this._source = value;
			}
		}
	}
}
