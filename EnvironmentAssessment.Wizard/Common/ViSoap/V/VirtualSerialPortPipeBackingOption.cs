namespace EnvironmentAssessment.Common.VISoap
{
    public class VirtualSerialPortPipeBackingOption : VirtualDevicePipeBackingOption
	{
		protected ChoiceOption _endpoint;
		protected BoolOption _noRxLoss;
		public ChoiceOption Endpoint
		{
			get
			{
				return this._endpoint;
			}
			set
			{
				this._endpoint = value;
			}
		}
		public BoolOption NoRxLoss
		{
			get
			{
				return this._noRxLoss;
			}
			set
			{
				this._noRxLoss = value;
			}
		}
	}
}
