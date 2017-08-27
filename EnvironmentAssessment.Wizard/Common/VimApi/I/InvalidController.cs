namespace EnvironmentAssessment.Common.VimApi
{
	public class InvalidController : InvalidDeviceSpec
	{
		protected int _controllerKey;
		public int ControllerKey
		{
			get
			{
				return this._controllerKey;
			}
			set
			{
				this._controllerKey = value;
			}
		}
	}
}
