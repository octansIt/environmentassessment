namespace EnvironmentAssessment.Common.VISoap
{
    public class HostPortGroupConfig : DynamicData
	{
		protected string _changeOperation;
		protected HostPortGroupSpec _spec;
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
		public HostPortGroupSpec Spec
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
