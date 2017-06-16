namespace EnvironmentAssessment.Common.VISoap
{
    public class MacRange : MacAddress
	{
		protected string _address;
		protected string _mask;
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
		public string Mask
		{
			get
			{
				return this._mask;
			}
			set
			{
				this._mask = value;
			}
		}
	}
}
