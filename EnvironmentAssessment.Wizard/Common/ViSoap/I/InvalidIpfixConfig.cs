namespace EnvironmentAssessment.Common.VISoap
{
    public class InvalidIpfixConfig : DvsFault
	{
		protected string _property;
		public string Property
		{
			get
			{
				return this._property;
			}
			set
			{
				this._property = value;
			}
		}
	}
}
