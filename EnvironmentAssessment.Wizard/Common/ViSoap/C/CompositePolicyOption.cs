namespace EnvironmentAssessment.Common.VISoap
{
    public class CompositePolicyOption : PolicyOption
	{
		protected PolicyOption[] _option;
		public PolicyOption[] Option
		{
			get
			{
				return this._option;
			}
			set
			{
				this._option = value;
			}
		}
	}
}
