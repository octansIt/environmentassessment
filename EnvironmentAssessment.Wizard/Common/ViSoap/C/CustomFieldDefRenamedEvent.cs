namespace EnvironmentAssessment.Common.VISoap
{
    public class CustomFieldDefRenamedEvent : CustomFieldDefEvent
	{
		protected string _newName;
		public string NewName
		{
			get
			{
				return this._newName;
			}
			set
			{
				this._newName = value;
			}
		}
	}
}
