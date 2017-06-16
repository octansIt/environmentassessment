namespace EnvironmentAssessment.Common.VISoap
{
    public class OutOfBounds : VimFault
	{
		protected string _argumentName;
		public string ArgumentName
		{
			get
			{
				return this._argumentName;
			}
			set
			{
				this._argumentName = value;
			}
		}
	}
}
