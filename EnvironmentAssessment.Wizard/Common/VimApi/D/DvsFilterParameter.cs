namespace EnvironmentAssessment.Common.VimApi
{
	public class DvsFilterParameter : DynamicData
	{
		protected string[] _parameters;
		public string[] Parameters
		{
			get
			{
				return this._parameters;
			}
			set
			{
				this._parameters = value;
			}
		}
	}
}
