namespace EnvironmentAssessment.Common.VimApi
{
	public class UsbScanCodeSpec : DynamicData
	{
		protected UsbScanCodeSpecKeyEvent[] _keyEvents;
		public UsbScanCodeSpecKeyEvent[] KeyEvents
		{
			get
			{
				return this._keyEvents;
			}
			set
			{
				this._keyEvents = value;
			}
		}
	}
}
