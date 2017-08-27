namespace EnvironmentAssessment.Common.VimApi
{
	public class GuestRegValueBinarySpec : GuestRegValueDataSpec
	{
		protected byte[] _value;
		public byte[] Value
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
