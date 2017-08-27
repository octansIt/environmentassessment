namespace EnvironmentAssessment.Common.VimApi
{
	public class ScsiLunDescriptor : DynamicData
	{
		protected string _quality;
		protected string _id;
		public string Quality
		{
			get
			{
				return this._quality;
			}
			set
			{
				this._quality = value;
			}
		}
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
