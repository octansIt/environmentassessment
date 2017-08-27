namespace EnvironmentAssessment.Common.VimApi
{
	public class OvfDiskMappingNotFound : OvfSystemFault
	{
		protected string _diskName;
		protected string _vmName;
		public string DiskName
		{
			get
			{
				return this._diskName;
			}
			set
			{
				this._diskName = value;
			}
		}
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
