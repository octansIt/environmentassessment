namespace EnvironmentAssessment.Common.VimApi
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
