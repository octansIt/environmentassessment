namespace EnvironmentAssessment.Common.VimApi
{
	public class DiagnosticManagerLogDescriptor : DynamicData
	{
		protected string _key;
		protected string _fileName;
		protected string _creator;
		protected string _format;
		protected string _mimeType;
		protected Description _info;
		public string Key
		{
			get
			{
				return this._key;
			}
			set
			{
				this._key = value;
			}
		}
		public string FileName
		{
			get
			{
				return this._fileName;
			}
			set
			{
				this._fileName = value;
			}
		}
		public string Creator
		{
			get
			{
				return this._creator;
			}
			set
			{
				this._creator = value;
			}
		}
		public string Format
		{
			get
			{
				return this._format;
			}
			set
			{
				this._format = value;
			}
		}
		public string MimeType
		{
			get
			{
				return this._mimeType;
			}
			set
			{
				this._mimeType = value;
			}
		}
		public Description Info
		{
			get
			{
				return this._info;
			}
			set
			{
				this._info = value;
			}
		}
	}
}
