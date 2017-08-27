namespace EnvironmentAssessment.Common.VimApi
{
	public class VsanHostDecommissionMode : DynamicData
	{
		protected string _objectAction;
		public string ObjectAction
		{
			get
			{
				return this._objectAction;
			}
			set
			{
				this._objectAction = value;
			}
		}
	}
}
