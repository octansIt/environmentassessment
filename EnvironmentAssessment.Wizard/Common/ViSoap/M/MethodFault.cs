namespace EnvironmentAssessment.Common.VISoap
{
    public class MethodFault
	{
		protected string _dynamicType;
		protected DynamicProperty[] _dynamicProperty;
		protected LocalizedMethodFault _faultCause;
		protected LocalizableMessage[] _faultMessage;
		public string DynamicType
		{
			get
			{
				return this._dynamicType;
			}
			set
			{
				this._dynamicType = value;
			}
		}
		public DynamicProperty[] DynamicProperty
		{
			get
			{
				return this._dynamicProperty;
			}
			set
			{
				this._dynamicProperty = value;
			}
		}
		public LocalizedMethodFault FaultCause
		{
			get
			{
				return this._faultCause;
			}
			set
			{
				this._faultCause = value;
			}
		}
		public LocalizableMessage[] FaultMessage
		{
			get
			{
				return this._faultMessage;
			}
			set
			{
				this._faultMessage = value;
			}
		}
	}
}
