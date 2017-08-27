namespace EnvironmentAssessment.Common.VimApi
{
	public class OvfNoSpaceOnController : OvfUnsupportedElement
	{
		protected string _parent;
		public string Parent
		{
			get
			{
				return this._parent;
			}
			set
			{
				this._parent = value;
			}
		}
	}
}
