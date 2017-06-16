namespace EnvironmentAssessment.Common.VISoap
{
    public class HostHardwareElementInfo : DynamicData
	{
		protected string _name;
		protected ElementDescription _status;
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
		public ElementDescription Status
		{
			get
			{
				return this._status;
			}
			set
			{
				this._status = value;
			}
		}
	}
}
