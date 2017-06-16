namespace EnvironmentAssessment.Common.VISoap
{
    public class VirtualSerialPort : VirtualDevice
	{
		protected bool _yieldOnPoll;
		public bool YieldOnPoll
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
