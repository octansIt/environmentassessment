namespace EnvironmentAssessment.Common.VimApi
{
	public class OvfConnectedDeviceIso : OvfConnectedDevice
	{
		protected string _filename;
		public string Filename
		{
			get
			{
				return this._filename;
			}
			set
			{
				this._filename = value;
			}
		}
	}
}
