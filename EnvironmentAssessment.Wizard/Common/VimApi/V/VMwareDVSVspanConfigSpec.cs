namespace EnvironmentAssessment.Common.VimApi
{
	public class VMwareDVSVspanConfigSpec : DynamicData
	{
		protected VMwareVspanSession _vspanSession;
		protected string _operation;
		public VMwareVspanSession VspanSession
		{
			get
			{
				return this._vspanSession;
			}
			set
			{
				this._vspanSession = value;
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
