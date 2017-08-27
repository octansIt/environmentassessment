namespace EnvironmentAssessment.Common.VimApi
{
    public class DVPortOverlayParameter : DynamicData
	{
		protected string _overlayInstanceKey;
		protected long _value;
		public string OverlayInstanceKey
		{
			get
			{
				return this._overlayInstanceKey;
			}
			set
			{
				this._overlayInstanceKey = value;
			}
		}
		public long Value
		{
			get
			{
				return this._value;
			}
			set
			{
				this._value = value;
			}
		}
	}
}
