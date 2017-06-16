namespace EnvironmentAssessment.Common.VISoap
{
    public class HostImageProfileSummary : DynamicData
	{
		protected string _name;
		protected string _vendor;
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				this._name = value;
			}
		}
		public string Vendor
		{
			get
			{
				return this._vendor;
			}
			set
			{
				this._vendor = value;
			}
		}
	}
}
