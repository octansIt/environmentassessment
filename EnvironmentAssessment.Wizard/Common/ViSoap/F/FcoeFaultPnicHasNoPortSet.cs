namespace EnvironmentAssessment.Common.VISoap
{
    public class FcoeFaultPnicHasNoPortSet : FcoeFault
	{
		protected string _nicDevice;
		public string NicDevice
		{
			get
			{
				return this._nicDevice;
			}
			set
			{
				this._nicDevice = value;
			}
		}
	}
}
