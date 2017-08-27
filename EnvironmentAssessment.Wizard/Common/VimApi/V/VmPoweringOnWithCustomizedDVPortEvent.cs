namespace EnvironmentAssessment.Common.VimApi
{
	public class VmPoweringOnWithCustomizedDVPortEvent : VmEvent
	{
		protected VnicPortArgument[] _vnic;
		public VnicPortArgument[] Vnic
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
