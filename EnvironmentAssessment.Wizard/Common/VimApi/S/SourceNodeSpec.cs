namespace EnvironmentAssessment.Common.VimApi
{
	public class SourceNodeSpec : DynamicData
	{
		protected ServiceLocator _managementVc;
		protected ManagedObjectReference _activeVc;
		protected SourceNodeSpec_LinkedView _linkedView;
		public ServiceLocator ManagementVc
		{
			get
			{
				return this._managementVc;
			}
			set
			{
				this._managementVc = value;
			}
		}
		public ManagedObjectReference ActiveVc
		{
			get
			{
				return this._activeVc;
			}
			set
			{
				this._activeVc = value;
			}
		}
		public SourceNodeSpec_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
