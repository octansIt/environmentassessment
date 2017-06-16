namespace EnvironmentAssessment.Common.VISoap
{
    public class OvfCreateDescriptorParams : DynamicData
	{
		protected OvfFile[] _ovfFiles;
		protected string _name;
		protected string _description;
		protected bool? _includeImageFiles;
		protected string[] _exportOption;
		protected ManagedObjectReference _snapshot;
		protected OvfCreateDescriptorParams_LinkedView _linkedView;
		public OvfFile[] OvfFiles
		{
			get
			{
				return this._ovfFiles;
			}
			set
			{
				this._ovfFiles = value;
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
		public string Description
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
		public bool? IncludeImageFiles
		{
			get
			{
				return this._includeImageFiles;
			}
			set
			{
				this._includeImageFiles = value;
			}
		}
		public string[] ExportOption
		{
			get
			{
				return this._exportOption;
			}
			set
			{
				this._exportOption = value;
			}
		}
		public ManagedObjectReference Snapshot
		{
			get
			{
				return this._snapshot;
			}
			set
			{
				this._snapshot = value;
			}
		}
		public OvfCreateDescriptorParams_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
