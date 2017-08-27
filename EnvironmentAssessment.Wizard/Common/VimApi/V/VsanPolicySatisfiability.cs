namespace EnvironmentAssessment.Common.VimApi
{
	public class VsanPolicySatisfiability : DynamicData
	{
		protected string _uuid;
		protected bool _isSatisfiable;
		protected LocalizableMessage _reason;
		protected VsanPolicyCost _cost;
		public string Uuid
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
		public bool IsSatisfiable
		{
			get
			{
				return this._isSatisfiable;
			}
			set
			{
				this._isSatisfiable = value;
			}
		}
		public LocalizableMessage Reason
		{
			get
			{
				return this._reason;
			}
			set
			{
				this._reason = value;
			}
		}
		public VsanPolicyCost Cost
		{
			get
			{
				return this._cost;
			}
			set
			{
				this._cost = value;
			}
		}
	}
}
