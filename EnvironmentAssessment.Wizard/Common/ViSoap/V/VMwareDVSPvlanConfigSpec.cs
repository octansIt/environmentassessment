namespace EnvironmentAssessment.Common.VISoap
{
    public class VMwareDVSPvlanConfigSpec : DynamicData
	{
		protected VMwareDVSPvlanMapEntry _pvlanEntry;
		protected string _operation;
		public VMwareDVSPvlanMapEntry PvlanEntry
		{
			get
			{
				return this._pvlanEntry;
			}
			set
			{
				this._pvlanEntry = value;
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
