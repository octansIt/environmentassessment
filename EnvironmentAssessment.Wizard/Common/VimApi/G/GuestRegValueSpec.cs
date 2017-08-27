namespace EnvironmentAssessment.Common.VimApi
{
	public class GuestRegValueSpec : DynamicData
	{
		protected GuestRegValueNameSpec _name;
		protected GuestRegValueDataSpec _data;
		public GuestRegValueNameSpec Name
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
		public GuestRegValueDataSpec Data
		{
			get
			{
				return this._data;
			}
			set
			{
				this._data = value;
			}
		}
	}
}
