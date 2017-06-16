namespace EnvironmentAssessment.Common.VISoap
{
    public class ExtensionPrivilegeInfo : DynamicData
	{
		protected string _privID;
		protected string _privGroupName;
		public string PrivID
		{
			get
			{
				return this._privID;
			}
			set
			{
				this._privID = value;
			}
		}
		public string PrivGroupName
		{
			get
			{
				return this._privGroupName;
			}
			set
			{
				this._privGroupName = value;
			}
		}
	}
}
