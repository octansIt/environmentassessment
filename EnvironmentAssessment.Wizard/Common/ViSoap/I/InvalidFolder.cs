namespace EnvironmentAssessment.Common.VISoap
{
    public class InvalidFolder : VimFault
	{
		protected ManagedObjectReference _target;
		protected InvalidFolder_LinkedView _linkedView;
		public ManagedObjectReference Target
		{
			get
			{
				return this._target;
			}
			set
			{
				this._target = value;
			}
		}
		public InvalidFolder_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
