namespace EnvironmentAssessment.Common.VimApi
{
	public class VirtualDiskModeNotSupported : DeviceNotSupported
	{
		protected string _mode;
		public string Mode
		{
			get
			{
				return this._mode;
			}
			set
			{
				this._mode = value;
			}
		}
	}
}
