namespace EnvironmentAssessment.Common.VimApi
{
	public class DynamicArray
	{
		protected object[] _val;
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
