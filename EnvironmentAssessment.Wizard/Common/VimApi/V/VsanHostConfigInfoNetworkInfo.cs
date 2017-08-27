namespace EnvironmentAssessment.Common.VimApi
{
	public class VsanHostConfigInfoNetworkInfo : DynamicData
	{
		protected VsanHostConfigInfoNetworkInfoPortConfig[] _port;
		public VsanHostConfigInfoNetworkInfoPortConfig[] Port
		{
			get
			{
				return this._port;
			}
			set
			{
				this._port = value;
			}
		}
	}
}
