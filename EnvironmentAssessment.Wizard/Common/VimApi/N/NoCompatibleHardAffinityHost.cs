namespace EnvironmentAssessment.Common.VimApi
{
	public class NoCompatibleHardAffinityHost : VmConfigFault
	{
		protected string _vmName;
		public string VmName
		{
			get
			{
				return this._vmName;
			}
			set
			{
				this._vmName = value;
			}
		}
	}
}
