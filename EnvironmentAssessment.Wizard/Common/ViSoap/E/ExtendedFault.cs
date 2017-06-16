namespace EnvironmentAssessment.Common.VISoap
{
    public class ExtendedFault : VimFault
	{
		protected string _faultTypeId;
		protected KeyValue[] _data;
		public string FaultTypeId
		{
			get
			{
				return this._faultTypeId;
			}
			set
			{
				this._faultTypeId = value;
			}
		}
		public KeyValue[] Data
		{
			get
			{
				return this._data;
			}
			set
			{
				this._data = value;
			}
		}
	}
}
