namespace EnvironmentAssessment.Common.VISoap
{
    public class ProfileDescriptionSection : DynamicData
	{
		protected ExtendedElementDescription _description;
		protected LocalizableMessage[] _message;
		public ExtendedElementDescription Description
		{
			get
			{
				return this._description;
			}
			set
			{
				this._description = value;
			}
		}
		public LocalizableMessage[] Message
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
