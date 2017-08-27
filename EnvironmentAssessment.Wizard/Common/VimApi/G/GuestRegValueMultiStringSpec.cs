namespace EnvironmentAssessment.Common.VimApi
{
	public class GuestRegValueMultiStringSpec : GuestRegValueDataSpec
	{
		protected string[] _value;
		public string[] Value
		{
			get
			{
				return this._value;
			}
			set
			{
				this._value = value;
			}
		}
	}
}
