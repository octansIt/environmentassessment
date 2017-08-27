namespace EnvironmentAssessment.Common.VimApi
{
	public class PropertyFilterUpdate_LinkedView
	{
		protected PropertyFilter _filter;
		public PropertyFilter Filter
		{
			get
			{
				return this._filter;
			}
			set
			{
				this._filter = value;
			}
		}
	}
}
