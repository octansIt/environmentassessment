namespace EnvironmentAssessment.Common.VimApi
{
	public class FolderEventArgument_LinkedView
	{
		protected Folder _folder;
		public Folder Folder
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
	}
}
