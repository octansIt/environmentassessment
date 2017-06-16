namespace EnvironmentAssessment.Common.VISoap
{
    public class HostSystemSwapConfiguration : DynamicData
	{
		protected HostSystemSwapConfigurationSystemSwapOption[] _option;
		public HostSystemSwapConfigurationSystemSwapOption[] Option
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
