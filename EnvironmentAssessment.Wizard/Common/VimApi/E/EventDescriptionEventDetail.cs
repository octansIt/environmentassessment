namespace EnvironmentAssessment.Common.VimApi
{
	public class EventDescriptionEventDetail : DynamicData
	{
		protected string _key;
		protected string _description;
		protected string _category;
		protected string _formatOnDatacenter;
		protected string _formatOnComputeResource;
		protected string _formatOnHost;
		protected string _formatOnVm;
		protected string _fullFormat;
		protected string _longDescription;
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
		public string Category
		{
			get
			{
				return this._category;
			}
			set
			{
				this._category = value;
			}
		}
		public string FormatOnDatacenter
		{
			get
			{
				return this._formatOnDatacenter;
			}
			set
			{
				this._formatOnDatacenter = value;
			}
		}
		public string FormatOnComputeResource
		{
			get
			{
				return this._formatOnComputeResource;
			}
			set
			{
				this._formatOnComputeResource = value;
			}
		}
		public string FormatOnHost
		{
			get
			{
				return this._formatOnHost;
			}
			set
			{
				this._formatOnHost = value;
			}
		}
		public string FormatOnVm
		{
			get
			{
				return this._formatOnVm;
			}
			set
			{
				this._formatOnVm = value;
			}
		}
		public string FullFormat
		{
			get
			{
				return this._fullFormat;
			}
			set
			{
				this._fullFormat = value;
			}
		}
		public string LongDescription
		{
			get
			{
				return this._longDescription;
			}
			set
			{
				this._longDescription = value;
			}
		}
	}
}
