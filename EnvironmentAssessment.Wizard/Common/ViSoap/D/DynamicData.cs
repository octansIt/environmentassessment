namespace EnvironmentAssessment.Common.VISoap
{
    public class DynamicData
	{
		protected string _dynamicType;
		protected DynamicProperty[] _dynamicProperty;
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
	}
}
