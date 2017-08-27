namespace EnvironmentAssessment.Common.VimApi
{
	public class RDMConversionNotSupported : MigrationFault
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
