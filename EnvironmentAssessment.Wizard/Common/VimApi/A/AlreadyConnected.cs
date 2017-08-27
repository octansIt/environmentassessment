namespace EnvironmentAssessment.Common.VimApi
{
	public class AlreadyConnected : HostConnectFault
	{
		protected string _name;
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				this._name = value;
			}
		}
	}
}
