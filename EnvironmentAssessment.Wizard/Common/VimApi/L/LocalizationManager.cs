namespace EnvironmentAssessment.Common.VimApi
{
	public class LocalizationManager : ViewBase
	{
		protected LocalizationManagerMessageCatalog[] _catalog;
		public LocalizationManagerMessageCatalog[] Catalog
		{
			get
			{
				return this._catalog;
			}
		}
		public LocalizationManager(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
	}
}
