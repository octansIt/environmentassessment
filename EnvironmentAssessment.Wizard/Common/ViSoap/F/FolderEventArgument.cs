namespace EnvironmentAssessment.Common.VISoap
{
    public class FolderEventArgument : EntityEventArgument
	{
		protected ManagedObjectReference _folder;
		protected FolderEventArgument_LinkedView _linkedView;
		public ManagedObjectReference Folder
		{
			get
			{
				return this._folder;
			}
			set
			{
				this._folder = value;
			}
		}
		public FolderEventArgument_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
