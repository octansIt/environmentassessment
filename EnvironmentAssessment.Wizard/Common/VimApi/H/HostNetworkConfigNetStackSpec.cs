namespace EnvironmentAssessment.Common.VimApi
{
	public class HostNetworkConfigNetStackSpec : DynamicData
	{
		protected HostNetStackInstance _netStackInstance;
		protected string _operation;
		public HostNetStackInstance NetStackInstance
		{
			get
			{
				return this._netStackInstance;
			}
			set
			{
				this._netStackInstance = value;
			}
		}
		public string Operation
		{
			get
			{
				return this._operation;
			}
			set
			{
				this._operation = value;
			}
		}
	}
}
