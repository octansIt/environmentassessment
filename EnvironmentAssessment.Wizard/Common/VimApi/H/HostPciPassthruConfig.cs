namespace EnvironmentAssessment.Common.VimApi
{
	public class HostPciPassthruConfig : DynamicData
	{
		protected string _id;
		protected bool _passthruEnabled;
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
		public bool PassthruEnabled
		{
			get
			{
				return this._passthruEnabled;
			}
			set
			{
				this._passthruEnabled = value;
			}
		}
	}
}
