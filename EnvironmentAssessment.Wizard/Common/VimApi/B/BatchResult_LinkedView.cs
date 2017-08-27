namespace EnvironmentAssessment.Common.VimApi
{
	public class BatchResult_LinkedView
	{
		protected Datastore _ds;
		public Datastore Ds
		{
			get
			{
				return this._ds;
			}
			set
			{
				this._ds = value;
			}
		}
	}
}
