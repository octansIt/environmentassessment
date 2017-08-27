namespace EnvironmentAssessment.Common.VimApi
{
	public class GuestRegistryFault : GuestOperationsFault
	{
		protected long _windowsSystemErrorCode;
		public long WindowsSystemErrorCode
		{
			get
			{
				return this._windowsSystemErrorCode;
			}
			set
			{
				this._windowsSystemErrorCode = value;
			}
		}
	}
}
