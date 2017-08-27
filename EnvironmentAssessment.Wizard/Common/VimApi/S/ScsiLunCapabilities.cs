namespace EnvironmentAssessment.Common.VimApi
{
	public class ScsiLunCapabilities : DynamicData
	{
		protected bool _updateDisplayNameSupported;
		public bool UpdateDisplayNameSupported
		{
			get
			{
				return this._updateDisplayNameSupported;
			}
			set
			{
				this._updateDisplayNameSupported = value;
			}
		}
	}
}
