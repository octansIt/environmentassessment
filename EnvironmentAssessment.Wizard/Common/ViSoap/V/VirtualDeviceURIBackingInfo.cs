namespace EnvironmentAssessment.Common.VISoap
{
    public class VirtualDeviceURIBackingInfo : VirtualDeviceBackingInfo
	{
		protected string _serviceURI;
		protected string _direction;
		protected string _proxyURI;
		public string ServiceURI
		{
			get
			{
				return this._serviceURI;
			}
			set
			{
				this._serviceURI = value;
			}
		}
		public string Direction
		{
			get
			{
				return this._direction;
			}
			set
			{
				this._direction = value;
			}
		}
		public string ProxyURI
		{
			get
			{
				return this._proxyURI;
			}
			set
			{
				this._proxyURI = value;
			}
		}
	}
}
