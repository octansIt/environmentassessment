namespace EnvironmentAssessment.Common.VISoap
{
    public class CustomizationUserData : DynamicData
	{
		protected string _fullName;
		protected string _orgName;
		protected CustomizationName _computerName;
		protected string _productId;
		public string FullName
		{
			get
			{
				return this._fullName;
			}
			set
			{
				this._fullName = value;
			}
		}
		public string OrgName
		{
			get
			{
				return this._orgName;
			}
			set
			{
				this._orgName = value;
			}
		}
		public CustomizationName ComputerName
		{
			get
			{
				return this._computerName;
			}
			set
			{
				this._computerName = value;
			}
		}
		public string ProductId
		{
			get
			{
				return this._productId;
			}
			set
			{
				this._productId = value;
			}
		}
	}
}
