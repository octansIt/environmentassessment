namespace EnvironmentAssessment.Common.VimApi
{
	public class VmEvent : Event
	{
		protected bool _template;
		public bool Template
		{
			get
			{
				return this._template;
			}
			set
			{
				this._template = value;
			}
		}
	}
}
