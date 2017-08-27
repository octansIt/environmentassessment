namespace EnvironmentAssessment.Common.VimApi
{
	public class PropertyChange : DynamicData
	{
		protected string _name;
		protected PropertyChangeOp _op;
		protected object _val;
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
		public PropertyChangeOp Op
		{
			get
			{
				return this._op;
			}
			set
			{
				this._op = value;
			}
		}
		public object Val
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
