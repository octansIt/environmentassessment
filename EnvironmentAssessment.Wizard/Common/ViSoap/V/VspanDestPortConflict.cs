namespace EnvironmentAssessment.Common.VISoap
{
    public class VspanDestPortConflict : DvsFault
	{
		protected string _vspanSessionKey1;
		protected string _vspanSessionKey2;
		protected string _portKey;
		public string VspanSessionKey1
		{
			get
			{
				return this._vspanSessionKey1;
			}
			set
			{
				this._vspanSessionKey1 = value;
			}
		}
		public string VspanSessionKey2
		{
			get
			{
				return this._vspanSessionKey2;
			}
			set
			{
				this._vspanSessionKey2 = value;
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
