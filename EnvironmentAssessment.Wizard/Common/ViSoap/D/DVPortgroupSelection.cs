namespace EnvironmentAssessment.Common.VISoap
{
    public class DVPortgroupSelection : SelectionSet
	{
		protected string _dvsUuid;
		protected string[] _portgroupKey;
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
		public string[] PortgroupKey
		{
			get
			{
				return this._portgroupKey;
			}
			set
			{
				this._portgroupKey = value;
			}
		}
	}
}
