namespace EnvironmentAssessment.Common.VimApi
{
	public class UsbScanCodeSpecKeyEvent : DynamicData
	{
		protected int _usbHidCode;
		protected UsbScanCodeSpecModifierType _modifiers;
		public int UsbHidCode
		{
			get
			{
				return this._usbHidCode;
			}
			set
			{
				this._usbHidCode = value;
			}
		}
		public UsbScanCodeSpecModifierType Modifiers
		{
			get
			{
				return this._modifiers;
			}
			set
			{
				this._modifiers = value;
			}
		}
	}
}
