namespace EnvironmentAssessment.Common.VimApi
{
	public class VsanNewPolicyBatch : DynamicData
	{
		protected long[] _size;
		protected string _policy;
		public long[] Size
		{
			get
			{
				return this._size;
			}
			set
			{
				this._size = value;
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
