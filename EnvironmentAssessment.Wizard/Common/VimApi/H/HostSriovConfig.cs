namespace EnvironmentAssessment.Common.VimApi
{
	public class HostSriovConfig : HostPciPassthruConfig
	{
		protected bool _sriovEnabled;
		protected int _numVirtualFunction;
		public bool SriovEnabled
		{
			get
			{
				return this._sriovEnabled;
			}
			set
			{
				this._sriovEnabled = value;
			}
		}
		public int NumVirtualFunction
		{
			get
			{
				return this._numVirtualFunction;
			}
			set
			{
				this._numVirtualFunction = value;
			}
		}
	}
}
