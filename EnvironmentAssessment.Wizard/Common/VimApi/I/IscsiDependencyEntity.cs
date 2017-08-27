namespace EnvironmentAssessment.Common.VimApi
{
	public class IscsiDependencyEntity : DynamicData
	{
		protected string _pnicDevice;
		protected string _vnicDevice;
		protected string _vmhbaName;
		public string PnicDevice
		{
			get
			{
				return this._pnicDevice;
			}
			set
			{
				this._pnicDevice = value;
			}
		}
		public string VnicDevice
		{
			get
			{
				return this._vnicDevice;
			}
			set
			{
				this._vnicDevice = value;
			}
		}
		public string VmhbaName
		{
			get
			{
				return this._vmhbaName;
			}
			set
			{
				this._vmhbaName = value;
			}
		}
	}
}
