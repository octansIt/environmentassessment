namespace EnvironmentAssessment.Common.VISoap
{
    public class StorageDrsOptionSpec : ArrayUpdateSpec
	{
		protected OptionValue _option;
		public OptionValue Option
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
