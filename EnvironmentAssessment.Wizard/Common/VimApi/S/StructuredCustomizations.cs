namespace EnvironmentAssessment.Common.VimApi
{
	public class StructuredCustomizations : HostProfilesEntityCustomizations
	{
		protected ManagedObjectReference _entity;
		protected AnswerFile _customizations;
		protected StructuredCustomizations_LinkedView _linkedView;
		public ManagedObjectReference Entity
		{
			get
			{
				return this._entity;
			}
			set
			{
				this._entity = value;
			}
		}
		public AnswerFile Customizations
		{
			get
			{
				return this._customizations;
			}
			set
			{
				this._customizations = value;
			}
		}
		public StructuredCustomizations_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
