namespace EnvironmentAssessment.Common.VISoap
{
    public class HostStorageElementInfo : HostHardwareElementInfo
	{
		protected HostStorageOperationalInfo[] _operationalInfo;
		public HostStorageOperationalInfo[] OperationalInfo
		{
			get
			{
				return this._operationalInfo;
			}
			set
			{
				this._operationalInfo = value;
			}
		}
	}
}
