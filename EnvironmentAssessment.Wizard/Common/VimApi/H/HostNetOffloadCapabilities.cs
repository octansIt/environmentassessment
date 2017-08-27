namespace EnvironmentAssessment.Common.VimApi
{
	public class HostNetOffloadCapabilities : DynamicData
	{
		protected bool? _csumOffload;
		protected bool? _tcpSegmentation;
		protected bool? _zeroCopyXmit;
		public bool? CsumOffload
		{
			get
			{
				return this._csumOffload;
			}
			set
			{
				this._csumOffload = value;
			}
		}
		public bool? TcpSegmentation
		{
			get
			{
				return this._tcpSegmentation;
			}
			set
			{
				this._tcpSegmentation = value;
			}
		}
		public bool? ZeroCopyXmit
		{
			get
			{
				return this._zeroCopyXmit;
			}
			set
			{
				this._zeroCopyXmit = value;
			}
		}
	}
}
