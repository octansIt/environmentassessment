namespace EnvironmentAssessment.Common.VimApi
{
	public class MismatchedNetworkPolicies : MigrationFault
	{
		protected string _device;
		protected string _backing;
		protected bool _connected;
		public string Device
		{
			get
			{
				return this._device;
			}
			set
			{
				this._device = value;
			}
		}
		public string Backing
		{
			get
			{
				return this._backing;
			}
			set
			{
				this._backing = value;
			}
		}
		public bool Connected
		{
			get
			{
				return this._connected;
			}
			set
			{
				this._connected = value;
			}
		}
	}
}
