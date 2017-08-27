namespace EnvironmentAssessment.Common.VimApi
{
	public class InvalidArgument : RuntimeFault
	{
		protected string _invalidProperty;
		public string InvalidProperty
		{
			get
			{
				return this._invalidProperty;
			}
			set
			{
				this._invalidProperty = value;
			}
		}
	}
}
