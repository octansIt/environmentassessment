namespace EnvironmentAssessment.Common.VimApi
{
	public class VMwareUplinkPortOrderPolicy : InheritablePolicy
	{
		protected string[] _activeUplinkPort;
		protected string[] _standbyUplinkPort;
		public string[] ActiveUplinkPort
		{
			get
			{
				return this._activeUplinkPort;
			}
			set
			{
				this._activeUplinkPort = value;
			}
		}
		public string[] StandbyUplinkPort
		{
			get
			{
				return this._standbyUplinkPort;
			}
			set
			{
				this._standbyUplinkPort = value;
			}
		}
	}
}
