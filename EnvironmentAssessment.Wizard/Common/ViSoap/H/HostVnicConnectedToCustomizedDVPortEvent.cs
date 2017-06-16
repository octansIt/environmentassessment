namespace EnvironmentAssessment.Common.VISoap
{
    public class HostVnicConnectedToCustomizedDVPortEvent : HostEvent
	{
		protected VnicPortArgument _vnic;
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
	}
}
