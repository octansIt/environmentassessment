namespace EnvironmentAssessment.Common.VISoap
{
    public class HostNatService : DynamicData
	{
		protected string _key;
		protected HostNatServiceSpec _spec;
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
