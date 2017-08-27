namespace EnvironmentAssessment.Common.VimApi
{
	public class HostStorageSystemVmfsVolumeResult : DynamicData
	{
		protected string _key;
		protected LocalizedMethodFault _fault;
		public string Key
		{
			get
			{
				return this._key;
			}
			set
			{
				this._key = value;
			}
		}
		public LocalizedMethodFault Fault
		{
			get
			{
				return this._fault;
			}
			set
			{
				this._fault = value;
			}
		}
	}
}
