namespace EnvironmentAssessment.Common.VISoap
{
    public class PerfCompositeMetric : DynamicData
	{
		protected PerfEntityMetricBase _entity;
		protected PerfEntityMetricBase[] _childEntity;
		public PerfEntityMetricBase Entity
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
		public PerfEntityMetricBase[] ChildEntity
		{
			get
			{
				return this._childEntity;
			}
			set
			{
				this._childEntity = value;
			}
		}
	}
}
