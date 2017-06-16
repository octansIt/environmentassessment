namespace EnvironmentAssessment.Common.VISoap
{
    public class NegatableExpression : DynamicData
	{
		protected bool? _negate;
		public bool? Negate
		{
			get
			{
				return this._negate;
			}
			set
			{
				this._negate = value;
			}
		}
	}
}
