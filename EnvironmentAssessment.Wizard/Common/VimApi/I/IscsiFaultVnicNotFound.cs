namespace EnvironmentAssessment.Common.VimApi
{
	public class IscsiFaultVnicNotFound : IscsiFault
	{
		protected string _vnicDevice;
		public string VnicDevice
		{
			get
			{
				return this._vnicDevice;
			}
			set
			{
				this._vnicDevice = value;
			}
		}
	}
}
