namespace EnvironmentAssessment.Common.VimApi
{
	public class FaultToleranceVMConfigSpec_LinkedView
	{
		protected Datastore _vmConfig;
		public Datastore VmConfig
		{
			get
			{
				return this._vmConfig;
			}
			set
			{
				this._vmConfig = value;
			}
		}
	}
}
