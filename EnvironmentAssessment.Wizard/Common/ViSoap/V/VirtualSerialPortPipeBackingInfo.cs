namespace EnvironmentAssessment.Common.VISoap
{
    public class VirtualSerialPortPipeBackingInfo : VirtualDevicePipeBackingInfo
	{
		protected string _endpoint;
		protected bool? _noRxLoss;
		public string Endpoint
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
		public bool? NoRxLoss
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
