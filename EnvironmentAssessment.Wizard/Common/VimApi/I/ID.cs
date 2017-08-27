namespace EnvironmentAssessment.Common.VimApi
{
	public class ID : DynamicData
	{
		protected string _id;
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
	}
}
