namespace EnvironmentAssessment.Common.VISoap
{
    public class OvfUnsupportedType : OvfUnsupportedPackage
	{
		protected string _name;
		protected string _instanceId;
		protected int _deviceType;
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				this._name = value;
			}
		}
		public string InstanceId
		{
			get
			{
				return this._instanceId;
			}
			set
			{
				this._instanceId = value;
			}
		}
		public int DeviceType
		{
			get
			{
				return this._deviceType;
			}
			set
			{
				this._deviceType = value;
			}
		}
	}
}
