namespace EnvironmentAssessment.Common.VimApi
{
	public class VirtualDeviceFileBackingOption : VirtualDeviceBackingOption
	{
		protected ChoiceOption _fileNameExtensions;
		public ChoiceOption FileNameExtensions
		{
			get
			{
				return this._fileNameExtensions;
			}
			set
			{
				this._fileNameExtensions = value;
			}
		}
	}
}
