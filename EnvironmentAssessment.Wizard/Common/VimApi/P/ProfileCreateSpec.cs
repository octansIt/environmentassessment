namespace EnvironmentAssessment.Common.VimApi
{
	public class ProfileCreateSpec : DynamicData
	{
		protected string _name;
		protected string _annotation;
		protected bool? _enabled;
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
		public string Annotation
		{
			get
			{
				return this._annotation;
			}
			set
			{
				this._annotation = value;
			}
		}
		public bool? Enabled
		{
			get
			{
				return this._enabled;
			}
			set
			{
				this._enabled = value;
			}
		}
	}
}
