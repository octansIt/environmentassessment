namespace EnvironmentAssessment.Common.VISoap
{
    public class Folder_LinkedView : ManagedEntity_LinkedView
	{
		protected ManagedEntity[] _childEntity;
		public ManagedEntity[] ChildEntity
		{
			get
			{
				return this._childEntity;
			}
		}
	}
}
