namespace EnvironmentAssessment.Common.VimApi
{
	public class OvfDuplicatedElementBoundary : OvfElement
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
