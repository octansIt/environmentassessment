namespace EnvironmentAssessment.Common.VISoap
{
    public class PolicyOption : DynamicData
	{
		protected string _id;
		protected KeyAnyValue[] _parameter;
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
		public KeyAnyValue[] Parameter
		{
			get
			{
				return this._parameter;
			}
			set
			{
				this._parameter = value;
			}
		}
	}
}
