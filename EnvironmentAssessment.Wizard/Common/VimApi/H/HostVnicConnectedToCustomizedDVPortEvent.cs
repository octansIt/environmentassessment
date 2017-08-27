namespace EnvironmentAssessment.Common.VimApi
{
	public class HostVnicConnectedToCustomizedDVPortEvent : HostEvent
	{
		protected VnicPortArgument _vnic;
		protected string _prevPortKey;
		public VnicPortArgument Vnic
		{
			get
			{
				return this._vnic;
			}
			set
			{
				this._vnic = value;
			}
		}
		public string PrevPortKey
		{
			get
			{
				return this._prevPortKey;
			}
			set
			{
				this._prevPortKey = value;
			}
		}
	}
}
