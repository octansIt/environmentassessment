namespace EnvironmentAssessment.Common.VimApi
{
	public class MethodAlreadyDisabledFault : RuntimeFault
	{
		protected string _sourceId;
		public string SourceId
		{
			get
			{
				return this._sourceId;
			}
			set
			{
				this._sourceId = value;
			}
		}
	}
}
