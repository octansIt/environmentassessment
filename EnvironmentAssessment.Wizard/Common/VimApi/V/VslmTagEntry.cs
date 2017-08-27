namespace EnvironmentAssessment.Common.VimApi
{
	public class VslmTagEntry : DynamicData
	{
		protected string _tagName;
		protected string _parentCategoryName;
		public string TagName
		{
			get
			{
				return this._tagName;
			}
			set
			{
				this._tagName = value;
			}
		}
		public string ParentCategoryName
		{
			get
			{
				return this._parentCategoryName;
			}
			set
			{
				this._parentCategoryName = value;
			}
		}
	}
}
