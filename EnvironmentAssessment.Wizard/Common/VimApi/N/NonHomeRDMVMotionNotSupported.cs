namespace EnvironmentAssessment.Common.VimApi
{
	public class NonHomeRDMVMotionNotSupported : MigrationFeatureNotSupported
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
		public new NonHomeRDMVMotionNotSupported_LinkedView LinkedView
		{
			get
			{
				return (NonHomeRDMVMotionNotSupported_LinkedView)this._linkedView;
			}
		}
	}
}
