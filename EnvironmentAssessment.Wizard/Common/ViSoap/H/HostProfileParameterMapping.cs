namespace EnvironmentAssessment.Common.VISoap
{
    public class HostProfileParameterMapping : DynamicData
	{
		protected string _id;
		protected HostProfileParameterMappingParameterMappingData _data;
		public string Id
		{
			get
			{
				return this._id;
			}
			set
			{
				this._id = value;
			}
		}
		public HostProfileParameterMappingParameterMappingData Data
		{
			get
			{
				return this._data;
			}
			set
			{
				this._data = value;
			}
		}
	}
}
