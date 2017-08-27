namespace EnvironmentAssessment.Common.VimApi
{
	public class VirtualDiskDeltaDiskFormatsSupported : DynamicData
	{
		protected string _datastoreType;
		protected ChoiceOption _deltaDiskFormat;
		public string DatastoreType
		{
			get
			{
				return this._datastoreType;
			}
			set
			{
				this._datastoreType = value;
			}
		}
		public ChoiceOption DeltaDiskFormat
		{
			get
			{
				return this._deltaDiskFormat;
			}
			set
			{
				this._deltaDiskFormat = value;
			}
		}
	}
}
