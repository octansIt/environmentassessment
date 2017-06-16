namespace EnvironmentAssessment.Common.VISoap
{
    public class IscsiFaultPnicInUse : IscsiFault
	{
		protected string _pnicDevice;
		public string PnicDevice
		{
			get
			{
				return this._pnicDevice;
			}
			set
			{
				this._pnicDevice = value;
			}
		}
	}
}
