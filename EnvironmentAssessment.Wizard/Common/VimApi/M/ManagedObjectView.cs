namespace EnvironmentAssessment.Common.VimApi
{
	public class ManagedObjectView : View
	{
		protected ManagedObjectReference[] _view;
		public ManagedObjectReference[] View
		{
			get
			{
				return this._view;
			}
		}
		public ManagedObjectView(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
	}
}
