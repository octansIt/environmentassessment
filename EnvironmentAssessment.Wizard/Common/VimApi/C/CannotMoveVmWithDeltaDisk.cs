namespace EnvironmentAssessment.Common.VimApi
{
	public class CannotMoveVmWithDeltaDisk : MigrationFault
	{
		protected string _device;
		public string Device
		{
			get
			{
				return this._device;
			}
			set
			{
				this._device = value;
			}
		}
	}
}
