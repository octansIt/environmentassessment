namespace EnvironmentAssessment.Common.VimApi
{
	public class SwapDatastoreNotWritableOnHost : DatastoreNotWritableOnHost
	{
		public new SwapDatastoreNotWritableOnHost_LinkedView LinkedView
		{
			get
			{
				return (SwapDatastoreNotWritableOnHost_LinkedView)this._linkedView;
			}
		}
	}
}
