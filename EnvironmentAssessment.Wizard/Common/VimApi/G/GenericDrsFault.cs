namespace EnvironmentAssessment.Common.VimApi
{
	public class GenericDrsFault : VimFault
	{
		protected LocalizedMethodFault[] _hostFaults;
		public LocalizedMethodFault[] HostFaults
		{
			get
			{
				return this._hostFaults;
			}
			set
			{
				this._hostFaults = value;
			}
		}
	}
}
