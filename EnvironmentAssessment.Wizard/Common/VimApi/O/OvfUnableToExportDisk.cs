namespace EnvironmentAssessment.Common.VimApi
{
	public class OvfUnableToExportDisk : OvfHardwareExport
	{
		protected string _diskName;
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
	}
}
