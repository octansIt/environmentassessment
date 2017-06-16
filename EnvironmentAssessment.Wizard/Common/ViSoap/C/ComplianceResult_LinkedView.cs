namespace EnvironmentAssessment.Common.VISoap
{
    public class ComplianceResult_LinkedView
	{
		protected Profile _profile;
		protected ManagedEntity _entity;
		public Profile Profile
		{
			get
			{
				return this._profile;
			}
			set
			{
				this._profile = value;
			}
		}
		public ManagedEntity Entity
		{
			get
			{
				return this._entity;
			}
			set
			{
				this._entity = value;
			}
		}
	}
}
