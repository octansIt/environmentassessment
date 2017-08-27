namespace EnvironmentAssessment.Common.VimApi
{
	public class VspanPromiscuousPortNotSupported : DvsFault
	{
		protected string _vspanSessionKey;
		protected string _portKey;
		public string VspanSessionKey
		{
			get
			{
				return this._vspanSessionKey;
			}
			set
			{
				this._vspanSessionKey = value;
			}
		}
		public string PortKey
		{
			get
			{
				return this._portKey;
			}
			set
			{
				this._portKey = value;
			}
		}
	}
}
