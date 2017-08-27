namespace EnvironmentAssessment.Common.VimApi
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
