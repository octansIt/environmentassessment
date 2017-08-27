namespace EnvironmentAssessment.Common.VimApi
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
