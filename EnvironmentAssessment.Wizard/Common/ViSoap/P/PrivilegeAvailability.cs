namespace EnvironmentAssessment.Common.VISoap
{
    public class PrivilegeAvailability : DynamicData
	{
		protected string _privId;
		protected bool _isGranted;
		public string PrivId
		{
			get
			{
				return this._privId;
			}
			set
			{
				this._privId = value;
			}
		}
		public bool IsGranted
		{
			get
			{
				return this._isGranted;
			}
			set
			{
				this._isGranted = value;
			}
		}
	}
}
