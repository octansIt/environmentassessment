namespace EnvironmentAssessment.Common.VimApi
{
	public class OvfPropertyNetworkExport : OvfExport
	{
		protected string _network;
		public string Network
		{
			get
			{
				return this._network;
			}
			set
			{
				this._network = value;
			}
		}
	}
}
