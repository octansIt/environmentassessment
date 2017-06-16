namespace EnvironmentAssessment.Common.VISoap
{
    public class ClusterAction : DynamicData
	{
		protected string _type;
		protected ManagedObjectReference _target;
		public string Type
		{
			get
			{
				return this._type;
			}
			set
			{
				this._type = value;
			}
		}
		public ManagedObjectReference Target
		{
			get
			{
				return this._target;
			}
			set
			{
				this._target = value;
			}
		}
	}
}
