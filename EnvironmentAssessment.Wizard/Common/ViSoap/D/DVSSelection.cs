namespace EnvironmentAssessment.Common.VISoap
{
    public class DVSSelection : SelectionSet
	{
		protected string _dvsUuid;
		public string DvsUuid
		{
			get
			{
				return this._dvsUuid;
			}
			set
			{
				this._dvsUuid = value;
			}
		}
	}
}
