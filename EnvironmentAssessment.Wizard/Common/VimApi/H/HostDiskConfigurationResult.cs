namespace EnvironmentAssessment.Common.VimApi
{
	public class HostDiskConfigurationResult : DynamicData
	{
		protected string _devicePath;
		protected bool? _success;
		protected LocalizedMethodFault _fault;
		public string DevicePath
		{
			get
			{
				return this._devicePath;
			}
			set
			{
				this._devicePath = value;
			}
		}
		public bool? Success
		{
			get
			{
				return this._success;
			}
			set
			{
				this._success = value;
			}
		}
		public LocalizedMethodFault Fault
		{
			get
			{
				return this._fault;
			}
			set
			{
				this._fault = value;
			}
		}
	}
}
