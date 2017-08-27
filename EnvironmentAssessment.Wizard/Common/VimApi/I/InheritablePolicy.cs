namespace EnvironmentAssessment.Common.VimApi
{
	public class InheritablePolicy : DynamicData
	{
		protected bool _inherited;
		public bool Inherited
		{
			get
			{
				return this._inherited;
			}
			set
			{
				this._inherited = value;
			}
		}
	}
}
