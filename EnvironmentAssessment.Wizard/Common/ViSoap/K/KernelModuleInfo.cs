namespace EnvironmentAssessment.Common.VISoap
{
    public class KernelModuleInfo : DynamicData
	{
		protected int _id;
		protected string _name;
		protected string _version;
		protected string _filename;
		protected string _optionString;
		protected bool _loaded;
		protected bool _enabled;
		protected int _useCount;
		protected KernelModuleSectionInfo _readOnlySection;
		protected KernelModuleSectionInfo _writableSection;
		protected KernelModuleSectionInfo _textSection;
		protected KernelModuleSectionInfo _dataSection;
		protected KernelModuleSectionInfo _bssSection;
		public int Id
		{
			get
			{
				return this._id;
			}
			set
			{
				this._id = value;
			}
		}
		public string Name
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
		public string Version
		{
			get
			{
				return this._version;
			}
			set
			{
				this._version = value;
			}
		}
		public string Filename
		{
			get
			{
				return this._filename;
			}
			set
			{
				this._filename = value;
			}
		}
		public string OptionString
		{
			get
			{
				return this._optionString;
			}
			set
			{
				this._optionString = value;
			}
		}
		public bool Loaded
		{
			get
			{
				return this._loaded;
			}
			set
			{
				this._loaded = value;
			}
		}
		public bool Enabled
		{
			get
			{
				return this._enabled;
			}
			set
			{
				this._enabled = value;
			}
		}
		public int UseCount
		{
			get
			{
				return this._useCount;
			}
			set
			{
				this._useCount = value;
			}
		}
		public KernelModuleSectionInfo ReadOnlySection
		{
			get
			{
				return this._readOnlySection;
			}
			set
			{
				this._readOnlySection = value;
			}
		}
		public KernelModuleSectionInfo WritableSection
		{
			get
			{
				return this._writableSection;
			}
			set
			{
				this._writableSection = value;
			}
		}
		public KernelModuleSectionInfo TextSection
		{
			get
			{
				return this._textSection;
			}
			set
			{
				this._textSection = value;
			}
		}
		public KernelModuleSectionInfo DataSection
		{
			get
			{
				return this._dataSection;
			}
			set
			{
				this._dataSection = value;
			}
		}
		public KernelModuleSectionInfo BssSection
		{
			get
			{
				return this._bssSection;
			}
			set
			{
				this._bssSection = value;
			}
		}
	}
}
