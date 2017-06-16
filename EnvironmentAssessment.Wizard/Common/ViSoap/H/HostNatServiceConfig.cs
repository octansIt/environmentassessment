namespace EnvironmentAssessment.Common.VISoap
{
    public class HostNatServiceConfig : DynamicData
	{
		protected string _changeOperation;
		protected string _key;
		protected HostNatServiceSpec _spec;
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
		public string Key
		{
			get
			{
				return this._key;
			}
			set
			{
				this._key = value;
			}
		}
		public HostNatServiceSpec Spec
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
