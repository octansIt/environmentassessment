namespace EnvironmentAssessment.Common.VISoap
{
    public class OvfCreateDescriptorResult : DynamicData
	{
		protected string _ovfDescriptor;
		protected LocalizedMethodFault[] _error;
		protected LocalizedMethodFault[] _warning;
		protected bool? _includeImageFiles;
		public string OvfDescriptor
		{
			get
			{
				return this._ovfDescriptor;
			}
			set
			{
				this._ovfDescriptor = value;
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
	}
}
