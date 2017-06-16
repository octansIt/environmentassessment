namespace EnvironmentAssessment.Common.VISoap
{
    public class ToolsConfigInfoToolsLastInstallInfo : DynamicData
	{
		protected int _counter;
		protected LocalizedMethodFault _fault;
		public int Counter
		{
			get
			{
				return this._counter;
			}
			set
			{
				this._counter = value;
			}
		}
		public LocalizedMethodFault Fault
		{
			get
			{
				return this._fault;
			}
			set
			{
				this._fault = value;
			}
		}
	}
}
