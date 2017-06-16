namespace EnvironmentAssessment.Common.VISoap
{
    public class InvalidNasCredentials : NasConfigFault
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