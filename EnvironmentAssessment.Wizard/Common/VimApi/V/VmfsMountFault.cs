namespace EnvironmentAssessment.Common.VimApi
{
	public class VmfsMountFault : HostConfigFault
	{
		protected string _uuid;
		public string Uuid
		{
			get
			{
				return this._uuid;
			}
			set
			{
				this._uuid = value;
			}
		}
	}
}
