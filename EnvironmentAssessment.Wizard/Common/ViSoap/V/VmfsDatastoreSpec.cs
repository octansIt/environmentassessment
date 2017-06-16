namespace EnvironmentAssessment.Common.VISoap
{
    public class VmfsDatastoreSpec : DynamicData
	{
		protected string _diskUuid;
		public string DiskUuid
		{
			get
			{
				return this._diskUuid;
			}
			set
			{
				this._diskUuid = value;
			}
		}
	}
}
