namespace EnvironmentAssessment.Common.VimApi
{
	public class UsbScanCodeSpecModifierType : DynamicData
	{
		protected bool? _leftControl;
		protected bool? _leftShift;
		protected bool? _leftAlt;
		protected bool? _leftGui;
		protected bool? _rightControl;
		protected bool? _rightShift;
		protected bool? _rightAlt;
		protected bool? _rightGui;
		public bool? LeftControl
		{
			get
			{
				return this._leftControl;
			}
			set
			{
				this._leftControl = value;
			}
		}
		public bool? LeftShift
		{
			get
			{
				return this._leftShift;
			}
			set
			{
				this._leftShift = value;
			}
		}
		public bool? LeftAlt
		{
			get
			{
				return this._leftAlt;
			}
			set
			{
				this._leftAlt = value;
			}
		}
		public bool? LeftGui
		{
			get
			{
				return this._leftGui;
			}
			set
			{
				this._leftGui = value;
			}
		}
		public bool? RightControl
		{
			get
			{
				return this._rightControl;
			}
			set
			{
				this._rightControl = value;
			}
		}
		public bool? RightShift
		{
			get
			{
				return this._rightShift;
			}
			set
			{
				this._rightShift = value;
			}
		}
		public bool? RightAlt
		{
			get
			{
				return this._rightAlt;
			}
			set
			{
				this._rightAlt = value;
			}
		}
		public bool? RightGui
		{
			get
			{
				return this._rightGui;
			}
			set
			{
				this._rightGui = value;
			}
		}
	}
}
