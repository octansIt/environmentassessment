namespace EnvironmentAssessment.Common.VISoap
{
    public class SingleMac : MacAddress
	{
		protected string _address;
		public string Address
		{
			get
			{
				return this._address;
			}
			set
			{
				this._address = value;
			}
		}
	}
}
