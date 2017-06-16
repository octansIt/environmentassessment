namespace EnvironmentAssessment.Common.VISoap
{
    public class VsanClusterConfigInfoHostDefaultInfo : DynamicData
	{
		protected string _uuid;
		protected bool? _autoClaimStorage;
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
		public bool? AutoClaimStorage
		{
			get
			{
				return this._autoClaimStorage;
			}
			set
			{
				this._autoClaimStorage = value;
			}
		}
	}
}
