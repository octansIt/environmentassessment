namespace EnvironmentAssessment.Common.VimApi
{
	public class GuestWindowsProgramSpec : GuestProgramSpec
	{
		protected bool _startMinimized;
		public bool StartMinimized
		{
			get
			{
				return this._startMinimized;
			}
			set
			{
				this._startMinimized = value;
			}
		}
	}
}
