namespace EnvironmentAssessment.Common.VISoap
{
    public class DrsVmotionIncompatibleFault : VirtualHardwareCompatibilityIssue
	{
		protected ManagedObjectReference _host;
		protected DrsVmotionIncompatibleFault_LinkedView _linkedView;
		public ManagedObjectReference Host
		{
			get
			{
				return this._host;
			}
			set
			{
				this._host = value;
			}
		}
		public DrsVmotionIncompatibleFault_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
