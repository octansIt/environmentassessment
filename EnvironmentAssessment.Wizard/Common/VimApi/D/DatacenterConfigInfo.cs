namespace EnvironmentAssessment.Common.VimApi
{
	public class DatacenterConfigInfo : DynamicData
	{
		protected string _defaultHardwareVersionKey;
		public string DefaultHardwareVersionKey
		{
			get
			{
				return this._defaultHardwareVersionKey;
			}
			set
			{
				this._defaultHardwareVersionKey = value;
			}
		}
	}
}
