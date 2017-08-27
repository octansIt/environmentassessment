namespace EnvironmentAssessment.Common.VimApi
{
	public class HostSystemHealthInfo : DynamicData
	{
		protected HostNumericSensorInfo[] _numericSensorInfo;
		public HostNumericSensorInfo[] NumericSensorInfo
		{
			get
			{
				return this._numericSensorInfo;
			}
			set
			{
				this._numericSensorInfo = value;
			}
		}
	}
}
