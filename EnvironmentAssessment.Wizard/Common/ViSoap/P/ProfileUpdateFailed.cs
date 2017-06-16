namespace EnvironmentAssessment.Common.VISoap
{
    public class ProfileUpdateFailed : VimFault
	{
		protected ProfileUpdateFailedUpdateFailure[] _failure;
		public ProfileUpdateFailedUpdateFailure[] Failure
		{
			get
			{
				return this._failure;
			}
			set
			{
				this._failure = value;
			}
		}
	}
}
