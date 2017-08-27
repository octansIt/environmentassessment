namespace EnvironmentAssessment.Common.VimApi
{
	public class EVCAdmissionFailed : NotSupportedHostInCluster
	{
		protected LocalizedMethodFault[] _faults;
		public LocalizedMethodFault[] Faults
		{
			get
			{
				return this._faults;
			}
			set
			{
				this._faults = value;
			}
		}
	}
}
