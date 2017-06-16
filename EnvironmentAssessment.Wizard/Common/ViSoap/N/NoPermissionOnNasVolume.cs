namespace EnvironmentAssessment.Common.VISoap
{
    public class NoPermissionOnNasVolume : NasConfigFault
	{
		protected string _userName;
		public string UserName
		{
			get
			{
				return this._userName;
			}
			set
			{
				this._userName = value;
			}
		}
	}
}
