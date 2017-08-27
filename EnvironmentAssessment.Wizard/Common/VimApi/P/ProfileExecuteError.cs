namespace EnvironmentAssessment.Common.VimApi
{
	public class ProfileExecuteError : DynamicData
	{
		protected ProfilePropertyPath _path;
		protected LocalizableMessage _message;
		public ProfilePropertyPath Path
		{
			get
			{
				return this._path;
			}
			set
			{
				this._path = value;
			}
		}
		public LocalizableMessage Message
		{
			get
			{
				return this._message;
			}
			set
			{
				this._message = value;
			}
		}
	}
}
