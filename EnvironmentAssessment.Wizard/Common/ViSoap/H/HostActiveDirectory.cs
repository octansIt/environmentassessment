namespace EnvironmentAssessment.Common.VISoap
{
    public class HostActiveDirectory : DynamicData
	{
		protected string _changeOperation;
		protected HostActiveDirectorySpec _spec;
		public string ChangeOperation
		{
			get
			{
				return this._changeOperation;
			}
			set
			{
				this._changeOperation = value;
			}
		}
		public HostActiveDirectorySpec Spec
		{
			get
			{
				return this._spec;
			}
			set
			{
				this._spec = value;
			}
		}
	}
}
