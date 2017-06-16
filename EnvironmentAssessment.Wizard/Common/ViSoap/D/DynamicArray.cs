namespace EnvironmentAssessment.Common.VISoap
{
    public class DynamicArray
	{
		protected string _dynamicType;
		protected object[] _val;
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
		public object[] Val
		{
			get
			{
				return this._val;
			}
			set
			{
				this._val = value;
			}
		}
	}
}
