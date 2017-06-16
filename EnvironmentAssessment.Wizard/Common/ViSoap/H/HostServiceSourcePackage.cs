namespace EnvironmentAssessment.Common.VISoap
{
    public class HostServiceSourcePackage : DynamicData
	{
		protected string _sourcePackageName;
		protected string _description;
		public string SourcePackageName
		{
			get
			{
				return this._sourcePackageName;
			}
			set
			{
				this._sourcePackageName = value;
			}
		}
		public string Description
		{
			get
			{
				return this._description;
			}
			set
			{
				this._description = value;
			}
		}
	}
}
