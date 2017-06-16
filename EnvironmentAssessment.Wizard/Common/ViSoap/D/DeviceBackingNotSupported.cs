namespace EnvironmentAssessment.Common.VISoap
{
    public class DeviceBackingNotSupported : DeviceNotSupported
	{
		protected string _backing;
		public string Backing
		{
			get
			{
				return this._backing;
			}
			set
			{
				this._backing = value;
			}
		}
	}
}
