namespace EnvironmentAssessment.Common.VimApi
{
	public class VslmCloneSpec : VslmMigrateSpec
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
