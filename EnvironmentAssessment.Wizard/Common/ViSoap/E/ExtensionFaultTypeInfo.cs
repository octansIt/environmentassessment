namespace EnvironmentAssessment.Common.VISoap
{
    public class ExtensionFaultTypeInfo : DynamicData
	{
		protected string _faultID;
		public string FaultID
		{
			get
			{
				return this._faultID;
			}
			set
			{
				this._faultID = value;
			}
		}
	}
}
