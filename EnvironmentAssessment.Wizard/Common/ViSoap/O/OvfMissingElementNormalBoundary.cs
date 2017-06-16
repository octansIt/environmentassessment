namespace EnvironmentAssessment.Common.VISoap
{
    public class OvfMissingElementNormalBoundary : OvfMissingElement
	{
		protected string _boundary;
		public string Boundary
		{
			get
			{
				return this._boundary;
			}
			set
			{
				this._boundary = value;
			}
		}
	}
}
