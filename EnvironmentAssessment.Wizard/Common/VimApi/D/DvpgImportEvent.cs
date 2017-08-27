namespace EnvironmentAssessment.Common.VimApi
{
	public class DvpgImportEvent : DVPortgroupEvent
	{
		protected string _importType;
		public string ImportType
		{
			get
			{
				return this._importType;
			}
			set
			{
				this._importType = value;
			}
		}
	}
}
