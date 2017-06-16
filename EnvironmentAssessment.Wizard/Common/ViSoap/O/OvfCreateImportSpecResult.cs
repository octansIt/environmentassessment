namespace EnvironmentAssessment.Common.VISoap
{
    public class OvfCreateImportSpecResult : DynamicData
	{
		protected ImportSpec _importSpec;
		protected OvfFileItem[] _fileItem;
		protected LocalizedMethodFault[] _warning;
		protected LocalizedMethodFault[] _error;
		public ImportSpec ImportSpec
		{
			get
			{
				return this._importSpec;
			}
			set
			{
				this._importSpec = value;
			}
		}
		public OvfFileItem[] FileItem
		{
			get
			{
				return this._fileItem;
			}
			set
			{
				this._fileItem = value;
			}
		}
		public LocalizedMethodFault[] Warning
		{
			get
			{
				return this._warning;
			}
			set
			{
				this._warning = value;
			}
		}
		public LocalizedMethodFault[] Error
		{
			get
			{
				return this._error;
			}
			set
			{
				this._error = value;
			}
		}
	}
}
