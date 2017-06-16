namespace EnvironmentAssessment.Common.VISoap
{
    public class DVSNameArrayUplinkPortPolicy : DVSUplinkPortPolicy
	{
		protected string[] _uplinkPortName;
		public string[] UplinkPortName
		{
			get
			{
				return this._uplinkPortName;
			}
			set
			{
				this._uplinkPortName = value;
			}
		}
	}
}
