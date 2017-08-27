namespace EnvironmentAssessment.Common.VimApi
{
	public class HostNetworkConfigResult : DynamicData
	{
		protected string[] _vnicDevice;
		protected string[] _consoleVnicDevice;
		public string[] VnicDevice
		{
			get
			{
				return this._vnicDevice;
			}
			set
			{
				this._vnicDevice = value;
			}
		}
		public string[] ConsoleVnicDevice
		{
			get
			{
				return this._consoleVnicDevice;
			}
			set
			{
				this._consoleVnicDevice = value;
			}
		}
	}
}
