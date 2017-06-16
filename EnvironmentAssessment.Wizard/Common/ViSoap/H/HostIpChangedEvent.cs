namespace EnvironmentAssessment.Common.VISoap
{
    public class HostIpChangedEvent : HostEvent
	{
		protected string _oldIP;
		protected string _newIP;
		public string OldIP
		{
			get
			{
				return this._oldIP;
			}
			set
			{
				this._oldIP = value;
			}
		}
		public string NewIP
		{
			get
			{
				return this._newIP;
			}
			set
			{
				this._newIP = value;
			}
		}
	}
}
