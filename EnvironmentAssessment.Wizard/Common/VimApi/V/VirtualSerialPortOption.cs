namespace EnvironmentAssessment.Common.VimApi
{
	public class VirtualSerialPortOption : VirtualDeviceOption
	{
		protected BoolOption _yieldOnPoll;
		public BoolOption YieldOnPoll
		{
			get
			{
				return this._yieldOnPoll;
			}
			set
			{
				this._yieldOnPoll = value;
			}
		}
	}
}
