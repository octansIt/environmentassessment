namespace EnvironmentAssessment.Common.VimApi
{
	public class ArrayUpdateSpec : DynamicData
	{
		protected ArrayUpdateOperation _operation;
		protected object _removeKey;
		public ArrayUpdateOperation Operation
		{
			get
			{
				return this._operation;
			}
			set
			{
				this._operation = value;
			}
		}
		public object RemoveKey
		{
			get
			{
				return this._removeKey;
			}
			set
			{
				this._removeKey = value;
			}
		}
	}
}
