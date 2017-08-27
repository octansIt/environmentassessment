namespace EnvironmentAssessment.Common.VimApi
{
	public class GuestListFileInfo : DynamicData
	{
		protected GuestFileInfo[] _files;
		protected int _remaining;
		public GuestFileInfo[] Files
		{
			get
			{
				return this._files;
			}
			set
			{
				this._files = value;
			}
		}
		public int Remaining
		{
			get
			{
				return this._remaining;
			}
			set
			{
				this._remaining = value;
			}
		}
	}
}
