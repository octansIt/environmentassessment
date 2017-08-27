namespace EnvironmentAssessment.Common.VimApi
{
	public class VsanPolicyChangeBatch : DynamicData
	{
		protected string[] _uuid;
		protected string _policy;
		public string[] Uuid
		{
			get
			{
				return this._uuid;
			}
			set
			{
				this._uuid = value;
			}
		}
		public string Policy
		{
			get
			{
				return this._policy;
			}
			set
			{
				this._policy = value;
			}
		}
	}
}
