namespace EnvironmentAssessment.Common.VimApi
{
	public class NetworksMayNotBeTheSame : MigrationFault
	{
		protected string _name;
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
	}
}
