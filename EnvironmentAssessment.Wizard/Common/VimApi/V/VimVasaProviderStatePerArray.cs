namespace EnvironmentAssessment.Common.VimApi
{
	public class VimVasaProviderStatePerArray : DynamicData
	{
		protected int _priority;
		protected string _arrayId;
		protected bool _active;
		public int Priority
		{
			get
			{
				return this._priority;
			}
			set
			{
				this._priority = value;
			}
		}
		public string ArrayId
		{
			get
			{
				return this._arrayId;
			}
			set
			{
				this._arrayId = value;
			}
		}
		public bool Active
		{
			get
			{
				return this._active;
			}
			set
			{
				this._active = value;
			}
		}
	}
}
