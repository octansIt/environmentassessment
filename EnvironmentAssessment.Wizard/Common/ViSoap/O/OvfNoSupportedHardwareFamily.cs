namespace EnvironmentAssessment.Common.VISoap
{
    public class OvfNoSupportedHardwareFamily : OvfUnsupportedPackage
	{
		protected string _version;
		public string Version
		{
			get
			{
				return this._version;
			}
			set
			{
				this._version = value;
			}
		}
	}
}
