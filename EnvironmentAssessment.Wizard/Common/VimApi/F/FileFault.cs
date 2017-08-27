namespace EnvironmentAssessment.Common.VimApi
{
	public class FileFault : VimFault
	{
		protected string _file;
		public string File
		{
			get
			{
				return this._file;
			}
			set
			{
				this._file = value;
			}
		}
	}
}
